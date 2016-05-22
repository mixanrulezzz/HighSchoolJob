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
    public partial class PackingListScreen : Form
    {
        private bool PackingList;
        private Tables NowTable;

        public PackingListScreen()
        {
            InitializeComponent();
        }

        public PackingListScreen(bool PackingList)
        {
            InitializeComponent();
            this.PackingList = PackingList;
        }

        private void PackingListScreen_Load(object sender, EventArgs e)
        {
            AddButton.Visible = false;
            ChooseButton.Visible = true;
            HelpLabel.Text = "На какого клиента вы хотите выписать ";
            if (PackingList)
                HelpLabel.Text += "товарную накладную:";
            else
                HelpLabel.Text += "чек:";
            RefreshElements();
            NowTable = Tables.Client;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (Elements.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите клиента!!!");
                return;
            }
            bool flag = false;
            for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
            {
                if (Program.StScreen.PurchaseHistoryL[i].ClientID == Program.StScreen.Clients[Elements.SelectedIndex].ClientID && Program.StScreen.PurchaseHistoryL[i].Count >= 5)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Данный клиент не совершал оптовых закупок!!! Выберите другого");
                return;
            }
            ChooseButton.Visible = false;
            AddButton.Visible = true;
            HelpLabel.Text = "Выберите покупки:";
            int SelectedClient = Elements.SelectedIndex;
            Elements.Items.Clear();
            for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
            {
                if(Program.StScreen.PurchaseHistoryL[i].Count >= 5 && Program.StScreen.PurchaseHistoryL[i].ClientID == Program.StScreen.Clients[SelectedClient].ClientID)
                    Elements.Items.Add(Program.StScreen.PurchaseHistoryL[i]);
            }
        }

        private void RefreshElements()
        {
            Elements.Items.Clear();
            for (int i = 0; i < Program.StScreen.Clients.Count; i++)
            {
                Elements.Items.Add(Program.StScreen.Clients[i]);
            }
        }
    }
}
