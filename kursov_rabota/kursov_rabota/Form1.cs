﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using CreateSQLTables;
using SearchMaxID;

namespace kursov_rabota
{
    public partial class StartScreen : Form
    {
        private SQLiteConnection DataFile = new SQLiteConnection("Data Source=C:/Games/mySQLiteLab.sqlite;Version=3");
        private int MaxProductID;
        private int MaxClientID;
        private int MaxProviderID;
        private int MaxByingHistoryID;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            if (!File.Exists("mySQLiteLab.sqlite"))
            {
                SQLiteConnection.CreateFile("mySQLiteLab.sqlite");
            }

            CreateTable.Product(DataFile);
            CreateTable.Client(DataFile);
            CreateTable.Provider(DataFile);
            CreateTable.ProductProvider(DataFile);
            CreateTable.ByingHistory(DataFile);

            MaxProductID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prod");
            MaxClientID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "cl");
            MaxProviderID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prov");
            MaxByingHistoryID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "bh");
        }
    }
}
