namespace kursov_rabota
{
    partial class CreateScreen
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
            this.ByingHistoryRadioButton = new System.Windows.Forms.RadioButton();
            this.HelpLabel = new System.Windows.Forms.Label();
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
            // ByingHistoryRadioButton
            // 
            this.ByingHistoryRadioButton.AutoSize = true;
            this.ByingHistoryRadioButton.Location = new System.Drawing.Point(12, 123);
            this.ByingHistoryRadioButton.Name = "ByingHistoryRadioButton";
            this.ByingHistoryRadioButton.Size = new System.Drawing.Size(112, 17);
            this.ByingHistoryRadioButton.TabIndex = 5;
            this.ByingHistoryRadioButton.TabStop = true;
            this.ByingHistoryRadioButton.Text = "История покупок";
            this.ByingHistoryRadioButton.UseVisualStyleBackColor = true;
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
            // CreateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.ByingHistoryRadioButton);
            this.Controls.Add(this.ShipmentProviderRadioButton);
            this.Controls.Add(this.ProviderRadioButton);
            this.Controls.Add(this.ClientRadioButton);
            this.Controls.Add(this.ShipmentRadioButton);
            this.Controls.Add(this.ChooseButton);
            this.Name = "CreateScreen";
            this.ShowInTaskbar = false;
            this.Text = "CreateScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.RadioButton ShipmentRadioButton;
        private System.Windows.Forms.RadioButton ClientRadioButton;
        private System.Windows.Forms.RadioButton ProviderRadioButton;
        private System.Windows.Forms.RadioButton ShipmentProviderRadioButton;
        private System.Windows.Forms.RadioButton ByingHistoryRadioButton;
        private System.Windows.Forms.Label HelpLabel;
    }
}