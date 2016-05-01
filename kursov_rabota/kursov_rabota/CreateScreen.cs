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
            HideAll();
            switch (HalfWayScreen.ChoosingTable)
            {
                case "Shipment": ShipmentVisible();
                    break;
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

        private void HideAll()
        {
            FirstListBox.Visible = false;
            SecondListBox.Visible = false;
            CreateButton.Visible = false;
            IDLabel.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            IDTextBox.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            PurchaseHistoryDate.Visible = false;
            PhotoPictureBox.Visible = false;
            
        }

        private void ShipmentVisible()
        {
            FirstListBox.Visible = true;
            IDLabel.Visible = true;
            IDLabel.Text = "ID товара";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "Название товара";
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Цена товара";
            textBox2.Visible = true;
            label4.Visible = true;
            label4.Text = "Ссылка на фото";
            textBox3.Visible = true;
            PhotoPictureBox.Visible = true;
        }
    }
}
