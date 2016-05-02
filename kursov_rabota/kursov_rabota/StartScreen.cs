using System;
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
using ShipmentLibrary;
using ClientLibrary;
using ProviderLibrary;
using ProviderShipmentLibrary;
using PurchaseHistoryLibrary;
using InputList;
using DeleteFromSQLTables;

namespace kursov_rabota
{
    public partial class StartScreen : Form
    {
        public SQLiteConnection DataFile = new SQLiteConnection("Data Source=mySQLiteLab.sqlite;Version=3");
        public int MaxShipmentID;
        public int MaxClientID;
        public int MaxProviderID;
        public int MaxPurchaseHistoryID;
        public ShipmentList Shipments;
        public ClientList Clients;
        public ProviderList Providers;
        public ProviderShipmentList ProvidersShipments;
        public PurchaseHistoryList PurchaseHistoryL;

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
            DataFile.Open();

            CreateTable.CreateAll(DataFile);

            Shipments = InputList.InputList.Shipment(DataFile);
            Providers = InputList.InputList.Provider(DataFile);
            Clients = InputList.InputList.Client(DataFile);
            ProvidersShipments = InputList.InputList.ProviderShipment(DataFile);
            PurchaseHistoryL = InputList.InputList.PurchaseHistory(DataFile);

            MaxShipmentID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prod");
            MaxClientID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "cl");
            MaxProviderID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prov");
            MaxPurchaseHistoryID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "ph");
        }

        private void create_Click(object sender, EventArgs e)
        {
            HalfWayScreen HalfWayScr = new HalfWayScreen();
            HalfWayScr.ChoosingRegime = "Create";
            this.Visible = false;
            HalfWayScr.ShowDialog(this);            
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFromSQLTables.DeleteFromSQLTables.DeleteAll(DataFile);
            OutputList.OutputList.OutputIntoSQL(DataFile, Shipments, Clients, Providers, ProvidersShipments, PurchaseHistoryL);
        }
    }
}
