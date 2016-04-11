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
        public static void Bagage(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Bagage(bagid INTEGER PRIMARY KEY, bagName VARCHAR(50) NOT NULL, Price INTEGER NOT NULL, PhotoLink varvhar(100) NOT NULL);";
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
                create.CommandText = "create table Client(clid INTEGER PRIMARY KEY, clName VARCHAR(15) NOT NULL, clAge INTEGER NOT NULL);";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void Creator(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table Creator(crid INTEGER PRIMARY KEY, crName VARCHAR(15) NOT NULL);";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        public static void BagageCreator(SQLiteConnection File)
        {
            try
            {
                SQLiteCommand create = new SQLiteCommand(File);
                create.CommandText = "create table BagageCreator(bagid INTEGER NOT NULL, crid INTEGER NOT NULL, CONSTRAINT BagCrPK PRIMARY KEY (bagid, crid));";
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
                create.CommandText = "create table ByingHistoory(bhid INTEGER PRIMARY KEY, bagid INTEGER NOT NULL, clid INTEGER NOT NULL, count INTEGER NOT NULL, );";
                File.Open();
                create.ExecuteNonQuery();
            }
            catch (Exception) { }
        }
    }
}
