
namespace kargoTakip
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnDirections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyMap
            // 
            this.MyMap.Bearing = 0F;
            this.MyMap.CanDragMap = true;
            this.MyMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MyMap.GrayScaleMode = false;
            this.MyMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MyMap.LevelsKeepInMemory = 5;
            this.MyMap.Location = new System.Drawing.Point(1, 0);
            this.MyMap.MarkersEnabled = true;
            this.MyMap.MaxZoom = 2;
            this.MyMap.MinZoom = 2;
            this.MyMap.MouseWheelZoomEnabled = true;
            this.MyMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MyMap.Name = "MyMap";
            this.MyMap.NegativeMode = false;
            this.MyMap.PolygonsEnabled = true;
            this.MyMap.RetryLoadTile = 0;
            this.MyMap.RoutesEnabled = true;
            this.MyMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MyMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MyMap.ShowTileGridLines = false;
            this.MyMap.Size = new System.Drawing.Size(1591, 1082);
            this.MyMap.TabIndex = 3;
            this.MyMap.Zoom = 0D;
            this.MyMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyMap_MouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1645, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1843, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "KALDIR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(1645, 64);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(187, 31);
            this.txtCargo.TabIndex = 6;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(1645, 169);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(187, 31);
            this.txtLatitude.TabIndex = 7;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(1645, 270);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(187, 31);
            this.txtLongitude.TabIndex = 8;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(1645, 16);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 25);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "İSİM";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(1645, 125);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(67, 25);
            this.lblLatitude.TabIndex = 10;
            this.lblLatitude.Text = "ENLEM";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(1645, 226);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(83, 25);
            this.lblLongitude.TabIndex = 11;
            this.lblLongitude.Text = "BOYLAM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1645, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(359, 352);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectRegistry);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(1645, 823);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(143, 71);
            this.btnArea.TabIndex = 13;
            this.btnArea.Text = "ALAN SINIRLA";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.Location = new System.Drawing.Point(1861, 824);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(143, 70);
            this.btnRoute.TabIndex = 14;
            this.btnRoute.Text = "ROTA ÇİZ";
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.route_Click);
            // 
            // btnDirections
            // 
            this.btnDirections.Location = new System.Drawing.Point(1645, 940);
            this.btnDirections.Name = "btnDirections";
            this.btnDirections.Size = new System.Drawing.Size(143, 63);
            this.btnDirections.TabIndex = 15;
            this.btnDirections.Text = "YOL TARİFİ";
            this.btnDirections.UseVisualStyleBackColor = true;
            this.btnDirections.Click += new System.EventHandler(this.btnDirections_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1084);
            this.Controls.Add(this.btnDirections);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.MyMap);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl MyMap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnDirections;
    }
}