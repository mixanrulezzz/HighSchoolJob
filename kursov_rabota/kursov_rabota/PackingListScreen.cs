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
using PurchaseHistoryLibrary;
using PDFWork;

namespace kursov_rabota
{
    public partial class PackingListScreen : Form
    {
        private bool PackingList;
        private List<int> PurchaseHistoryInElements;
        private List<int> AddingPurchaseHistory;

        public PackingListScreen()
        {
            InitializeComponent();
        }

        public PackingListScreen(bool PackingList)
        {
            InitializeComponent();
            this.PackingList = PackingList;
            PurchaseHistoryInElements = new List<int>();
            AddingPurchaseHistory = new List<int>();
        }

        private void PackingListScreen_Load(object sender, EventArgs e)
        {
            AddButton.Visible = false;
            CreateButton.Visible = false;
            ChooseButton.Visible = true;
            HelpLabel.Text = "На какого клиента вы хотите выписать ";
            if (PackingList)
                HelpLabel.Text += "товарную накладную:";
            else
                HelpLabel.Text += "чек:";
            RefreshElements();
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
            CreateButton.Visible = true;
            HelpLabel.Text = "Выберите покупки:";
            int SelectedClient = Elements.SelectedIndex;
            Elements.Items.Clear();
            for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
            {
                if (Program.StScreen.PurchaseHistoryL[i].Count >= 5 && Program.StScreen.PurchaseHistoryL[i].ClientID == Program.StScreen.Clients[SelectedClient].ClientID)
                {
                    Elements.Items.Add(Program.StScreen.PurchaseHistoryL[i]);
                    PurchaseHistoryInElements.Add(i);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddingPurchaseHistory.Count == 0)
            {
                AddingPurchaseHistory.Add(PurchaseHistoryInElements[Elements.SelectedIndex]);
                return;
            }
            foreach (int i in AddingPurchaseHistory)
            {
                if (i == PurchaseHistoryInElements[Elements.SelectedIndex])
                {
                    MessageBox.Show("Вы уже выбирали данную покупку");
                    return;
                }
            }
            if (Program.StScreen.PurchaseHistoryL[AddingPurchaseHistory[AddingPurchaseHistory.Count - 1]].Day == Program.StScreen.PurchaseHistoryL[PurchaseHistoryInElements[Elements.SelectedIndex]].Day && Program.StScreen.PurchaseHistoryL[AddingPurchaseHistory[AddingPurchaseHistory.Count - 1]].Month == Program.StScreen.PurchaseHistoryL[PurchaseHistoryInElements[Elements.SelectedIndex]].Month && Program.StScreen.PurchaseHistoryL[AddingPurchaseHistory[AddingPurchaseHistory.Count - 1]].Year == Program.StScreen.PurchaseHistoryL[PurchaseHistoryInElements[Elements.SelectedIndex]].Year)
            {
                AddingPurchaseHistory.Add(PurchaseHistoryInElements[Elements.SelectedIndex]);
                return;
            }
            else
            {
                MessageBox.Show("Все оптовые покупки должны быть сделаны в один день");
                return;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (AddingPurchaseHistory.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну покупку!!!");
                return;
            }
            SFD.Title = "Сохранить товарную нокладную";
            SFD.Filter = "PDF файл|*.pdf";
            SFD.FileName = "Товарная накладная";
            SFD.ShowDialog();
        }

        private void SFD_FileOk(object sender, CancelEventArgs e)
        {
            string file = SFD.FileName;
            List<int> Counts = new List<int>();
            List<int> Prices = new List<int>();
            List<string> Names = new List<string>();
            foreach(int i in AddingPurchaseHistory)
            {
                Counts.Add(Program.StScreen.PurchaseHistoryL[i].Count);
                foreach (Shipment s in Program.StScreen.Shipments.Shipments)
                {
                    if (s.ShipmentID == Program.StScreen.PurchaseHistoryL[i].ShipmentID)
                    {
                        Prices.Add(s.Price);
                        Names.Add(s.ShipmentName);
                    }
                }
            }            
            PDF.CreatePackingList(file, Counts, Prices, Names);
            MessageBox.Show("Товарная накладная создана успешно");
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
