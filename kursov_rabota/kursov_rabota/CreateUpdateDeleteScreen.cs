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


    public partial class CreateUpdateDeleteScreen : Form
    {
        private int SelectedTextBox = 0;
        public Regimes ChoosingRegime;
        public Tables ChoosingTable;

        public CreateUpdateDeleteScreen()
        {
            InitializeComponent();
        }

        public CreateUpdateDeleteScreen(Regimes ChoosingRegime, Tables ChoosingTable)
        {
            InitializeComponent();
            this.ChoosingRegime = ChoosingRegime;
            this.ChoosingTable = ChoosingTable;
        }

        private void CreateScreen_Load(object sender, EventArgs e)
        {
            PurchaseHistoryDate.Value = DateTime.Now;
            PurchaseHistoryDate.MaxDate = DateTime.Now;
            HideAll();
            switch (ChoosingRegime)
            {
                case Regimes.Create: CreateLoad();
                    break;
                case Regimes.Update: UpdateLoad();
                    break;
                case Regimes.Delete: DeleteLoad();
                    break;
            }
        }

        private void CreateScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.StScreen.Visible = true;
        }

        private void MultifunctionalButton_Click(object sender, EventArgs e)
        {
            switch (
                ChoosingRegime)
            {
                case Regimes.Create: CreateClick();
                    break;
                case Regimes.Update: UpdateClick();
                    break;
                case Regimes.Delete: DeleteClick();
                    break;
                default: break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ChoosingTable == Tables.Shipment)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ChoosingTable == Tables.PurchaseHistory)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDTextBox_Click(object sender, EventArgs e)
        {            
            switch (ChoosingTable)
            {
                case Tables.ProviderShipment: SelectedTextBox = 1;
                    RefreshSecondListBox(Tables.Provider);
                    break;
                default: break;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {            
            switch (ChoosingTable)
            {
                case Tables.ProviderShipment: SelectedTextBox = 2;
                    RefreshSecondListBox(Tables.Shipment);
                    break;
                case Tables.PurchaseHistory: SelectedTextBox = 2;
                    RefreshSecondListBox(Tables.Shipment);
                    break;
                default: break;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            switch (ChoosingTable)
            {
                case Tables.PurchaseHistory: SelectedTextBox = 3;
                    RefreshSecondListBox(Tables.Client);
                    break;
                default: break;
            }
        }

        private void FirstListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstListBox.SelectedIndex != -1)
            {
                switch (ChoosingTable)
                {
                    case Tables.Shipment:
                        IDTextBox.Text = Program.StScreen.Shipments[FirstListBox.SelectedIndex].ShipmentID.ToString();
                        textBox1.Text = Program.StScreen.Shipments[FirstListBox.SelectedIndex].ShipmentName;
                        textBox2.Text = Program.StScreen.Shipments[FirstListBox.SelectedIndex].Price.ToString();
                        textBox3.Text = Program.StScreen.Shipments[FirstListBox.SelectedIndex].PhotoLink;
                        break;
                    case Tables.Client:
                        IDTextBox.Text = Program.StScreen.Clients[FirstListBox.SelectedIndex].ClientID.ToString();
                        textBox1.Text = Program.StScreen.Clients[FirstListBox.SelectedIndex].ClientFirstName;
                        textBox2.Text = Program.StScreen.Clients[FirstListBox.SelectedIndex].ClientLastName;
                        break;
                    case Tables.Provider:
                        IDTextBox.Text = Program.StScreen.Providers[FirstListBox.SelectedIndex].ProviderID.ToString();
                        textBox1.Text = Program.StScreen.Providers[FirstListBox.SelectedIndex].ProviderName;
                        break;
                    case Tables.ProviderShipment:
                        IDTextBox.Text = Program.StScreen.ProvidersShipments[FirstListBox.SelectedIndex].ProviderID.ToString();
                        textBox1.Text = Program.StScreen.ProvidersShipments[FirstListBox.SelectedIndex].ShipmentID.ToString();
                        break;
                    case Tables.PurchaseHistory:
                        IDTextBox.Text = Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].PurchaseHistoryID.ToString();
                        textBox1.Text = Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].ShipmentID.ToString();
                        textBox2.Text = Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].ClientID.ToString();
                        textBox3.Text = Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].Count.ToString();
                        DateTime date = new DateTime(Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].Year, Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].Month, Program.StScreen.PurchaseHistoryL[FirstListBox.SelectedIndex].Day);
                        PurchaseHistoryDate.Value = date;
                        break;
                    default: break;
                }
            }
        }

        private void SecondListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SecondListBox.SelectedItem != null)
            {
                string[] str = SecondListBox.SelectedItem.ToString().Split(' ');
                switch (SelectedTextBox)
                {
                    case 1:
                        IDTextBox.Text = str[0];
                        break;
                    case 2:
                        textBox1.Text = str[0];
                        break;
                    case 3:
                        textBox2.Text = str[0];
                        break;
                    default: break;
                }
            }
        }

        private void RefreshFirstListBox()
        {
            FirstListBox.Items.Clear();
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    for (int i = 0; i < Program.StScreen.Shipments.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Shipments[i]);
                    }
                    break;
                case Tables.Client:
                    for (int i = 0; i < Program.StScreen.Clients.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Clients[i]);
                    }
                    break;
                case Tables.Provider:
                    for (int i = 0; i < Program.StScreen.Providers.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.Providers[i]);
                    }
                    break;
                case Tables.ProviderShipment:
                    for (int i = 0; i < Program.StScreen.ProvidersShipments.Count; i++)
                    {
                        string str = "";
                        for (int j = 0; j < Program.StScreen.Providers.Count; j++)
                        {
                            if (Program.StScreen.Providers[j].ProviderID == Program.StScreen.ProvidersShipments[i].ProviderID)
                            {
                                str += Program.StScreen.Providers[j].ProviderName;
                                break;
                            }
                        }
                        str += "-";
                        for (int j = 0; j < Program.StScreen.Shipments.Count; j++)
                        {
                            if (Program.StScreen.Shipments[j].ShipmentID == Program.StScreen.ProvidersShipments[i].ShipmentID)
                            {
                                str += Program.StScreen.Shipments[j].ShipmentName;
                                break;
                            }
                        }
                        FirstListBox.Items.Add(str);
                    }
                    break;
                case Tables.PurchaseHistory:
                    for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
                    {
                        FirstListBox.Items.Add(Program.StScreen.PurchaseHistoryL[i]);
                    }
                    break;
                default: break;
            }
        }

        private void RefreshSecondListBox(Tables ChoosingTable)
        {
            SecondListBox.Items.Clear();
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    SecondListBoxLabel.Text = "Список товаров:";
                    for (int i = 0; i < Program.StScreen.Shipments.Count; i++)
                    {
                        SecondListBox.Items.Add(Program.StScreen.Shipments[i]);
                    }
                    break;
                case Tables.Client:
                    SecondListBoxLabel.Text = "Список клиентов:";
                    for (int i = 0; i < Program.StScreen.Clients.Count; i++)
                    {
                        SecondListBox.Items.Add(Program.StScreen.Clients[i]);
                    }
                    break;
                case Tables.Provider:
                    SecondListBoxLabel.Text = "Список поставщиков:";
                    for (int i = 0; i < Program.StScreen.Providers.Count; i++)
                    {
                        SecondListBox.Items.Add(Program.StScreen.Providers[i]);
                    }
                    break;
                default:
                    SecondListBoxLabel.Text = "";
                    break;
            }
        }

        private void HideAll()
        {
            FirstListBox.Visible = false;
            FirstListBox.SelectionMode = SelectionMode.One;
            SecondListBox.Visible = false;
            SecondListBox.SelectionMode = SelectionMode.One;
            FirstListBoxLabel.Visible = false;
            SecondListBoxLabel.Visible = false;
            MultifunctionalButton.Visible = false;
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
            MultifunctionalButton.Visible = true;
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
            MultifunctionalButton.Visible = true;
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
            MultifunctionalButton.Visible = true;
        }

        private void ProviderShipmentVisible()
        {
            FirstListBox.Visible = true;
            FirstListBoxLabel.Visible = true;
            FirstListBoxLabel.Text = "Список товар-поставщик:";
            SecondListBox.Visible = true;
            SecondListBoxLabel.Visible = true;
            SecondListBoxLabel.Text = "";
            IDLabel.Visible = true;
            IDLabel.Text = "ID поставщика";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "ID товара";
            textBox1.Visible = true;
            textBox1.ReadOnly = true;
            MultifunctionalButton.Visible = true;
        }

        private void PurchaseHistoryVisible()
        {
            FirstListBox.Visible = true;
            FirstListBoxLabel.Visible = true;
            FirstListBoxLabel.Text = "История покупок:";
            SecondListBox.Visible = true;
            SecondListBoxLabel.Visible = true;
            SecondListBoxLabel.Text = "";
            IDLabel.Visible = true;
            IDLabel.Text = "ID покупки";
            IDTextBox.Visible = true;
            label2.Visible = true;
            label2.Text = "ID товара";
            textBox1.Visible = true;
            textBox1.ReadOnly = true;
            label3.Visible = true;
            label3.Text = "ID клиента";
            textBox2.Visible = true;
            textBox2.ReadOnly = true;
            label4.Visible = true;
            label4.Text = "Количество купленного товара";
            textBox3.Visible = true;
            label5.Visible = true;
            label5.Text = "Дата покупки";
            PurchaseHistoryDate.Visible = true;
            MultifunctionalButton.Visible = true;
        }

        private void CreateLoad()
        {
            MultifunctionalButton.Text = "Создать";
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    ShipmentVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case Tables.Client:
                    ClientVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case Tables.Provider:
                    ProviderVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    RefreshFirstListBox();
                    break;
                case Tables.ProviderShipment:
                    ProviderShipmentVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    SecondListBox.SelectionMode = SelectionMode.One;
                    IDTextBox.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    textBox1.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    RefreshFirstListBox();
                    break;
                case Tables.PurchaseHistory:
                    PurchaseHistoryVisible();
                    FirstListBox.SelectionMode = SelectionMode.None;
                    SecondListBox.SelectionMode = SelectionMode.One;
                    IDTextBox.Text = "(Будет проставлен автоматически!)";
                    textBox1.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    textBox2.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    RefreshFirstListBox();
                    break;
                default: break;
            }
        }

        private void UpdateLoad()
        {
            MultifunctionalButton.Text = "Обновить";
            switch (ChoosingTable)
            {
                case Tables.Shipment: ShipmentVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.Client: ClientVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.Provider: ProviderVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.ProviderShipment: ProviderShipmentVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.PurchaseHistory: PurchaseHistoryVisible();
                    RefreshFirstListBox();
                    break;
                default: break;
            }
        }

        private void DeleteLoad()
        {
            MultifunctionalButton.Text = "Удалить";
            switch (ChoosingTable)
            {
                case Tables.Shipment: ShipmentVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.Client: ClientVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.Provider: ProviderVisible();
                    RefreshFirstListBox();
                    break;
                case Tables.ProviderShipment: ProviderShipmentVisible();
                    SecondListBox.SelectionMode = SelectionMode.None;
                    RefreshFirstListBox();
                    break;
                case Tables.PurchaseHistory: PurchaseHistoryVisible();
                    SecondListBox.SelectionMode = SelectionMode.None;
                    RefreshFirstListBox();
                    break;
                default: break;
            }
        }

        private void CreateClick()
        {
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
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
                case Tables.Client:
                    if (textBox1.Text == "" || textBox2.Text == "")
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
                case Tables.Provider:
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    Program.StScreen.MaxProviderID++;
                    Program.StScreen.Providers.Add(Program.StScreen.MaxProviderID, textBox1.Text);
                    RefreshFirstListBox();
                    textBox1.Text = "";
                    break;
                case Tables.ProviderShipment:
                    if (IDTextBox.Text[0] < '0' || IDTextBox.Text[0] > '9' || textBox1.Text[0] < '0' || textBox1.Text[0] > '9')
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    if (Program.StScreen.ProvidersShipments.Add(Convert.ToInt32(IDTextBox.Text), Convert.ToInt32(textBox1.Text)) == 2)
                    {
                        MessageBox.Show("Данный элемент уже существует!!!");
                        return;
                    }
                    RefreshFirstListBox();
                    RefreshSecondListBox(Tables.None);
                    IDTextBox.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    textBox1.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    break;
                case Tables.PurchaseHistory:
                    if (textBox1.Text[0] < '0' || textBox1.Text[0] > '9' || textBox2.Text[0] < '0' || textBox2.Text[0] > '9' || textBox3.Text == "")
                    {
                        MessageBox.Show("Все поля обязательны к заполнению!!!");
                        return;
                    }
                    Program.StScreen.MaxPurchaseHistoryID++;
                    Program.StScreen.PurchaseHistoryL.Add(Program.StScreen.MaxPurchaseHistoryID, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), PurchaseHistoryDate.Value.Day, PurchaseHistoryDate.Value.Month, PurchaseHistoryDate.Value.Year);
                    RefreshFirstListBox();
                    RefreshSecondListBox(Tables.None);
                    textBox1.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    textBox2.Text = "(Щелкните мышкой и выберите элемент в списке слева!)";
                    textBox3.Text = "";
                    PurchaseHistoryDate.Value = PurchaseHistoryDate.MaxDate;
                    break;
                default: break;
            }
        }

        private void UpdateClick()
        {
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    if (FirstListBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Для изменения элемента его сначала нужно выбрать");
                        return;
                    }
                    Program.StScreen.Shipments.UpdateAt(new Shipment(Convert.ToInt32(IDTextBox.Text), textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text), FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    break;
                case Tables.Client:
                    if (FirstListBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Для изменения элемента его сначала нужно выбрать");
                        return;
                    }
                    Program.StScreen.Clients.UpdateAt(new Client(Convert.ToInt32(IDTextBox.Text), textBox1.Text, textBox2.Text), FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    break;
                case Tables.Provider:
                    if (FirstListBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Для изменения элемента его сначала нужно выбрать");
                        return;
                    }
                    Program.StScreen.Providers.UpdateAt(new Provider(Convert.ToInt32(IDTextBox.Text), textBox1.Text), FirstListBox.SelectedIndex);
                    RefreshFirstListBox(); 
                    break;
                case Tables.ProviderShipment:
                    if (FirstListBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Для изменения элемента его сначала нужно выбрать");
                        return;
                    }
                    if (!Program.StScreen.ProvidersShipments.UpdateAt(new ProviderShipment(Convert.ToInt32(IDTextBox.Text), Convert.ToInt32(textBox1.Text)), FirstListBox.SelectedIndex))
                    {
                        MessageBox.Show("Такой элемент уже существует!!!");
                        return;
                    }
                    RefreshFirstListBox();
                    RefreshSecondListBox(Tables.None);
                    break;
                case Tables.PurchaseHistory:
                    if (FirstListBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Для изменения элемента его сначала нужно выбрать");
                        return;
                    }
                    Program.StScreen.PurchaseHistoryL.UpdateAt(new PurchaseHistory(Convert.ToInt32(IDTextBox.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), PurchaseHistoryDate.Value.Day, PurchaseHistoryDate.Value.Month, PurchaseHistoryDate.Value.Year), FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    RefreshSecondListBox(Tables.None);
                    break;
                default: break;
            }
        }

        private void DeleteClick()
        {
            switch (ChoosingTable)
            {
                case Tables.Shipment:
                    for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
                    {
                        if (Program.StScreen.Shipments[FirstListBox.SelectedIndex].ShipmentID == Program.StScreen.PurchaseHistoryL[i].ShipmentID)
                        {
                            MessageBox.Show("Данный товар используется в таблице 'История покупок'");
                            return;
                        }
                    }
                    for (int i = 0; i < Program.StScreen.ProvidersShipments.Count; i++)
                    {
                        if (Program.StScreen.Shipments[FirstListBox.SelectedIndex].ShipmentID == Program.StScreen.ProvidersShipments[i].ShipmentID)
                        {
                            MessageBox.Show("Данный товар используется в таблице 'Поставщик-Товар'");
                            return;
                        }
                    }
                    Program.StScreen.Shipments.RemoveAt(FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    IDTextBox.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    break;
                case Tables.Client: for (int i = 0; i < Program.StScreen.PurchaseHistoryL.Count; i++)
                    {
                        if (Program.StScreen.Clients[FirstListBox.SelectedIndex].ClientID == Program.StScreen.PurchaseHistoryL[i].ClientID)
                        {
                            MessageBox.Show("Данный клиент используется в таблице 'История покупок'");
                            return;
                        }
                    }
                    Program.StScreen.Clients.RemoveAt(FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    IDTextBox.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    break;
                case Tables.Provider: for (int i = 0; i < Program.StScreen.ProvidersShipments.Count; i++)
                    {
                        if (Program.StScreen.Providers[FirstListBox.SelectedIndex].ProviderID == Program.StScreen.ProvidersShipments[i].ProviderID)
                        {
                            MessageBox.Show("Данный поставщик используется в таблице 'Поставщик-Товар'");
                            return;
                        }
                    }
                    Program.StScreen.Providers.RemoveAt(FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    IDTextBox.Text = "";
                    textBox1.Text = "";
                    break;
                case Tables.ProviderShipment: Program.StScreen.ProvidersShipments.RemoveAt(FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    IDTextBox.Text = "";
                    textBox1.Text = "";
                    break;
                case Tables.PurchaseHistory: Program.StScreen.PurchaseHistoryL.RemoveAt(FirstListBox.SelectedIndex);
                    RefreshFirstListBox();
                    IDTextBox.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    PurchaseHistoryDate.Value = PurchaseHistoryDate.MaxDate;
                    break;
                default: break;
            }
        }
    }
}