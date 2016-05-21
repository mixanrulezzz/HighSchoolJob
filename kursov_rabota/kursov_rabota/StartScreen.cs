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
        public CreateUpdateDeleteScreen CrUpdDelScr;

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

        private void ShipmentCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Create, Tables.Shipment);
            CrUpdDelScr.ShowDialog();
        }

        private void ClientCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Create, Tables.Client);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Create, Tables.Provider);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderShipmentCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Create, Tables.ProviderShipment);
            CrUpdDelScr.ShowDialog();
        }

        private void PurchaseHistoryCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Create, Tables.PurchaseHistory);
            CrUpdDelScr.ShowDialog();
        }

        private void ShipmentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Update, Tables.Shipment);
            CrUpdDelScr.ShowDialog();
        }

        private void ClientUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Update, Tables.Client);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Update, Tables.Provider);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderShipmentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Update, Tables.ProviderShipment);
            CrUpdDelScr.ShowDialog();
        }

        private void PurchaseHistoryUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Update, Tables.PurchaseHistory);
            CrUpdDelScr.ShowDialog();
        }

        private void ShipmentDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Delete, Tables.Shipment);
            CrUpdDelScr.ShowDialog();
        }

        private void ClientDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Delete, Tables.Client);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Delete, Tables.Provider);
            CrUpdDelScr.ShowDialog();
        }

        private void ProviderShipmentDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Delete, Tables.ProviderShipment);
            CrUpdDelScr.ShowDialog();
        }

        private void PurchaseHistoryDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrUpdDelScr = new CreateUpdateDeleteScreen(Regimes.Delete, Tables.PurchaseHistory);
            CrUpdDelScr.ShowDialog();
        }

        private void PakingListButton_Click(object sender, EventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void CreateBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "XML файл|*.xml";
            SFD.Title = "Сохранить резервную копию";
            SFD.FileName = "Backup" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            SFD.ShowDialog();
        }

        private void SFD_FileOk(object sender, CancelEventArgs e)
        {
            string file = SFD.FileName;
            OutputList.OutputList.OutputIntoXML(file, Shipments, Clients, Providers, ProvidersShipments, PurchaseHistoryL);
            MessageBox.Show("Резевная копия создана успешно");
        }

        private void LoadBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OFD.Filter = "XML файл|*.xml";
            OFD.Title = "Открыть резервную копию";
            OFD.ShowDialog();           
        }

        private void OFD_FileOk(object sender, CancelEventArgs e)
        {
            string file = OFD.FileName;
            Shipments = InputList.InputList.ShipmentFromXML(file);
            Clients = InputList.InputList.ClientFromXML(file);
            Providers = InputList.InputList.ProviderFromXML(file);
            ProvidersShipments = InputList.InputList.ProviderShipmentFromXML(file);
            PurchaseHistoryL = InputList.InputList.PurchaseHistoryFromXML(file);
            MessageBox.Show("Списки успешно перезаписаны");
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFromSQLTables.DeleteFromSQLTables.DeleteAll(DataFile);
            OutputList.OutputList.OutputIntoSQL(DataFile, Shipments, Clients, Providers, ProvidersShipments, PurchaseHistoryL);
        }
    }
}
