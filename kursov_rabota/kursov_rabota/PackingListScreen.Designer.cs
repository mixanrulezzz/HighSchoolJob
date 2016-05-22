namespace kursov_rabota
{
    partial class PackingListScreen
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
            this.Elements = new System.Windows.Forms.ListBox();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Elements
            // 
            this.Elements.FormattingEnabled = true;
            this.Elements.Location = new System.Drawing.Point(12, 25);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(323, 225);
            this.Elements.TabIndex = 0;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(12, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(35, 13);
            this.HelpLabel.TabIndex = 1;
            this.HelpLabel.Text = "label1";
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(12, 259);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(93, 259);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // PackingListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 294);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.Elements);
            this.Name = "PackingListScreen";
            this.Text = "PackingListScreen";
            this.Load += new System.EventHandler(this.PackingListScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Elements;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button AddButton;
    }
}