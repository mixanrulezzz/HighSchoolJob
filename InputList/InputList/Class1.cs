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
using XMLSerializator;

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
                string[] str = sdr.GetValue(4).ToString().Split('-');
                PurHisList.Add(Convert.ToInt32(sdr.GetValue(0)), Convert.ToInt32(sdr.GetValue(1)), Convert.ToInt32(sdr.GetValue(2)), Convert.ToInt32(sdr.GetValue(3)), Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]));
            }
            return PurHisList;
        }

        public static ShipmentList ShipmentFromXML(string File)
        {
            ShipmentList ShipList = XMLSer<ShipmentList>.Deserializator(File);
            if (ShipList == null)
            {
                ShipList = new ShipmentList();
            }
            return ShipList;
        }

        public static ClientList ClientFromXML(string File)
        {
            ClientList ClList = XMLSer<ClientList>.Deserializator(File);
            if (ClList == null)
            {
                ClList = new ClientList();
            }
            return ClList;
        }

        public static ProviderList ProviderFromXML(string File)
        {
            ProviderList ProvList = XMLSer<ProviderList>.Deserializator(File);
            if (ProvList == null)
            {
                ProvList = new ProviderList();
            }
            return ProvList;
        }

        public static ProviderShipmentList ProviderShipmentFromXML(string File)
        {
            ProviderShipmentList ProvShipList = XMLSer<ProviderShipmentList>.Deserializator(File);
            if (ProvShipList == null)
            {
                ProvShipList = new ProviderShipmentList();
            }
            return ProvShipList;
        }

        public static PurchaseHistoryList PurchaseHistoryFromXML(string File)
        {
            PurchaseHistoryList PurHisList = XMLSer<PurchaseHistoryList>.Deserializator(File);
            if (PurHisList == null)
            {
                PurHisList = new PurchaseHistoryList();
            }
            return PurHisList;
        }
    }
}

