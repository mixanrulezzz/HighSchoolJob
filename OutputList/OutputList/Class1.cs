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

        public static void ShipmentsIntoSQL(SQLiteConnection DataFile, ShipmentList ShipList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ShipList.Count; i++)
            {
                insert.CommandText = "insert into Shipment values(" + ShipList[i].ShipmentID.ToString() + ", '" + ShipList[i].ShipmentName + "', " + ShipList[i].Price.ToString() + ", '" + ShipList[i].PhotoLink + "')";
                insert.ExecuteNonQuery();
            }
        }

        public static void ClientsIntoSQL(SQLiteConnection DataFile, ClientList CList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < CList.Count; i++)
            {
                insert.CommandText = "insert into Client values(" + CList[i].ClientID.ToString() + ", '" + CList[i].ClientFirstName + "', '" + CList[i].ClientLastName + "')";
                insert.ExecuteNonQuery();
            }
        }

        public static void ProvidersIntoSQL(SQLiteConnection DataFile, ProviderList ProvList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ProvList.Count; i++)
            {
                insert.CommandText = "insert into Provider values(" + ProvList[i].ProviderID.ToString() + ", '" + ProvList[i].ProviderName + "')";
                insert.ExecuteNonQuery();
            }
        }

        public static void ProviderShipmentsIntoSQL(SQLiteConnection DataFile, ProviderShipmentList ProvShipList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < ProvShipList.Count; i++)
            {
                insert.CommandText = "insert into ProviderShipment values(" + ProvShipList[i].ShipmentID.ToString() + ", " + ProvShipList[i].ProviderID.ToString() + ")";
                insert.ExecuteNonQuery();
            }
        }

        public static void PurchaseHistoryIntoSQL(SQLiteConnection DataFile, PurchaseHistoryList PurHisList)
        {
            SQLiteCommand insert = new SQLiteCommand(DataFile);
            for (int i = 0; i < PurHisList.Count; i++)
            {
                insert.CommandText = "insert into PurchaseHistory values(" + PurHisList[i].PurchaseHistoryID.ToString() + ", " + PurHisList[i].ShipmentID.ToString() + ", " + PurHisList[i].ClientID.ToString() + ", " + PurHisList[i].Count.ToString() + ", '" + PurHisList[i].HistoryDate.Year.ToString() + "-";
                if (PurHisList[i].HistoryDate.Month < 10)
                    insert.CommandText += "0" + PurHisList[i].HistoryDate.Month.ToString() + "-";
                else
                    insert.CommandText += PurHisList[i].HistoryDate.Month.ToString() + "-";
                if (PurHisList[i].HistoryDate.Day < 10)
                    insert.CommandText += "0" + PurHisList[i].HistoryDate.Day.ToString() + "')";
                else
                    insert.CommandText += PurHisList[i].HistoryDate.Day.ToString() + "))";
                insert.ExecuteNonQuery();
            }
        }
    }
}
