using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursov_rabota
{
    public partial class CreateScreen : Form
    {
        public CreateScreen()
        {
            InitializeComponent();
        }

        private void CreateScreen_Load(object sender, EventArgs e)
        {
            PurchaseHistoryDate.MaxDate = DateTime.Now;
            switch (HalfWayScreen.ChoosingTable)
            {
                case "Shipment": break;
                case "Client": break;
                case "Provider": break;
                case "ProviderShipment": break;
                case "PurchaseHistory": break;
                default: break;
            }
        }

        private void CreateScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.StScreen.Visible = true;
        }
    }
}
