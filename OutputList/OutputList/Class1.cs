using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ShipmentLibrary;
using ClientLibrary;
using ProviderLibrary;
using ProviderShipmentLibrary;
using PurchaseHistoryLibrary;
using System.Data.SQLite;
using System.IO;
using XMLSerializator;
using BackupClass;

namespace OutputList
{
    public static class OutputList
    {
        public static void OutputIntoSQL(SQLiteConnection DataFile, ShipmentList ShipList, ClientList CList, ProviderList ProvList, ProviderShipmentList ProvShipList, PurchaseHistoryList PurHisList)
        {
            ShipmentsIntoSQL(DataFile, ShipList);
            ClientsIntoSQL(DataFile, CList);
            ProvidersIntoSQL(DataFile, ProvList);
            ProviderShipmentsIntoSQL(DataFile, ProvShipList);
            PurchaseHistoryIntoSQL(DataFile, PurHisList);
        }

        private static void ShipmentsIntoSQL(SQLiteConnection DataFile, ShipmentList ShipList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ShipList.Count; i++)
            {
                insert.CommandText = "insert into Shipment values(" + ShipList[i].ShipmentID.ToString() + ", '" + ShipList[i].ShipmentName + "', " + ShipList[i].Price.ToString() + ", '" + ShipList[i].PhotoLink + "')";
                insert.ExecuteNonQuery();
            }
        }

        private static void ClientsIntoSQL(SQLiteConnection DataFile, ClientList CList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < CList.Count; i++)
            {
                insert.CommandText = "insert into Client values(" + CList[i].ClientID.ToString() + ", '" + CList[i].ClientFirstName + "', '" + CList[i].ClientLastName + "')";
                insert.ExecuteNonQuery();
            }
        }

        private static void ProvidersIntoSQL(SQLiteConnection DataFile, ProviderList ProvList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ProvList.Count; i++)
            {
                insert.CommandText = "insert into Provider values(" + ProvList[i].ProviderID.ToString() + ", '" + ProvList[i].ProviderName + "')";
                insert.ExecuteNonQuery();
            }
        }

        private static void ProviderShipmentsIntoSQL(SQLiteConnection DataFile, ProviderShipmentList ProvShipList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ProvShipList.Count; i++)
            {
                insert.CommandText = "insert into ProviderShipment values(" + ProvShipList[i].ProviderID.ToString() + ", " + ProvShipList[i].ShipmentID.ToString() + ")";
                insert.ExecuteNonQuery();
            }
        }

        private static void PurchaseHistoryIntoSQL(SQLiteConnection DataFile, PurchaseHistoryList PurHisList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < PurHisList.Count; i++)
            {
                insert.CommandText = "insert into PurchaseHistory values(" + PurHisList[i].PurchaseHistoryID.ToString() + ", " + PurHisList[i].ShipmentID.ToString() + ", " + PurHisList[i].ClientID.ToString() + ", " + PurHisList[i].Count.ToString() + ", '" + PurHisList[i].Year.ToString() + "-";
                if (PurHisList[i].Month < 10)
                    insert.CommandText += "0" + PurHisList[i].Month.ToString() + "-";
                else
                    insert.CommandText += PurHisList[i].Month.ToString() + "-";
                if (PurHisList[i].Day < 10)
                    insert.CommandText += "0" + PurHisList[i].Day.ToString() + "')";
                else
                    insert.CommandText += PurHisList[i].Day.ToString() + "')";
                insert.ExecuteNonQuery();
            }
        }
        
        public static void OutputIntoXML(string file, ShipmentList ShipList, ClientList ClList, ProviderList ProvList, ProviderShipmentList ProvShipList, PurchaseHistoryList PurHisList)
        {
            BackupClass.BackupClass BC = new BackupClass.BackupClass(ClList, ProvList, ShipList, ProvShipList, PurHisList);
            StreamWriter NewFile = new StreamWriter(file);
            XmlSerializer XMLSer = new XmlSerializer(typeof(BackupClass.BackupClass));
            XMLSer.Serialize(NewFile, BC);            
            NewFile.Close();
        }        
    }
}
