using GreenMonkey.Manager;
using GreenMonkey.Models;
using System.Collections.Generic;

namespace GreenMonkey.Desktop
{
    partial class Form1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.customerIdTextField = new MetroFramework.Controls.MetroTextBox();
            this.customernameTextField = new MetroFramework.Controls.MetroTextBox();
            this.customerLastnameTextField = new MetroFramework.Controls.MetroTextBox();
            this.customerAgeTextField = new MetroFramework.Controls.MetroTextBox();
            this.searchCustomer = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coins = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(503, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 32);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer info";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Id";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(241, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(461, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Lastname";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(699, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Age";
            // 
            // customerIdTextField
            // 
            this.customerIdTextField.BackColor = System.Drawing.Color.White;
            this.customerIdTextField.Location = new System.Drawing.Point(54, 82);
            this.customerIdTextField.Name = "customerIdTextField";
            this.customerIdTextField.Size = new System.Drawing.Size(127, 23);
            this.customerIdTextField.Style = MetroFramework.MetroColorStyle.White;
            this.customerIdTextField.TabIndex = 5;
            this.customerIdTextField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerIdTextField.UseStyleColors = true;
            // 
            // customernameTextField
            // 
            this.customernameTextField.Location = new System.Drawing.Point(292, 82);
            this.customernameTextField.Name = "customernameTextField";
            this.customernameTextField.Size = new System.Drawing.Size(126, 23);
            this.customernameTextField.Style = MetroFramework.MetroColorStyle.White;
            this.customernameTextField.TabIndex = 6;
            this.customernameTextField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customernameTextField.UseStyleColors = true;
            // 
            // customerLastnameTextField
            // 
            this.customerLastnameTextField.Location = new System.Drawing.Point(531, 82);
            this.customerLastnameTextField.Name = "customerLastnameTextField";
            this.customerLastnameTextField.Size = new System.Drawing.Size(134, 23);
            this.customerLastnameTextField.Style = MetroFramework.MetroColorStyle.White;
            this.customerLastnameTextField.TabIndex = 7;
            this.customerLastnameTextField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerLastnameTextField.UseStyleColors = true;
            // 
            // customerAgeTextField
            // 
            this.customerAgeTextField.Location = new System.Drawing.Point(738, 82);
            this.customerAgeTextField.Name = "customerAgeTextField";
            this.customerAgeTextField.Size = new System.Drawing.Size(134, 23);
            this.customerAgeTextField.Style = MetroFramework.MetroColorStyle.White;
            this.customerAgeTextField.TabIndex = 8;
            this.customerAgeTextField.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerAgeTextField.UseStyleColors = true;
            // 
            // searchCustomer
            // 
            this.searchCustomer.Location = new System.Drawing.Point(955, 82);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(75, 23);
            this.searchCustomer.Style = MetroFramework.MetroColorStyle.Black;
            this.searchCustomer.TabIndex = 9;
            this.searchCustomer.Text = "Buscar";
            this.searchCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchCustomer.Click += new System.EventHandler(this.SearchCustomer);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.Coins);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(28, 147);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1002, 541);
            this.metroTabControl1.TabIndex = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroTextBox7);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroTextBox6);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroTextBox5);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.customerDataGrid);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(994, 502);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Accounts";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(239, 336);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton4.TabIndex = 11;
            this.metroButton4.Text = "Delete";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(134, 336);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Update";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(22, 336);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Save";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.Location = new System.Drawing.Point(597, 255);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(205, 23);
            this.metroTextBox7.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBox7.TabIndex = 8;
            this.metroTextBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(535, 255);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Amount";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(291, 255);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(202, 23);
            this.metroTextBox6.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBox6.TabIndex = 6;
            this.metroTextBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(239, 255);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Name";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(48, 255);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(161, 23);
            this.metroTextBox5.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBox5.TabIndex = 4;
            this.metroTextBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 255);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(20, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Id";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.customerDataGrid.Location = new System.Drawing.Point(0, 32);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(977, 150);
            this.customerDataGrid.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Coins
            // 
            this.Coins.HorizontalScrollbarBarColor = true;
            this.Coins.Location = new System.Drawing.Point(4, 35);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(994, 502);
            this.Coins.TabIndex = 1;
            this.Coins.Text = "Coins";
            this.Coins.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(994, 502);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Transfer";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 777);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.searchCustomer);
            this.Controls.Add(this.customerAgeTextField);
            this.Controls.Add(this.customerLastnameTextField);
            this.Controls.Add(this.customernameTextField);
            this.Controls.Add(this.customerIdTextField);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox customerIdTextField;
        private MetroFramework.Controls.MetroTextBox customernameTextField;
        private MetroFramework.Controls.MetroTextBox customerLastnameTextField;
        private MetroFramework.Controls.MetroTextBox customerAgeTextField;
        private MetroFramework.Controls.MetroButton searchCustomer;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage Coins;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

