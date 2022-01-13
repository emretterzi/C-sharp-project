using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace kargoTakip
{
    class Operations
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "zxU8Mvlsbk6RSL9xp8sA1ysKFaa50hKKlW67SCTr",
            BasePath = "https://kargotkp-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;

        public Operations()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                Console.Write("Bağlantı başarılı!");
            }
            catch (Exception)
            {
                Console.Write("Bağlantı kurulamadı...");
                throw;
            }
        }

        public bool Register(Courier userInfo)
        {
            try
            {
                SetResponse set = client.Set(@"Couriers/" + userInfo.courierName, userInfo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Login(string courierName, string password)
        {
            FirebaseResponse res = client.Get(@"Couriers/" + courierName);
            Courier DbCourier = res.ResultAs<Courier>();
            if (DbCourier != null)
            {
                if (DbCourier.courierName != courierName)
                {
                    return false;
                }
                else if( DbCourier.password!=password)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddCargo(Customer customerInfo)
        {
            try
            {
                SetResponse set = client.Set(@"Customers/" + customerInfo.customerName, customerInfo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
