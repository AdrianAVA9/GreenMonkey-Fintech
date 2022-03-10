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
            MetroFramework.Controls.MetroTabControl contentTab;
            this.customerTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.editTFLastaname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.editTFCustomername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.editTFCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsTab = new MetroFramework.Controls.MetroTabPage();
            this.coinsTab = new MetroFramework.Controls.MetroTabPage();
            this.transferNowTab = new MetroFramework.Controls.MetroTabPage();
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
            this.editTFAge = new MetroFramework.Controls.MetroTextBox();
            this.accountsDataGrid = new System.Windows.Forms.DataGridView();
            this.coinsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contentTab = new MetroFramework.Controls.MetroTabControl();
            contentTab.SuspendLayout();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.accountsTab.SuspendLayout();
            this.coinsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTab
            // 
            contentTab.Controls.Add(this.customerTab);
            contentTab.Controls.Add(this.accountsTab);
            contentTab.Controls.Add(this.coinsTab);
            contentTab.Controls.Add(this.transferNowTab);
            contentTab.Location = new System.Drawing.Point(28, 147);
            contentTab.Name = "contentTab";
            contentTab.SelectedIndex = 2;
            contentTab.Size = new System.Drawing.Size(1002, 541);
            contentTab.TabIndex = 10;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.metroLabel9);
            this.customerTab.Controls.Add(this.metroButton4);
            this.customerTab.Controls.Add(this.metroButton3);
            this.customerTab.Controls.Add(this.metroButton2);
            this.customerTab.Controls.Add(this.editTFLastaname);
            this.customerTab.Controls.Add(this.metroLabel8);
            this.customerTab.Controls.Add(this.editTFCustomername);
            this.customerTab.Controls.Add(this.metroLabel7);
            this.customerTab.Controls.Add(this.editTFCustomerId);
            this.customerTab.Controls.Add(this.metroLabel6);
            this.customerTab.Controls.Add(this.customerDataGrid);
            this.customerTab.HorizontalScrollbarBarColor = true;
            this.customerTab.Location = new System.Drawing.Point(4, 35);
            this.customerTab.Name = "customerTab";
            this.customerTab.Size = new System.Drawing.Size(994, 502);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customers";
            this.customerTab.VerticalScrollbarBarColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(866, 255);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Age";
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
            // editTFLastaname
            // 
            this.editTFLastaname.Location = new System.Drawing.Point(597, 255);
            this.editTFLastaname.Name = "editTFLastaname";
            this.editTFLastaname.Size = new System.Drawing.Size(205, 23);
            this.editTFLastaname.Style = MetroFramework.MetroColorStyle.White;
            this.editTFLastaname.TabIndex = 8;
            this.editTFLastaname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFLastaname.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(535, 255);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Apellido";
            // 
            // editTFCustomername
            // 
            this.editTFCustomername.Location = new System.Drawing.Point(291, 255);
            this.editTFCustomername.Name = "editTFCustomername";
            this.editTFCustomername.Size = new System.Drawing.Size(202, 23);
            this.editTFCustomername.Style = MetroFramework.MetroColorStyle.White;
            this.editTFCustomername.TabIndex = 6;
            this.editTFCustomername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFCustomername.UseStyleColors = true;
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
            // editTFCustomerId
            // 
            this.editTFCustomerId.Location = new System.Drawing.Point(48, 255);
            this.editTFCustomerId.Name = "editTFCustomerId";
            this.editTFCustomerId.Size = new System.Drawing.Size(161, 23);
            this.editTFCustomerId.Style = MetroFramework.MetroColorStyle.White;
            this.editTFCustomerId.TabIndex = 4;
            this.editTFCustomerId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFCustomerId.UseStyleColors = true;
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
            this.Column3,
            this.Column4});
            this.customerDataGrid.Location = new System.Drawing.Point(0, 32);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(977, 150);
            this.customerDataGrid.TabIndex = 2;
            this.customerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCustomer);
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
            this.Column3.HeaderText = "Lastname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Age";
            this.Column4.Name = "Column4";
            // 
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsDataGrid);
            this.accountsTab.HorizontalScrollbarBarColor = true;
            this.accountsTab.Location = new System.Drawing.Point(4, 35);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Size = new System.Drawing.Size(994, 502);
            this.accountsTab.TabIndex = 2;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.VerticalScrollbarBarColor = true;
            // 
            // coinsTab
            // 
            this.coinsTab.Controls.Add(this.coinsDataGrid);
            this.coinsTab.HorizontalScrollbarBarColor = true;
            this.coinsTab.Location = new System.Drawing.Point(4, 35);
            this.coinsTab.Name = "coinsTab";
            this.coinsTab.Size = new System.Drawing.Size(994, 502);
            this.coinsTab.TabIndex = 1;
            this.coinsTab.Text = "Coins";
            this.coinsTab.VerticalScrollbarBarColor = true;
            // 
            // transferNowTab
            // 
            this.transferNowTab.HorizontalScrollbarBarColor = true;
            this.transferNowTab.Location = new System.Drawing.Point(4, 35);
            this.transferNowTab.Name = "transferNowTab";
            this.transferNowTab.Size = new System.Drawing.Size(994, 502);
            this.transferNowTab.TabIndex = 3;
            this.transferNowTab.Text = "Transfer now";
            this.transferNowTab.VerticalScrollbarBarColor = true;
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
            // editTFAge
            // 
            this.editTFAge.Location = new System.Drawing.Point(937, 437);
            this.editTFAge.Name = "editTFAge";
            this.editTFAge.Size = new System.Drawing.Size(205, 23);
            this.editTFAge.Style = MetroFramework.MetroColorStyle.White;
            this.editTFAge.TabIndex = 13;
            this.editTFAge.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFAge.UseStyleColors = true;
            // 
            // accountsDataGrid
            // 
            this.accountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column12,
            this.Column7,
            this.Column13});
            this.accountsDataGrid.Location = new System.Drawing.Point(54, 32);
            this.accountsDataGrid.Name = "accountsDataGrid";
            this.accountsDataGrid.Size = new System.Drawing.Size(560, 150);
            this.accountsDataGrid.TabIndex = 2;
            // 
            // coinsDataGrid
            // 
            this.coinsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coinsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column8});
            this.coinsDataGrid.Location = new System.Drawing.Point(80, 60);
            this.coinsDataGrid.Name = "coinsDataGrid";
            this.coinsDataGrid.Size = new System.Drawing.Size(471, 150);
            this.coinsDataGrid.TabIndex = 2;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Customer Id";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Account Number";
            this.Column6.Name = "Column6";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Amount";
            this.Column12.Name = "Column12";
            this.Column12.ToolTipText = "Status";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Status";
            this.Column13.Name = "Column13";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fintech code";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fintech";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Code";
            this.Column11.Name = "Column11";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 777);
            this.Controls.Add(this.editTFAge);
            this.Controls.Add(contentTab);
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
            contentTab.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.accountsTab.ResumeLayout(false);
            this.coinsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinsDataGrid)).EndInit();
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
        private MetroFramework.Controls.MetroTabPage customerTab;
        private MetroFramework.Controls.MetroTabPage coinsTab;
        private MetroFramework.Controls.MetroTabPage accountsTab;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox editTFLastaname;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox editTFCustomername;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox editTFCustomerId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTabPage transferNowTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox editTFAge;
        private System.Windows.Forms.DataGridView accountsDataGrid;
        private System.Windows.Forms.DataGridView coinsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

