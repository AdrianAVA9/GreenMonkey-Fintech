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
            this.resetCustomerForm = new MetroFramework.Controls.MetroButton();
            this.editTFNickname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.editTFStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.editTFBirdthdate = new System.Windows.Forms.DateTimePicker();
            this.otpTokenPanel = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.TFotpToken = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.editTFEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.editTFPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.editTFLastaname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.updateCustomerInformation = new MetroFramework.Controls.MetroButton();
            this.editTFCustomername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.editTFCustomerId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinsTab = new MetroFramework.Controls.MetroTabPage();
            this.coinsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsTab = new MetroFramework.Controls.MetroTabPage();
            this.accountsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            contentTab = new MetroFramework.Controls.MetroTabControl();
            contentTab.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.otpTokenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.coinsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinsDataGrid)).BeginInit();
            this.accountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentTab
            // 
            contentTab.Controls.Add(this.customerTab);
            contentTab.Controls.Add(this.coinsTab);
            contentTab.Controls.Add(this.accountsTab);
            contentTab.Controls.Add(this.transferNowTab);
            contentTab.Location = new System.Drawing.Point(28, 147);
            contentTab.Name = "contentTab";
            contentTab.SelectedIndex = 3;
            contentTab.Size = new System.Drawing.Size(1221, 541);
            contentTab.TabIndex = 10;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.resetCustomerForm);
            this.customerTab.Controls.Add(this.editTFNickname);
            this.customerTab.Controls.Add(this.metroLabel14);
            this.customerTab.Controls.Add(this.editTFStatus);
            this.customerTab.Controls.Add(this.metroLabel13);
            this.customerTab.Controls.Add(this.editTFBirdthdate);
            this.customerTab.Controls.Add(this.otpTokenPanel);
            this.customerTab.Controls.Add(this.editTFEmail);
            this.customerTab.Controls.Add(this.metroLabel11);
            this.customerTab.Controls.Add(this.editTFPhoneNumber);
            this.customerTab.Controls.Add(this.metroLabel10);
            this.customerTab.Controls.Add(this.metroLabel9);
            this.customerTab.Controls.Add(this.metroButton4);
            this.customerTab.Controls.Add(this.editTFLastaname);
            this.customerTab.Controls.Add(this.metroLabel8);
            this.customerTab.Controls.Add(this.updateCustomerInformation);
            this.customerTab.Controls.Add(this.editTFCustomername);
            this.customerTab.Controls.Add(this.metroLabel7);
            this.customerTab.Controls.Add(this.metroButton2);
            this.customerTab.Controls.Add(this.editTFCustomerId);
            this.customerTab.Controls.Add(this.metroLabel6);
            this.customerTab.Controls.Add(this.customerDataGrid);
            this.customerTab.HorizontalScrollbarBarColor = true;
            this.customerTab.Location = new System.Drawing.Point(4, 35);
            this.customerTab.Name = "customerTab";
            this.customerTab.Size = new System.Drawing.Size(1213, 502);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customers";
            this.customerTab.VerticalScrollbarBarColor = true;
            // 
            // resetCustomerForm
            // 
            this.resetCustomerForm.Location = new System.Drawing.Point(366, 458);
            this.resetCustomerForm.Name = "resetCustomerForm";
            this.resetCustomerForm.Size = new System.Drawing.Size(75, 23);
            this.resetCustomerForm.Style = MetroFramework.MetroColorStyle.Red;
            this.resetCustomerForm.TabIndex = 27;
            this.resetCustomerForm.Text = "Reset";
            this.resetCustomerForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resetCustomerForm.Click += new System.EventHandler(this.resetCustomerForm_Click);
            // 
            // editTFNickname
            // 
            this.editTFNickname.Location = new System.Drawing.Point(663, 259);
            this.editTFNickname.Name = "editTFNickname";
            this.editTFNickname.Size = new System.Drawing.Size(213, 23);
            this.editTFNickname.Style = MetroFramework.MetroColorStyle.White;
            this.editTFNickname.TabIndex = 26;
            this.editTFNickname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFNickname.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(590, 263);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(67, 19);
            this.metroLabel14.TabIndex = 25;
            this.metroLabel14.Text = "Nickname";
            // 
            // editTFStatus
            // 
            this.editTFStatus.Location = new System.Drawing.Point(663, 224);
            this.editTFStatus.Name = "editTFStatus";
            this.editTFStatus.Size = new System.Drawing.Size(213, 23);
            this.editTFStatus.Style = MetroFramework.MetroColorStyle.White;
            this.editTFStatus.TabIndex = 24;
            this.editTFStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFStatus.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(589, 228);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(43, 19);
            this.metroLabel13.TabIndex = 23;
            this.metroLabel13.Text = "Status";
            // 
            // editTFBirdthdate
            // 
            this.editTFBirdthdate.Location = new System.Drawing.Point(348, 227);
            this.editTFBirdthdate.Name = "editTFBirdthdate";
            this.editTFBirdthdate.Size = new System.Drawing.Size(213, 20);
            this.editTFBirdthdate.TabIndex = 22;
            // 
            // otpTokenPanel
            // 
            this.otpTokenPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.otpTokenPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.otpTokenPanel.Controls.Add(this.metroTile1);
            this.otpTokenPanel.Controls.Add(this.metroButton1);
            this.otpTokenPanel.Controls.Add(this.TFotpToken);
            this.otpTokenPanel.Controls.Add(this.metroLabel12);
            this.otpTokenPanel.CustomBackground = true;
            this.otpTokenPanel.HorizontalScrollbarBarColor = true;
            this.otpTokenPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.otpTokenPanel.HorizontalScrollbarSize = 10;
            this.otpTokenPanel.Location = new System.Drawing.Point(74, 331);
            this.otpTokenPanel.Name = "otpTokenPanel";
            this.otpTokenPanel.Size = new System.Drawing.Size(312, 98);
            this.otpTokenPanel.TabIndex = 21;
            this.otpTokenPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.otpTokenPanel.VerticalScrollbarBarColor = true;
            this.otpTokenPanel.VerticalScrollbarHighlightOnWheel = false;
            this.otpTokenPanel.VerticalScrollbarSize = 10;
            this.otpTokenPanel.Visible = false;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(306, 23);
            this.metroTile1.TabIndex = 21;
            this.metroTile1.Text = "Email Verification";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(193, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Verificar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.SaveUser);
            // 
            // TFotpToken
            // 
            this.TFotpToken.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TFotpToken.CustomBackground = true;
            this.TFotpToken.Location = new System.Drawing.Point(15, 64);
            this.TFotpToken.Name = "TFotpToken";
            this.TFotpToken.Size = new System.Drawing.Size(161, 23);
            this.TFotpToken.TabIndex = 20;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.CustomForeColor = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 32);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(155, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "OTP is sent to your email";
            // 
            // editTFEmail
            // 
            this.editTFEmail.Location = new System.Drawing.Point(348, 293);
            this.editTFEmail.Name = "editTFEmail";
            this.editTFEmail.Size = new System.Drawing.Size(213, 23);
            this.editTFEmail.Style = MetroFramework.MetroColorStyle.White;
            this.editTFEmail.TabIndex = 17;
            this.editTFEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFEmail.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(301, 293);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Email";
            // 
            // editTFPhoneNumber
            // 
            this.editTFPhoneNumber.Location = new System.Drawing.Point(348, 259);
            this.editTFPhoneNumber.Name = "editTFPhoneNumber";
            this.editTFPhoneNumber.Size = new System.Drawing.Size(213, 23);
            this.editTFPhoneNumber.Style = MetroFramework.MetroColorStyle.White;
            this.editTFPhoneNumber.TabIndex = 15;
            this.editTFPhoneNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFPhoneNumber.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(243, 263);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(99, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Phone Number";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(272, 231);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Birdthdate";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(260, 458);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton4.TabIndex = 11;
            this.metroButton4.Text = "Delete";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // editTFLastaname
            // 
            this.editTFLastaname.Location = new System.Drawing.Point(74, 293);
            this.editTFLastaname.Name = "editTFLastaname";
            this.editTFLastaname.Size = new System.Drawing.Size(161, 23);
            this.editTFLastaname.Style = MetroFramework.MetroColorStyle.White;
            this.editTFLastaname.TabIndex = 8;
            this.editTFLastaname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFLastaname.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(10, 293);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Lastname";
            // 
            // updateCustomerInformation
            // 
            this.updateCustomerInformation.Location = new System.Drawing.Point(169, 458);
            this.updateCustomerInformation.Name = "updateCustomerInformation";
            this.updateCustomerInformation.Size = new System.Drawing.Size(75, 23);
            this.updateCustomerInformation.Style = MetroFramework.MetroColorStyle.Yellow;
            this.updateCustomerInformation.TabIndex = 10;
            this.updateCustomerInformation.Text = "Update";
            this.updateCustomerInformation.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateCustomerInformation.Click += new System.EventHandler(this.UpdateCustomer);
            // 
            // editTFCustomername
            // 
            this.editTFCustomername.Location = new System.Drawing.Point(74, 259);
            this.editTFCustomername.Name = "editTFCustomername";
            this.editTFCustomername.Size = new System.Drawing.Size(161, 23);
            this.editTFCustomername.Style = MetroFramework.MetroColorStyle.White;
            this.editTFCustomername.TabIndex = 6;
            this.editTFCustomername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editTFCustomername.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 263);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Name";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(74, 458);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Save";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.CreateUser);
            // 
            // editTFCustomerId
            // 
            this.editTFCustomerId.Location = new System.Drawing.Point(74, 227);
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
            this.metroLabel6.Location = new System.Drawing.Point(48, 231);
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
            this.Column4,
            this.Column14,
            this.Column15});
            this.customerDataGrid.Location = new System.Drawing.Point(10, 29);
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
            // Column14
            // 
            this.Column14.HeaderText = "Phone number";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Email";
            this.Column15.Name = "Column15";
            // 
            // coinsTab
            // 
            this.coinsTab.Controls.Add(this.coinsDataGrid);
            this.coinsTab.HorizontalScrollbarBarColor = true;
            this.coinsTab.Location = new System.Drawing.Point(4, 35);
            this.coinsTab.Name = "coinsTab";
            this.coinsTab.Size = new System.Drawing.Size(1213, 502);
            this.coinsTab.TabIndex = 1;
            this.coinsTab.Text = "Coins";
            this.coinsTab.VerticalScrollbarBarColor = true;
            // 
            // coinsDataGrid
            // 
            this.coinsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coinsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column8});
            this.coinsDataGrid.Location = new System.Drawing.Point(3, 19);
            this.coinsDataGrid.Name = "coinsDataGrid";
            this.coinsDataGrid.Size = new System.Drawing.Size(742, 150);
            this.coinsDataGrid.TabIndex = 2;
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
            // accountsTab
            // 
            this.accountsTab.Controls.Add(this.accountsDataGrid);
            this.accountsTab.HorizontalScrollbarBarColor = true;
            this.accountsTab.Location = new System.Drawing.Point(4, 35);
            this.accountsTab.Name = "accountsTab";
            this.accountsTab.Size = new System.Drawing.Size(1213, 502);
            this.accountsTab.TabIndex = 2;
            this.accountsTab.Text = "Accounts";
            this.accountsTab.VerticalScrollbarBarColor = true;
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
            this.accountsDataGrid.Location = new System.Drawing.Point(3, 19);
            this.accountsDataGrid.Name = "accountsDataGrid";
            this.accountsDataGrid.Size = new System.Drawing.Size(837, 150);
            this.accountsDataGrid.TabIndex = 2;
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
            // transferNowTab
            // 
            this.transferNowTab.HorizontalScrollbarBarColor = true;
            this.transferNowTab.Location = new System.Drawing.Point(4, 35);
            this.transferNowTab.Name = "transferNowTab";
            this.transferNowTab.Size = new System.Drawing.Size(1213, 502);
            this.transferNowTab.TabIndex = 3;
            this.transferNowTab.Text = "Transactions";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 777);
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
            this.otpTokenPanel.ResumeLayout(false);
            this.otpTokenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.coinsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coinsDataGrid)).EndInit();
            this.accountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGrid)).EndInit();
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
        private MetroFramework.Controls.MetroButton updateCustomerInformation;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private MetroFramework.Controls.MetroTextBox editTFEmail;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox editTFPhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroPanel otpTokenPanel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox TFotpToken;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DateTimePicker editTFBirdthdate;
        private MetroFramework.Controls.MetroTextBox editTFNickname;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox editTFStatus;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton resetCustomerForm;
    }
}

