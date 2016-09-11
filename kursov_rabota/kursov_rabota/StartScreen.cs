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
using BackupClass;
using ReportLibrary;
using FormatDateLibrary;

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
        private string SavingFile;

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

        private void PackingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackingListScreen PLS = new PackingListScreen(true);
            PLS.ShowDialog();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackingListScreen PLS = new PackingListScreen(false);
            PLS.ShowDialog();
        }

        private void CreateBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "XML файл|*.xml";
            SFD.Title = "Сохранить резервную копию";
            SFD.FileName = "Backup" + FormatDate.GetNowDate();
            SavingFile = "Backup";
            SFD.ShowDialog();
        }

        private void SFD_FileOk(object sender, CancelEventArgs e)
        {
            string file = SFD.FileName;
            switch (SavingFile)
            {
                case "Backup": OutputList.OutputList.OutputIntoXML(file, Shipments, Clients, Providers, ProvidersShipments, PurchaseHistoryL);
                    MessageBox.Show("Резевная копия создана успешно");
                    break;
                case "ClientReport": Report.ClientReport(file, Clients, Shipments, PurchaseHistoryL);
                    MessageBox.Show("Отчет по клиентам создан успешно");                                   
                    break;
                case "ShipmentReport": Report.ShipmentReport(file, Shipments, PurchaseHistoryL);
                    MessageBox.Show("Отчет по товарам создан успешно");
                    break;
                case "PurchaseHistoryReport": Report.PurchaseHistoryReport(file, Shipments, PurchaseHistoryL);
                    MessageBox.Show("Отчет по продажам создан успешно");
                    break;
                default: MessageBox.Show("");
                    break;
            }
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
            BackupClass.BackupClass Backup = InputList.InputList.Backup(file);
            
            Shipments = Backup.Shipments;
            Clients = Backup.Clients;
            Providers = Backup.Providers;
            ProvidersShipments = Backup.ProviderShipment;
            PurchaseHistoryL = Backup.PurchaseHistory;
            
            MessageBox.Show("Списки успешно перезаписаны");
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFromSQLTables.DeleteFromSQLTables.DeleteAll(DataFile);
            OutputList.OutputList.OutputIntoSQL(DataFile, Shipments, Clients, Providers, ProvidersShipments, PurchaseHistoryL);
        }

        private void ClientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "PDF файл|*.pdf";
            SFD.Title = "Сохранить отчет по клиентам";
            SFD.FileName = "Отчет по клиентам на " + FormatDate.GetNowDate();
            SavingFile = "ClientReport";
            SFD.ShowDialog();
        }

        private void ShipmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "PDF файл|*.pdf";
            SFD.Title = "Сохранить отчет по товарам";
            SFD.FileName = "Отчет по товарам на " + FormatDate.GetNowDate();
            SavingFile = "ShipmentReport";
            SFD.ShowDialog();
        }

        private void PurchaseHistoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "PDF файл|*.pdf";
            SFD.Title = "Сохранить отчет по продажам";
            SFD.FileName = "Отчет по продажам на " + FormatDate.GetNowDate();
            SavingFile = "PurchaseHistoryReport";
            SFD.ShowDialog();
        }
    }
}
