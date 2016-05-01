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
using ListsFilling;

namespace kursov_rabota
{
    public partial class StartScreen : Form
    {
        public SQLiteConnection DataFile = new SQLiteConnection("Data Source=mySQLiteLab.sqlite;Version=3");
        public int MaxProductID;
        public int MaxClientID;
        public int MaxProviderID;
        public int MaxByingHistoryID;
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

            CreateTable.Shipment(DataFile);
            CreateTable.Client(DataFile);
            CreateTable.Provider(DataFile);
            CreateTable.ShipmentProvider(DataFile);
            CreateTable.PurchaseHistory(DataFile);

            Shipments = ListsFilling.ListsFilling.Shipment(DataFile);
            Providers = ListsFilling.ListsFilling.Provider(DataFile);
            Clients = ListsFilling.ListsFilling.Client(DataFile);
            ProvidersShipments = ListsFilling.ListsFilling.ProviderShipment(DataFile);
            PurchaseHistoryL = ListsFilling.ListsFilling.PurchaseHistory(DataFile);

            MaxProductID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prod");
            MaxClientID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "cl");
            MaxProviderID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "prov");
            MaxByingHistoryID = SearchMaxID.SearchMaxID.FindMaxID(DataFile, "ph");
        }

        private void create_Click(object sender, EventArgs e)
        {
            HalfWayScreen HalfWayScr = new HalfWayScreen();
            HalfWayScr.ChoosingRegime = "Create";
            this.Visible = false;
            HalfWayScr.ShowDialog(this);            
        }
    }
}
