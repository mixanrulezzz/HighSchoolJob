using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace CreateSQLTables
{
    public static class CreateTable
    {
        public static void CreateAll(SQLiteConnection DataFile)
        {
            Shipment(DataFile);
            Client(DataFile);
            Provider(DataFile);
            ProviderShipment(DataFile);
            PurchaseHistory(DataFile);
        }

        public static void Shipment(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Shipment(shid INTEGER NOT NULL, shName VARCHAR(50) NOT NULL, Price INTEGER NOT NULL, PhotoLink varchar(100) NOT NULL, CONSTRAINT ShipmentPK PRIMARY KEY (shid));";
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void Client(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Client(clid INTEGER NOT NULL, clFirstName VARCHAR(20) NOT NULL, clLastName VARCHAR(20), CONSTRAINT ClientPK PRIMARY KEY (clid));";
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void Provider(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Provider(provid INTEGER NOT NULL, provName VARCHAR(40) NOT NULL, CONSTRAINT ProvPK PRIMARY KEY (provid));";
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void ProviderShipment(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table ProviderShipment(shid INTEGER NOT NULL, provid INTEGER NOT NULL, CONSTRAINT ProdProvPK PRIMARY KEY (shid, provid), CONSTRAINT ShipmentFK FOREIGN KEY (shid) REFERENCES Shipment (shid) ON DELETE CASCADE, CONSTRAINT ProvFK FOREIGN KEY (provid) REFERENCES Provider (provid) ON DELETE CASCADE);";
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void PurchaseHistory(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table PurchaseHistory(phid INTEGER NOT NULL, shid INTEGER NOT NULL, clid INTEGER NOT NULL, count INTEGER NOT NULL, HistoryDate varchar(10) NOT NULL, CONSTRAINT phPK PRIMARY KEY (phid), CONSTRAINT ShipmentFK FOREIGN KEY (shid) REFERENCES Shipment (shid) ON DELETE CASCADE, CONSTRAINT ClientFK FOREIGN KEY (clid) REFERENCES Client (clid) ON DELETE CASCADE);";
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }
    }
}
