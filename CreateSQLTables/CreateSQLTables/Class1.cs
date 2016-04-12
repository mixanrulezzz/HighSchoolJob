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
        public static void Product(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Product(prodid INTEGER NOT NULL, prodName VARCHAR(50) NOT NULL, Price INTEGER NOT NULL, PhotoLink varchar(100) NOT NULL, CONSTRAINT ProdPK PRIMARY KEY (prodid));";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void Client(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Client(clid INTEGER NOT NULL, clName VARCHAR(15) NOT NULL, CONSTRAINT ClientPK PRIMARY KEY (clid));";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void Provider(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Provider(provid INTEGER NOT NULL, provName VARCHAR(15) NOT NULL, CONSTRAINT ProvPK PRIMARY KEY (provid));";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void ProductProvider(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table ProductProvider(prodid INTEGER NOT NULL, provid INTEGER NOT NULL, CONSTRAINT ProdProvPK PRIMARY KEY (prodid, provid), CONSTRAINT ProdFK FOREIGN KEY (prodid) REFERENCES Product (prodid) ON DELETE CASCADE, CONSTRAINT ProvFK FOREIGN KEY (provid) REFERENCES Provider (provid) ON DELETE CASCADE);";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void ByingHistory(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table ByingHistory(bhid INTEGER NOT NULL, prodid INTEGER NOT NULL, clid INTEGER NOT NULL, count INTEGER NOT NULL, HistoryDate DATE NOT NULL, CONSTRAINT bhPK PRIMARY KEY (bhid), CONSTRAINT ProdFK FOREIGN KEY (prodid) REFERENCES Product (prodid) ON DELETE CASCADE, CONSTRAINT ClientFK FOREIGN KEY (clid) REFERENCES Client (clid) ON DELETE CASCADE);";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }
    }
}
