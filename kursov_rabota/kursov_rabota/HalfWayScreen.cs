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
        public string helpLabelText = "";
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

        }

        private void HalfWayScreen_VisibleChanged(object sender, EventArgs e)
        {
            HelpLabel.Text = helpLabelText;
        }
    }
}
