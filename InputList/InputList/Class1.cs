using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipmentLibrary;
using ClientLibrary;
using ProviderLibrary;
using ProviderShipmentLibrary;
using PurchaseHistoryLibrary;
using System.Data.SQLite;

namespace InputList
{
    public static class InputList
    {
        public static ShipmentList Shipment(SQLiteConnection DataFile)
        {
            ShipmentList ShipList = new ShipmentList();
            SQLiteCommand input = new SQLiteCommand(DataFile);
            input.CommandText = "select * from Shipment";
            SQLiteDataReader sdr = input.ExecuteReader();
            while (sdr.Read())
            {
                ShipList.Add(Convert.ToInt32(sdr.GetValue(0)), sdr.GetValue(1).ToString(), Convert.ToInt32(sdr.GetValue(2)), sdr.GetValue(3).ToString());
            }
            return ShipList;
        }

        public static ClientList Client(SQLiteConnection DataFile)
        {
            ClientList ClientL = new ClientList();
            SQLiteCommand input = new SQLiteCommand(DataFile);
            input.CommandText = "select * from Client";
            SQLiteDataReader sdr = input.ExecuteReader();
            while (sdr.Read())
            {
                ClientL.Add(Convert.ToInt32(sdr.GetValue(0)), sdr.GetValue(1).ToString(), sdr.GetValue(2).ToString());
            }
            return ClientL;
        }

        public static ProviderList Provider(SQLiteConnection DataFile)
        {
            ProviderList ProvList = new ProviderList();
            SQLiteCommand input = new SQLiteCommand(DataFile);
            input.CommandText = "select * from Provider";
            SQLiteDataReader sdr = input.ExecuteReader();
            while (sdr.Read())
            {
                ProvList.Add(Convert.ToInt32(sdr.GetValue(0)), sdr.GetValue(1).ToString());
            }
            return ProvList;
        }

        public static ProviderShipmentList ProviderShipment(SQLiteConnection DataFile)
        {
            ProviderShipmentList ProvShipList = new ProviderShipmentList();
            SQLiteCommand input = new SQLiteCommand(DataFile);
            input.CommandText = "select * from ProviderShipment";
            SQLiteDataReader sdr = input.ExecuteReader();
            while (sdr.Read())
            {
                ProvShipList.Add(Convert.ToInt32(sdr.GetValue(0)), Convert.ToInt32(sdr.GetValue(1)));
            }
            return ProvShipList;
        }

        public static PurchaseHistoryList PurchaseHistory(SQLiteConnection DataFile)
        {
            PurchaseHistoryList PurHisList = new PurchaseHistoryList();
            SQLiteCommand input = new SQLiteCommand(DataFile);
            input.CommandText = "select * from PurchaseHistory";
            SQLiteDataReader sdr = input.ExecuteReader();
            while (sdr.Read())
            {
                string str = sdr.GetValue(4).ToString();
                string[] mas = str.Split('/');
                PurHisList.Add(Convert.ToInt32(sdr.GetValue(0)), Convert.ToInt32(sdr.GetValue(1)), Convert.ToInt32(sdr.GetValue(2)), Convert.ToInt32(sdr.GetValue(3)), Convert.ToInt32(mas[0]), Convert.ToInt32(mas[1]), Convert.ToInt32(mas[2]));
            }
            return PurHisList;
        }
    }
}

