namespace Netch.Forms
{
    partial class GlobalBypassIPForm
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
            this.IPGroupBox = new System.Windows.Forms.GroupBox();
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.IPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPGroupBox
            // 
            this.IPGroupBox.Controls.Add(this.IPListBox);
            this.IPGroupBox.Controls.Add(this.IPTextBox);
            this.IPGroupBox.Controls.Add(this.PrefixComboBox);
            this.IPGroupBox.Controls.Add(this.AddButton);
            this.IPGroupBox.Controls.Add(this.DeleteButton);
            this.IPGroupBox.Location = new System.Drawing.Point(12, 12);
            this.IPGroupBox.Name = "IPGroupBox";
            this.IPGroupBox.Size = new System.Drawing.Size(497, 469);
            this.IPGroupBox.TabIndex = 0;
            this.IPGroupBox.TabStop = false;
            this.IPGroupBox.Text = "IPs";
            // 
            // IPListBox
            // 
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.ItemHeight = 24;
            this.IPListBox.Location = new System.Drawing.Point(6, 30);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(485, 316);
            this.IPListBox.TabIndex = 0;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(6, 376);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(410, 31);
            this.IPTextBox.TabIndex = 1;
            // 
            // PrefixComboBox
            // 
            this.PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefixComboBox.FormattingEnabled = true;
            this.PrefixComboBox.IntegralHeight = false;
            this.PrefixComboBox.Location = new System.Drawing.Point(422, 376);
            this.PrefixComboBox.MaxDropDownItems = 4;
            this.PrefixComboBox.Name = "PrefixComboBox";
            this.PrefixComboBox.Size = new System.Drawing.Size(69, 32);
            this.PrefixComboBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(325, 413);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 40);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Location = new System.Drawing.Point(411, 414);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 40);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.Location = new System.Drawing.Point(429, 487);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(80, 40);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // GlobalBypassIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(521, 539);
            this.Controls.Add(this.IPGroupBox);
            this.Controls.Add(this.ControlButton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GlobalBypassIPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Bypass IPs";
            this.Load += new System.EventHandler(this.GlobalBypassIPForm_Load);
            this.IPGroupBox.ResumeLayout(false);
            this.IPGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IPGroupBox;
        private System.Windows.Forms.ListBox IPListBox;
        private System.Windows.Forms.ComboBox PrefixComboBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ControlButton;
    }
}