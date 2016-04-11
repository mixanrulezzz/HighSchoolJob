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

namespace kursov_rabota
{
    public partial class StartScreen : Form
    {
        private SQLiteConnection DataFile = new SQLiteConnection("Data Source=C:/Games/mySQLiteLab.sqlite;Version=3");

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

        }
    }
}
