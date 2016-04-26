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
            Form NextScreen = new Form();
            switch (ChoosingRegime)
            {
                case "Create": NextScreen = new CreateScreen(); 
                    break;
                default: break;
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
    }
}
