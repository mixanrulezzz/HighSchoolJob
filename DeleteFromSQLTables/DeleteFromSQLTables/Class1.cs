using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DeleteFromSQLTables
{
    public static class DeleteFromSQLTables
    {
        public static void DeleteAll(SQLiteConnection DataFile)
        {
            DeletePurchaseHistory(DataFile);
            DeleteProviderShipment(DataFile);
            DeleteProvider(DataFile);
            DeleteClient(DataFile);
            DeleteShipment(DataFile);            
        }

        public static void DeleteShipment(SQLiteConnection DataFile)
        {
            SQLiteCommand DeleteData = new SQLiteCommand(DataFile);
            DeleteData.CommandText = "delete from Shipment;";
            DeleteData.ExecuteNonQuery();
        }

        public static void DeleteClient(SQLiteConnection DataFile)
        {
            SQLiteCommand DeleteData = new SQLiteCommand(DataFile);
            DeleteData.CommandText = "delete from Client;";
            DeleteData.ExecuteNonQuery();
        }

        public static void DeleteProvider(SQLiteConnection DataFile)
        {
            SQLiteCommand DeleteData = new SQLiteCommand(DataFile);
            DeleteData.CommandText = "delete from Provider;";
            DeleteData.ExecuteNonQuery();
        }

        public static void DeleteProviderShipment(SQLiteConnection DataFile)
        {
            SQLiteCommand DeleteData = new SQLiteCommand(DataFile);
            DeleteData.CommandText = "delete from ProviderShipment;";
            DeleteData.ExecuteNonQuery();
        }

        public static void DeletePurchaseHistory(SQLiteConnection DataFile)
        {
            SQLiteCommand DeleteData = new SQLiteCommand(DataFile);
            DeleteData.CommandText = "delete from PurchaseHistory;";
            DeleteData.ExecuteNonQuery();
        }
    }
}
