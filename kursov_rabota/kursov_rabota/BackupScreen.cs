using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutputList;

namespace kursov_rabota
{
    public partial class BackupScreen : Form
    {
        public BackupScreen()
        {
            InitializeComponent();
        }

        private void InBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "XML File|*.xml";
            SFD.Title = "Save Backup";
            SFD.FileName = "Backup " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + " " + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            SFD.ShowDialog();
            string file = SFD.FileName;
            OutputList.OutputList.OutputIntoXML(file, Program.StScreen.Shipments, Program.StScreen.Clients, Program.StScreen.Providers, Program.StScreen.ProvidersShipments, Program.StScreen.PurchaseHistoryL);
            MessageBox.Show("Резевная копия создана успешно");
        }

        private void OutBackup_Click(object sender, EventArgs e)
        {

        }

        private void BackupScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.StScreen.Visible = true;
        }
    }
}
