using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargoTakip

{









    public partial class Map : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        private readonly Operations operations = new();

        bool way = false;
        int counter = 0;
        PointLatLng start;
        PointLatLng end;


        int selectedRow = 0;
        double firstLat = 40.82168407279086;
        double firstLong=29.922955905929;
        public Map()
        {
            InitializeComponent();
        }

       
        private void Map_Load_1(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyDmk6bRMHrrvVOj1XgigA5WHmRHATQ35P0";
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Konum", typeof(string)));
            dt.Columns.Add(new DataColumn("Enlem", typeof(double)));
            dt.Columns.Add(new DataColumn("Boylam", typeof(double)));
            dt.Rows.Add("Kargo 1", firstLat, firstLong);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            MyMap.DragButton = MouseButtons.Left;
            MyMap.CanDragMap = true;
            MyMap.MapProvider = GMapProviders.GoogleMap;
            MyMap.Position = new PointLatLng(firstLat, firstLong);
            MyMap.MinZoom = 0;
            MyMap.MaxZoom = 24;
            MyMap.Zoom = 9;
            MyMap.AutoScroll = true;

            markerOverlay = new GMapOverlay("Konum");
            marker = new GMarkerGoogle(new PointLatLng(firstLat, firstLong), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("KONUM \n Enlem: {0} \n Boylam: {1}", firstLat,firstLong);
            MyMap.Overlays.Add(markerOverlay);
        }

        private void selectRegistry(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtCargo.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            txtLatitude.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            txtLongitude.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text));
            MyMap.Position = marker.Position;
        
        }

        private void MyMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = MyMap.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = MyMap.FromLocalToLatLng(e.X, e.Y).Lng;
            txtLatitude.Text = lat.ToString();
            txtLongitude.Text = lng.ToString();
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("KONUM \n Enlem: {0} \n Boylam: {1}", lat, lng);
            CreateWay(lat,lng);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customerInfo = new()
            {
                customerId=0,
                customerName = txtCargo.Text,
                customerLocation = new Location()
                {
                    latitude = txtLatitude.Text,
                    longitude = txtLongitude.Text
                },
                situation = false
            };
            bool res = operations.AddCargo(customerInfo);
            if (res)
            {
                MessageBox.Show("kaydettik!");
            }
            else
            {
                MessageBox.Show("kaydedemedik...");
            }
            dt.Rows.Add(txtCargo.Text, txtLatitude.Text, txtLongitude.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            GMapOverlay area= new GMapOverlay("Alan");
            List<PointLatLng> Corners = new List<PointLatLng>();
            double lat, lng;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                Corners.Add(new PointLatLng(lat, lng));
            }
            GMapPolygon areaCorners = new GMapPolygon(Corners, "Köşeler");
            area.Polygons.Add(areaCorners);
            MyMap.Overlays.Add(area);
            MyMap.Zoom = MyMap.Zoom + 1;
            MyMap.Zoom = MyMap.Zoom - 1;
        }

        private void route_Click(object sender, EventArgs e)
        {
            GMapOverlay route = new GMapOverlay("Rota");
            List<PointLatLng> Places = new List<PointLatLng>();
            double lat, lng;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                Places.Add(new PointLatLng(lat, lng));
            }
            GMapRoute routePlaces = new GMapRoute(Places, "Kargo");
            route.Routes.Add(routePlaces);
            MyMap.Overlays.Add(route);
            MyMap.Zoom = MyMap.Zoom + 1;
            MyMap.Zoom = MyMap.Zoom - 1;
        }

        private void btnDirections_Click(object sender, EventArgs e)
        {
            way = true;
            btnDirections.Enabled = false;
        }

        public void CreateWay(double lat, double lng)
        {
            if (way)
            {
                switch (counter)
                {
                    case 0:
                        counter++;
                        start = new PointLatLng(lat, lng);
                        break;
                    case 1:
                        counter++;
                        end = new PointLatLng(lat, lng);
                        GDirections direction;

                        var routeDirection = GMapProviders.GoogleMap.GetDirections(out direction, start, end, false, false, false, false, false);
                        GMapRoute lastRoute = new GMapRoute(direction.Route, "İZLENECEK ROTA");
                        GMapOverlay routes = new GMapOverlay("Yol");
                        routes.Routes.Add(lastRoute);
                        MyMap.Overlays.Add(routes);
                        MyMap.Zoom = MyMap.Zoom + 1;
                        MyMap.Zoom = MyMap.Zoom - 1;
                        counter = 0;
                        way = false;
                        btnDirections.Enabled = true;
                        break;
                }
            }

           /* if (way)
            {
                switch (counter)
                {
                    case 0:
                        counter++;
                        start = new PointLatLng(lat, lng);
                        break;
                    case 1:
                        counter++;
                        end = new PointLatLng(lat, lng);
                        GDirections myDirections;
                        var route = GMapProviders.GoogleMap.GetDirections(out myDirections, start, end, false, false, false, false, false);
                        var mroute = new GMapRoute(myDirections.Route, "route");
                        var routesOverlay = new GMapOverlay("routes");
                        routesOverlay.Routes.Add(mroute);
                        MyMap.Overlays.Add(routesOverlay);
                        MyMap.Zoom = MyMap.Zoom + 1;
                        MyMap.Zoom = MyMap.Zoom - 1;
                        counter = 0;
                        way = false;
                        btnDirections.Enabled = true;
                        break;
                }
            }*/
        }
    }
}
