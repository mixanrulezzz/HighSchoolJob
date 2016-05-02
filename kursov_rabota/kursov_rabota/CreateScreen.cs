using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipmentLibrary;
using ClientLibrary;
using ProviderLibrary;
using ProviderShipmentLibrary;
using PurchaseHistoryLibrary;

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
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case "Client": ClientVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case "Provider": ProviderVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case "ProviderShipment": break;
                case "PurchaseHistory": break;
                default: break;
            }
        }

        private void CreateScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                Program.StScreen.Visible = true;
                Program.StScreen.HalfWayScr.Close();
            }
        }

        private void RefreshFirstListBox()
        {
            FirstListBox.Items.Clear();
            switch (HalfWayScreen.ChoosingTable)
            {
                case "Shipment": for (int i = 0; i < Program.StScreen.Shipments.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Shipments[i]);
                    }
                    break;
                case "Client": for (int i = 0; i < Program.StScreen.Clients.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Clients[i]);
                    }
                    break;
                case "Provider": for (int i = 0; i < Program.StScreen.Providers.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Providers[i]);
                    }
                    break;
                default: break;
            }
        }

        private void RefreshSecondListBox()
        {

        }

        private void HideAll()
        {
            FirstListBox.Visible = false;
            FirstListBox.SelectionMode = SelectionMode.One;
            SecondListBox.Visible = false;
            SecondListBox.SelectionMode = SelectionMode.One;
            FirstListBoxLabel.Visible = false;
            SecondListBoxLabel.Visible = false;
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
            FirstListBoxLabel.Visible = true;
            FirstListBoxLabel.Text = "Список товаров:";
            IDLabel.Visible = true;
            IDLabel.Text = "ID товара";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "Название товара";
            textBox1.Visible = true;
            textBox1.MaxLength = 50;
            label3.Visible = true;
            label3.Text = "Цена товара";
            textBox2.Visible = true;
            label4.Visible = true;
            label4.Text = "Ссылка на фото";
            textBox3.Visible = true;
            textBox3.MaxLength = 100;
            PhotoPictureBox.Visible = true;
            CreateButton.Visible = true;
        }

        private void ClientVisible()
        {
            FirstListBox.Visible = true;
            FirstListBoxLabel.Visible = true;
            FirstListBoxLabel.Text = "Список клиентов:";
            IDLabel.Visible = true;
            IDLabel.Text = "ID клиента";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "Имя клиента";
            textBox1.Visible = true;
            textBox1.MaxLength = 20;
            label3.Visible = true;
            label3.Text = "Фамилия клиента";
            textBox2.Visible = true;
            textBox2.MaxLength = 20;
            CreateButton.Visible = true;
        }

        private void ProviderVisible()
        {
            FirstListBox.Visible = true;
            FirstListBoxLabel.Visible = true;
            FirstListBoxLabel.Text = "Список поставщиков:";
            IDLabel.Visible = true;
            IDLabel.Text = "ID поставщика";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "Имя компании-поставщика";
            textBox1.Visible = true;
            textBox1.MaxLength = 40;
            CreateButton.Visible = true;
        }

        private void ProviderShipmentVisible()
        {

        }

        private void PurchaseHistoryVisible()
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            switch (HalfWayScreen.ChoosingTable)
            {
                case "Shipment": if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    Program.StScreen.MaxShipmentID++;
                    Program.StScreen.Shipments.Add(Program.StScreen.MaxShipmentID, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
                    RefreshFirstListBox();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    break;
                case "Client":if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    Program.StScreen.MaxClientID++;
                    Program.StScreen.Clients.Add(Program.StScreen.MaxClientID, textBox1.Text, textBox2.Text);
                    RefreshFirstListBox();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    break;
                case "Provider": if (textBox1.Text == "")
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    Program.StScreen.MaxProviderID++;
                    Program.StScreen.Providers.Add(Program.StScreen.MaxProviderID, textBox1.Text);
                    RefreshFirstListBox();
                    textBox1.Text = "";
                    break;
                default: break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HalfWayScreen.ChoosingTable == "Shipment")
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HalfWayScreen.ChoosingTable == "PurchaseHistory")
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.StScreen.HalfWayScr.Visible = true;
            this.Close();
        }
    }
}
