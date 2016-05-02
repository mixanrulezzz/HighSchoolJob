﻿using System;
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
    public partial class HalfWayScreen : Form
    {
        public string ChoosingRegime = "";
        public static string ChoosingTable
        {
            get; private set;
        }

        public static void ChangeVisible()
        {
            
        }

        public HalfWayScreen()
        {
            InitializeComponent();
        }

        private void CreateScreen_Load(object sender, EventArgs e)
        {
            HelpLabel.Text = "";
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (!ShipmentRadioButton.Checked && !ClientRadioButton.Checked && !ProviderRadioButton.Checked && !ShipmentProviderRadioButton.Checked && !PurchaseHistoryRadioButton.Checked)
            {
                MessageBox.Show("Ничего не выбрано!!!");
                return;
            }
            Form NextScreen = new Form();
            switch (ChoosingRegime)
            {
                case "Create": NextScreen = new CreateScreen(); 
                    break;
                default: break;
            }
            if (ShipmentRadioButton.Checked)
            {
                ChoosingTable = "Shipment";
            }
            if (ClientRadioButton.Checked)
            {
                ChoosingTable = "Client";
            }
            if (ProviderRadioButton.Checked)
            {
                ChoosingTable = "Provider";
            }
            if (ShipmentProviderRadioButton.Checked)
            {
                ChoosingTable = "ProviderShipment";
            }
            if (PurchaseHistoryRadioButton.Checked)
            {
                ChoosingTable = "PurchaseHistory";
            }
            this.Visible = false;
            NextScreen.ShowDialog();
        }

        private void HalfWayScreen_VisibleChanged(object sender, EventArgs e)
        {
            switch (ChoosingRegime)
            {
                case "Create": HelpLabel.Text = "Выберите таблицу, в которую вы хотите добавить новое значение:";
                    break;
                default: break;
            }
        }

        private void HalfWayScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.StScreen.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
