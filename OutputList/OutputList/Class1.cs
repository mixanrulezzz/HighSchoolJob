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
using System.IO;
using XMLSerializator;

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
                insert.CommandText = "insert into PurchaseHistory values(" + PurHisList[i].PurchaseHistoryID.ToString() + ", " + PurHisList[i].ShipmentID.ToString() + ", " + PurHisList[i].ClientID.ToString() + ", " + PurHisList[i].Count.ToString() + ", '" + PurHisList[i].HistoryDate.Year.ToString() + "-";
                if (PurHisList[i].HistoryDate.Month < 10)
                    insert.CommandText += "0" + PurHisList[i].HistoryDate.Month.ToString() + "-";
                else
                    insert.CommandText += PurHisList[i].HistoryDate.Month.ToString() + "-";
                if (PurHisList[i].HistoryDate.Day < 10)
                    insert.CommandText += "0" + PurHisList[i].HistoryDate.Day.ToString() + "')";
                else
                    insert.CommandText += PurHisList[i].HistoryDate.Day.ToString() + "')";
                insert.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Создает резервную копию таблиц сущностей
        /// </summary>
        /// <param name="file">Путь к резервной копии</param>
        /// <param name="ShipList">Список Товаров</param>
        /// <param name="ClList">Список Клиентов</param>
        /// <param name="ProvList">Список Поставщиков</param>
        /// <param name="ProvShipList">Список связей Поставщик-Товар</param>
        /// <param name="PurHisList">Список Истории Покупок</param>
        public static void OutputIntoXML(string file, ShipmentList ShipList, ClientList ClList, ProviderList ProvList, ProviderShipmentList ProvShipList, PurchaseHistoryList PurHisList)
        {
            FileStream NewFile = new FileStream(file, FileMode.Create);
            NewFile.Close();
            ShipmentIntoXML(file, ShipList);
            ClientIntoXML(file, ClList);
            ProviderIntoXML(file, ProvList);
            ProviderShipmentIntoXML(file, ProvShipList);
            PurchaseHistoryIntoXML(file, PurHisList);
        }

        private static void ShipmentIntoXML(string file, ShipmentList ShipList)
        {
            XMLSer<ShipmentList>.Serializator(file, ShipList);
        }

        private static void ClientIntoXML(string file, ClientList ClList)
        {
            XMLSer<ClientList>.Serializator(file, ClList);
        }

        private static void ProviderIntoXML(string file, ProviderList ProvList)
        {
            XMLSer<ProviderList>.Serializator(file, ProvList);
        }

        private static void ProviderShipmentIntoXML(string file, ProviderShipmentList ProvShipList)
        {
            XMLSer<ProviderShipmentList>.Serializator(file, ProvShipList);
        }

        private static void PurchaseHistoryIntoXML(string file, PurchaseHistoryList PurHisList)
        {
            XMLSer<PurchaseHistoryList>.Serializator(file, PurHisList);
        }
    }
}
