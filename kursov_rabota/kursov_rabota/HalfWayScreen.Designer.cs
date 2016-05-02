﻿namespace kursov_rabota
{
    partial class HalfWayScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseButton = new System.Windows.Forms.Button();
            this.ShipmentRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientRadioButton = new System.Windows.Forms.RadioButton();
            this.ProviderRadioButton = new System.Windows.Forms.RadioButton();
            this.ShipmentProviderRadioButton = new System.Windows.Forms.RadioButton();
            this.PurchaseHistoryRadioButton = new System.Windows.Forms.RadioButton();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(150, 227);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 0;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // ShipmentRadioButton
            // 
            this.ShipmentRadioButton.AutoSize = true;
            this.ShipmentRadioButton.Location = new System.Drawing.Point(12, 31);
            this.ShipmentRadioButton.Name = "ShipmentRadioButton";
            this.ShipmentRadioButton.Size = new System.Drawing.Size(56, 17);
            this.ShipmentRadioButton.TabIndex = 1;
            this.ShipmentRadioButton.TabStop = true;
            this.ShipmentRadioButton.Text = "Товар";
            this.ShipmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClientRadioButton
            // 
            this.ClientRadioButton.AutoSize = true;
            this.ClientRadioButton.Location = new System.Drawing.Point(12, 54);
            this.ClientRadioButton.Name = "ClientRadioButton";
            this.ClientRadioButton.Size = new System.Drawing.Size(61, 17);
            this.ClientRadioButton.TabIndex = 2;
            this.ClientRadioButton.TabStop = true;
            this.ClientRadioButton.Text = "Клиент";
            this.ClientRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProviderRadioButton
            // 
            this.ProviderRadioButton.AutoSize = true;
            this.ProviderRadioButton.Location = new System.Drawing.Point(12, 77);
            this.ProviderRadioButton.Name = "ProviderRadioButton";
            this.ProviderRadioButton.Size = new System.Drawing.Size(83, 17);
            this.ProviderRadioButton.TabIndex = 3;
            this.ProviderRadioButton.TabStop = true;
            this.ProviderRadioButton.Text = "Поставщик";
            this.ProviderRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShipmentProviderRadioButton
            // 
            this.ShipmentProviderRadioButton.AutoSize = true;
            this.ShipmentProviderRadioButton.Location = new System.Drawing.Point(12, 100);
            this.ShipmentProviderRadioButton.Name = "ShipmentProviderRadioButton";
            this.ShipmentProviderRadioButton.Size = new System.Drawing.Size(117, 17);
            this.ShipmentProviderRadioButton.TabIndex = 4;
            this.ShipmentProviderRadioButton.TabStop = true;
            this.ShipmentProviderRadioButton.Text = "Товар-Поставщик";
            this.ShipmentProviderRadioButton.UseVisualStyleBackColor = true;
            // 
            // PurchaseHistoryRadioButton
            // 
            this.PurchaseHistoryRadioButton.AutoSize = true;
            this.PurchaseHistoryRadioButton.Location = new System.Drawing.Point(12, 123);
            this.PurchaseHistoryRadioButton.Name = "PurchaseHistoryRadioButton";
            this.PurchaseHistoryRadioButton.Size = new System.Drawing.Size(112, 17);
            this.PurchaseHistoryRadioButton.TabIndex = 5;
            this.PurchaseHistoryRadioButton.TabStop = true;
            this.PurchaseHistoryRadioButton.Text = "История покупок";
            this.PurchaseHistoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(12, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(346, 13);
            this.HelpLabel.TabIndex = 6;
            this.HelpLabel.Text = "Выберите таблицу, в которую вы хотите добавить новое значение:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 227);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HalfWayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.PurchaseHistoryRadioButton);
            this.Controls.Add(this.ShipmentProviderRadioButton);
            this.Controls.Add(this.ProviderRadioButton);
            this.Controls.Add(this.ClientRadioButton);
            this.Controls.Add(this.ShipmentRadioButton);
            this.Controls.Add(this.ChooseButton);
            this.Name = "HalfWayScreen";
            this.ShowInTaskbar = false;
            this.Text = "Выбор таблицы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HalfWayScreen_FormClosing);
            this.Load += new System.EventHandler(this.CreateScreen_Load);
            this.VisibleChanged += new System.EventHandler(this.HalfWayScreen_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.RadioButton ShipmentRadioButton;
        private System.Windows.Forms.RadioButton ClientRadioButton;
        private System.Windows.Forms.RadioButton ProviderRadioButton;
        private System.Windows.Forms.RadioButton ShipmentProviderRadioButton;
        private System.Windows.Forms.RadioButton PurchaseHistoryRadioButton;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button BackButton;
    }
}