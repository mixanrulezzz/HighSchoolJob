using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DeleteSQLTables
{
    public static class DeleteSQLTables
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
            try
            {
                SQLiteCommand Delete = new SQLiteCommand(DataFile);
                Delete.CommandText = "drop table Shipment;";
                Delete.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void DeleteClient(SQLiteConnection DataFile)
        {
            try
            {
                SQLiteCommand Delete = new SQLiteCommand(DataFile);
                Delete.CommandText = "drop table Client;";
                Delete.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void DeleteProvider(SQLiteConnection DataFile)
        {
            try
            {
                SQLiteCommand Delete = new SQLiteCommand(DataFile);
                Delete.CommandText = "drop table Provider;";
                Delete.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void DeleteProviderShipment(SQLiteConnection DataFile)
        {
            try
            {
                SQLiteCommand Delete = new SQLiteCommand(DataFile);
                Delete.CommandText = "drop table ProviderShipment;";
                Delete.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void DeletePurchaseHistory(SQLiteConnection DataFile)
        {
            try
            {
                SQLiteCommand Delete = new SQLiteCommand(DataFile);
                Delete.CommandText = "drop table PurchaseHistory;";
                Delete.ExecuteNonQuery();
            }
            catch (Exception) { }
        }
    }
}
