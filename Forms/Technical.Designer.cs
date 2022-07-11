
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class Technical
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
      this.Title = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.getInformation = new System.Windows.Forms.Button();
      this.getInitialization = new System.Windows.Forms.Button();
      this.lstCurrencies = new System.Windows.Forms.ListBox();
      this.lblCurrency = new System.Windows.Forms.Label();
      this.web_admin_to_technical = new System.Windows.Forms.TextBox();
      this.lblPass = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.lblInitializationTitle = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.PINpadTerminalID = new System.Windows.Forms.Label();
      this.PINpadSerial = new System.Windows.Forms.Label();
      this.PINpadVersion = new System.Windows.Forms.Label();
      this.lblTerminalID = new System.Windows.Forms.Label();
      this.lblSerial = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblInformation = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.lblInformationTitle = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.placeConfiguration = new System.Windows.Forms.Button();
      this.panel8 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.lblCommerces = new System.Windows.Forms.Label();
      this.chkAutoPrintSaleTicket = new System.Windows.Forms.CheckBox();
      this.chkAllowSesionExpired = new System.Windows.Forms.CheckBox();
      this.chkAlwaysCheckedPrintCustom = new System.Windows.Forms.CheckBox();
      this.chkAlwaysCheckedPrintCommerce = new System.Windows.Forms.CheckBox();
      this.chkPuntos = new System.Windows.Forms.CheckBox();
      this.chkCuotas = new System.Windows.Forms.CheckBox();
      this.chkTax2 = new System.Windows.Forms.CheckBox();
      this.chkTax1 = new System.Windows.Forms.CheckBox();
      this.chkTip = new System.Windows.Forms.CheckBox();
      this.chkExpirationDate = new System.Windows.Forms.CheckBox();
      this.chkLast4 = new System.Windows.Forms.CheckBox();
      this.panel7 = new System.Windows.Forms.Panel();
      this.lblTitleConfigVisibleFields = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.chkLstlstAcquires = new System.Windows.Forms.CheckedListBox();
      this.chkDiscount = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel7.SuspendLayout();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
      this.Title.ForeColor = System.Drawing.Color.Black;
      this.Title.Location = new System.Drawing.Point(22, 10);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(82, 23);
      this.Title.TabIndex = 0;
      this.Title.Text = "Tecnico";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.getInformation);
      this.panel1.Controls.Add(this.getInitialization);
      this.panel1.Controls.Add(this.lstCurrencies);
      this.panel1.Controls.Add(this.lblCurrency);
      this.panel1.Controls.Add(this.web_admin_to_technical);
      this.panel1.Controls.Add(this.lblPass);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Location = new System.Drawing.Point(22, 39);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(407, 283);
      this.panel1.TabIndex = 1;
      // 
      // getInformation
      // 
      this.getInformation.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.getInformation.ForeColor = System.Drawing.Color.Black;
      this.getInformation.Location = new System.Drawing.Point(235, 191);
      this.getInformation.Name = "getInformation";
      this.getInformation.Size = new System.Drawing.Size(155, 36);
      this.getInformation.TabIndex = 6;
      this.getInformation.Text = "Información";
      this.getInformation.UseVisualStyleBackColor = true;
      this.getInformation.Click += new System.EventHandler(this.getInformation_Click);
      // 
      // getInitialization
      // 
      this.getInitialization.BackColor = System.Drawing.Color.White;
      this.getInitialization.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.getInitialization.ForeColor = System.Drawing.Color.Black;
      this.getInitialization.Location = new System.Drawing.Point(235, 135);
      this.getInitialization.Name = "getInitialization";
      this.getInitialization.Size = new System.Drawing.Size(155, 36);
      this.getInitialization.TabIndex = 5;
      this.getInitialization.Text = "Inicializar";
      this.getInitialization.UseVisualStyleBackColor = false;
      this.getInitialization.Click += new System.EventHandler(this.getInitialization_Click);
      // 
      // lstCurrencies
      // 
      this.lstCurrencies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lstCurrencies.FormattingEnabled = true;
      this.lstCurrencies.ItemHeight = 17;
      this.lstCurrencies.Location = new System.Drawing.Point(15, 128);
      this.lstCurrencies.Name = "lstCurrencies";
      this.lstCurrencies.ScrollAlwaysVisible = true;
      this.lstCurrencies.Size = new System.Drawing.Size(198, 106);
      this.lstCurrencies.TabIndex = 4;
      // 
      // lblCurrency
      // 
      this.lblCurrency.AutoSize = true;
      this.lblCurrency.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblCurrency.ForeColor = System.Drawing.Color.Black;
      this.lblCurrency.Location = new System.Drawing.Point(15, 100);
      this.lblCurrency.Name = "lblCurrency";
      this.lblCurrency.Size = new System.Drawing.Size(67, 17);
      this.lblCurrency.TabIndex = 3;
      this.lblCurrency.Text = "Monedas";
      // 
      // web_admin_to_technical
      // 
      this.web_admin_to_technical.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_admin_to_technical.Location = new System.Drawing.Point(15, 68);
      this.web_admin_to_technical.Name = "web_admin_to_technical";
      this.web_admin_to_technical.PasswordChar = '*';
      this.web_admin_to_technical.Size = new System.Drawing.Size(375, 23);
      this.web_admin_to_technical.TabIndex = 2;
      // 
      // lblPass
      // 
      this.lblPass.AutoSize = true;
      this.lblPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblPass.ForeColor = System.Drawing.Color.Black;
      this.lblPass.Location = new System.Drawing.Point(15, 48);
      this.lblPass.Name = "lblPass";
      this.lblPass.Size = new System.Drawing.Size(84, 17);
      this.lblPass.TabIndex = 1;
      this.lblPass.Text = "Contraseña";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel2.Controls.Add(this.panel5);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(407, 37);
      this.panel2.TabIndex = 0;
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel5.Controls.Add(this.lblInitializationTitle);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(0, 0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(407, 37);
      this.panel5.TabIndex = 1;
      // 
      // lblInitializationTitle
      // 
      this.lblInitializationTitle.AutoSize = true;
      this.lblInitializationTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
      this.lblInitializationTitle.ForeColor = System.Drawing.Color.Black;
      this.lblInitializationTitle.Location = new System.Drawing.Point(15, 10);
      this.lblInitializationTitle.Name = "lblInitializationTitle";
      this.lblInitializationTitle.Size = new System.Drawing.Size(112, 19);
      this.lblInitializationTitle.TabIndex = 0;
      this.lblInitializationTitle.Text = "Inicialización";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(15, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 19);
      this.label2.TabIndex = 0;
      this.label2.Text = "Inicialización";
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.PINpadTerminalID);
      this.panel3.Controls.Add(this.PINpadSerial);
      this.panel3.Controls.Add(this.PINpadVersion);
      this.panel3.Controls.Add(this.lblTerminalID);
      this.panel3.Controls.Add(this.lblSerial);
      this.panel3.Controls.Add(this.lblVersion);
      this.panel3.Controls.Add(this.lblInformation);
      this.panel3.Controls.Add(this.panel4);
      this.panel3.Location = new System.Drawing.Point(22, 329);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(407, 211);
      this.panel3.TabIndex = 7;
      // 
      // PINpadTerminalID
      // 
      this.PINpadTerminalID.AutoSize = true;
      this.PINpadTerminalID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
      this.PINpadTerminalID.ForeColor = System.Drawing.Color.Black;
      this.PINpadTerminalID.Location = new System.Drawing.Point(107, 131);
      this.PINpadTerminalID.Name = "PINpadTerminalID";
      this.PINpadTerminalID.Size = new System.Drawing.Size(0, 16);
      this.PINpadTerminalID.TabIndex = 12;
      // 
      // PINpadSerial
      // 
      this.PINpadSerial.AutoSize = true;
      this.PINpadSerial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
      this.PINpadSerial.ForeColor = System.Drawing.Color.Black;
      this.PINpadSerial.Location = new System.Drawing.Point(107, 107);
      this.PINpadSerial.Name = "PINpadSerial";
      this.PINpadSerial.Size = new System.Drawing.Size(0, 16);
      this.PINpadSerial.TabIndex = 11;
      // 
      // PINpadVersion
      // 
      this.PINpadVersion.AutoSize = true;
      this.PINpadVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
      this.PINpadVersion.ForeColor = System.Drawing.Color.Black;
      this.PINpadVersion.Location = new System.Drawing.Point(107, 83);
      this.PINpadVersion.Name = "PINpadVersion";
      this.PINpadVersion.Size = new System.Drawing.Size(0, 16);
      this.PINpadVersion.TabIndex = 10;
      // 
      // lblTerminalID
      // 
      this.lblTerminalID.AutoSize = true;
      this.lblTerminalID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTerminalID.ForeColor = System.Drawing.Color.Black;
      this.lblTerminalID.Location = new System.Drawing.Point(15, 131);
      this.lblTerminalID.Name = "lblTerminalID";
      this.lblTerminalID.Size = new System.Drawing.Size(78, 17);
      this.lblTerminalID.TabIndex = 9;
      this.lblTerminalID.Text = "TerminalID:";
      // 
      // lblSerial
      // 
      this.lblSerial.AutoSize = true;
      this.lblSerial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSerial.ForeColor = System.Drawing.Color.Black;
      this.lblSerial.Location = new System.Drawing.Point(15, 107);
      this.lblSerial.Name = "lblSerial";
      this.lblSerial.Size = new System.Drawing.Size(45, 17);
      this.lblSerial.TabIndex = 8;
      this.lblSerial.Text = "Serial:";
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = true;
      this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVersion.ForeColor = System.Drawing.Color.Black;
      this.lblVersion.Location = new System.Drawing.Point(15, 83);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(89, 17);
      this.lblVersion.TabIndex = 7;
      this.lblVersion.Text = "Versión App:";
      // 
      // lblInformation
      // 
      this.lblInformation.AutoSize = true;
      this.lblInformation.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.lblInformation.ForeColor = System.Drawing.Color.Black;
      this.lblInformation.Location = new System.Drawing.Point(15, 48);
      this.lblInformation.Name = "lblInformation";
      this.lblInformation.Size = new System.Drawing.Size(198, 21);
      this.lblInformation.TabIndex = 1;
      this.lblInformation.Text = "Información de Terminal";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel4.Controls.Add(this.lblInformationTitle);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(407, 37);
      this.panel4.TabIndex = 0;
      // 
      // lblInformationTitle
      // 
      this.lblInformationTitle.AutoSize = true;
      this.lblInformationTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
      this.lblInformationTitle.ForeColor = System.Drawing.Color.Black;
      this.lblInformationTitle.Location = new System.Drawing.Point(15, 10);
      this.lblInformationTitle.Name = "lblInformationTitle";
      this.lblInformationTitle.Size = new System.Drawing.Size(103, 19);
      this.lblInformationTitle.TabIndex = 0;
      this.lblInformationTitle.Text = "Información";
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.White;
      this.panel6.Controls.Add(this.chkDiscount);
      this.panel6.Controls.Add(this.chkLstlstAcquires);
      this.panel6.Controls.Add(this.btnClose);
      this.panel6.Controls.Add(this.placeConfiguration);
      this.panel6.Controls.Add(this.panel8);
      this.panel6.Controls.Add(this.chkAutoPrintSaleTicket);
      this.panel6.Controls.Add(this.chkAllowSesionExpired);
      this.panel6.Controls.Add(this.chkAlwaysCheckedPrintCustom);
      this.panel6.Controls.Add(this.chkAlwaysCheckedPrintCommerce);
      this.panel6.Controls.Add(this.chkPuntos);
      this.panel6.Controls.Add(this.chkCuotas);
      this.panel6.Controls.Add(this.chkTax2);
      this.panel6.Controls.Add(this.chkTax1);
      this.panel6.Controls.Add(this.chkTip);
      this.panel6.Controls.Add(this.chkExpirationDate);
      this.panel6.Controls.Add(this.chkLast4);
      this.panel6.Controls.Add(this.panel7);
      this.panel6.Location = new System.Drawing.Point(466, 40);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(407, 500);
      this.panel6.TabIndex = 13;
      // 
      // placeConfiguration
      // 
      this.placeConfiguration.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.placeConfiguration.ForeColor = System.Drawing.Color.Black;
      this.placeConfiguration.Location = new System.Drawing.Point(19, 449);
      this.placeConfiguration.Name = "placeConfiguration";
      this.placeConfiguration.Size = new System.Drawing.Size(185, 36);
      this.placeConfiguration.TabIndex = 7;
      this.placeConfiguration.Text = "Tomar Configuración";
      this.placeConfiguration.UseVisualStyleBackColor = true;
      this.placeConfiguration.Click += new System.EventHandler(this.placeConfiguration_Click);
      // 
      // panel8
      // 
      this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
      this.panel8.Controls.Add(this.label8);
      this.panel8.Controls.Add(this.lblCommerces);
      this.panel8.Location = new System.Drawing.Point(15, 306);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(365, 36);
      this.panel8.TabIndex = 12;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
      this.label8.ForeColor = System.Drawing.Color.Black;
      this.label8.Location = new System.Drawing.Point(289, 9);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(0, 16);
      this.label8.TabIndex = 1;
      // 
      // lblCommerces
      // 
      this.lblCommerces.AutoSize = true;
      this.lblCommerces.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblCommerces.ForeColor = System.Drawing.Color.Black;
      this.lblCommerces.Location = new System.Drawing.Point(35, 9);
      this.lblCommerces.Name = "lblCommerces";
      this.lblCommerces.Size = new System.Drawing.Size(288, 16);
      this.lblCommerces.TabIndex = 0;
      this.lblCommerces.Text = "Adquirientes disponibles para Venta Retail";
      // 
      // chkAutoPrintSaleTicket
      // 
      this.chkAutoPrintSaleTicket.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkAutoPrintSaleTicket.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkAutoPrintSaleTicket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkAutoPrintSaleTicket.ForeColor = System.Drawing.Color.Black;
      this.chkAutoPrintSaleTicket.Location = new System.Drawing.Point(15, 218);
      this.chkAutoPrintSaleTicket.Name = "chkAutoPrintSaleTicket";
      this.chkAutoPrintSaleTicket.Size = new System.Drawing.Size(316, 20);
      this.chkAutoPrintSaleTicket.TabIndex = 11;
      this.chkAutoPrintSaleTicket.Text = "Imprimir ticket venta automáticamente";
      this.chkAutoPrintSaleTicket.UseVisualStyleBackColor = true;
      // 
      // chkAllowSesionExpired
      // 
      this.chkAllowSesionExpired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkAllowSesionExpired.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkAllowSesionExpired.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkAllowSesionExpired.ForeColor = System.Drawing.Color.Black;
      this.chkAllowSesionExpired.Location = new System.Drawing.Point(15, 201);
      this.chkAllowSesionExpired.Name = "chkAllowSesionExpired";
      this.chkAllowSesionExpired.Size = new System.Drawing.Size(316, 20);
      this.chkAllowSesionExpired.TabIndex = 10;
      this.chkAllowSesionExpired.Text = "Expirar sesión";
      this.chkAllowSesionExpired.UseVisualStyleBackColor = true;
      // 
      // chkAlwaysCheckedPrintCustom
      // 
      this.chkAlwaysCheckedPrintCustom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkAlwaysCheckedPrintCustom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkAlwaysCheckedPrintCustom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkAlwaysCheckedPrintCustom.ForeColor = System.Drawing.Color.Black;
      this.chkAlwaysCheckedPrintCustom.Location = new System.Drawing.Point(15, 184);
      this.chkAlwaysCheckedPrintCustom.Name = "chkAlwaysCheckedPrintCustom";
      this.chkAlwaysCheckedPrintCustom.Size = new System.Drawing.Size(316, 20);
      this.chkAlwaysCheckedPrintCustom.TabIndex = 9;
      this.chkAlwaysCheckedPrintCustom.Text = "Activo ticket cliente";
      this.chkAlwaysCheckedPrintCustom.UseVisualStyleBackColor = true;
      // 
      // chkAlwaysCheckedPrintCommerce
      // 
      this.chkAlwaysCheckedPrintCommerce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkAlwaysCheckedPrintCommerce.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkAlwaysCheckedPrintCommerce.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkAlwaysCheckedPrintCommerce.ForeColor = System.Drawing.Color.Black;
      this.chkAlwaysCheckedPrintCommerce.Location = new System.Drawing.Point(15, 167);
      this.chkAlwaysCheckedPrintCommerce.Name = "chkAlwaysCheckedPrintCommerce";
      this.chkAlwaysCheckedPrintCommerce.Size = new System.Drawing.Size(316, 20);
      this.chkAlwaysCheckedPrintCommerce.TabIndex = 8;
      this.chkAlwaysCheckedPrintCommerce.Text = "Activo ticket comercio";
      this.chkAlwaysCheckedPrintCommerce.UseVisualStyleBackColor = true;
      // 
      // chkPuntos
      // 
      this.chkPuntos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkPuntos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkPuntos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkPuntos.ForeColor = System.Drawing.Color.Black;
      this.chkPuntos.Location = new System.Drawing.Point(15, 150);
      this.chkPuntos.Name = "chkPuntos";
      this.chkPuntos.Size = new System.Drawing.Size(316, 20);
      this.chkPuntos.TabIndex = 7;
      this.chkPuntos.Text = "Mostrar puntos";
      this.chkPuntos.UseVisualStyleBackColor = true;
      // 
      // chkCuotas
      // 
      this.chkCuotas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkCuotas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkCuotas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkCuotas.ForeColor = System.Drawing.Color.Black;
      this.chkCuotas.Location = new System.Drawing.Point(15, 133);
      this.chkCuotas.Name = "chkCuotas";
      this.chkCuotas.Size = new System.Drawing.Size(316, 20);
      this.chkCuotas.TabIndex = 6;
      this.chkCuotas.Text = "Mostrar plan de pagos";
      this.chkCuotas.UseVisualStyleBackColor = true;
      // 
      // chkTax2
      // 
      this.chkTax2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkTax2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkTax2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkTax2.ForeColor = System.Drawing.Color.Black;
      this.chkTax2.Location = new System.Drawing.Point(15, 116);
      this.chkTax2.Name = "chkTax2";
      this.chkTax2.Size = new System.Drawing.Size(316, 20);
      this.chkTax2.TabIndex = 5;
      this.chkTax2.Text = "Otros impuestos";
      this.chkTax2.UseVisualStyleBackColor = true;
      // 
      // chkTax1
      // 
      this.chkTax1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkTax1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkTax1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkTax1.ForeColor = System.Drawing.Color.Black;
      this.chkTax1.Location = new System.Drawing.Point(15, 99);
      this.chkTax1.Name = "chkTax1";
      this.chkTax1.Size = new System.Drawing.Size(316, 20);
      this.chkTax1.TabIndex = 4;
      this.chkTax1.Text = "Impuesto";
      this.chkTax1.UseVisualStyleBackColor = true;
      // 
      // chkTip
      // 
      this.chkTip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkTip.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkTip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkTip.ForeColor = System.Drawing.Color.Black;
      this.chkTip.Location = new System.Drawing.Point(15, 82);
      this.chkTip.Name = "chkTip";
      this.chkTip.Size = new System.Drawing.Size(316, 20);
      this.chkTip.TabIndex = 3;
      this.chkTip.Text = "Propina";
      this.chkTip.UseVisualStyleBackColor = true;
      // 
      // chkExpirationDate
      // 
      this.chkExpirationDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkExpirationDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkExpirationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkExpirationDate.ForeColor = System.Drawing.Color.Black;
      this.chkExpirationDate.Location = new System.Drawing.Point(15, 65);
      this.chkExpirationDate.Name = "chkExpirationDate";
      this.chkExpirationDate.Size = new System.Drawing.Size(316, 20);
      this.chkExpirationDate.TabIndex = 2;
      this.chkExpirationDate.Text = "Fecha de expiración de la tarjeta";
      this.chkExpirationDate.UseVisualStyleBackColor = true;
      // 
      // chkLast4
      // 
      this.chkLast4.BackColor = System.Drawing.Color.White;
      this.chkLast4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkLast4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkLast4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkLast4.ForeColor = System.Drawing.Color.Black;
      this.chkLast4.Location = new System.Drawing.Point(15, 48);
      this.chkLast4.Name = "chkLast4";
      this.chkLast4.Size = new System.Drawing.Size(316, 20);
      this.chkLast4.TabIndex = 1;
      this.chkLast4.Text = "Últimos 4 dígitos de la tarjeta";
      this.chkLast4.UseVisualStyleBackColor = false;
      // 
      // panel7
      // 
      this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel7.Controls.Add(this.lblTitleConfigVisibleFields);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel7.Location = new System.Drawing.Point(0, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(407, 37);
      this.panel7.TabIndex = 0;
      // 
      // lblTitleConfigVisibleFields
      // 
      this.lblTitleConfigVisibleFields.AutoSize = true;
      this.lblTitleConfigVisibleFields.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
      this.lblTitleConfigVisibleFields.ForeColor = System.Drawing.Color.Black;
      this.lblTitleConfigVisibleFields.Location = new System.Drawing.Point(15, 10);
      this.lblTitleConfigVisibleFields.Name = "lblTitleConfigVisibleFields";
      this.lblTitleConfigVisibleFields.Size = new System.Drawing.Size(206, 19);
      this.lblTitleConfigVisibleFields.TabIndex = 0;
      this.lblTitleConfigVisibleFields.Text = "Visualización de Campos";
      // 
      // btnClose
      // 
      this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
      this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.btnClose.ForeColor = System.Drawing.Color.Black;
      this.btnClose.Location = new System.Drawing.Point(224, 449);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(155, 36);
      this.btnClose.TabIndex = 14;
      this.btnClose.Text = "Cerrar";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.closeTechnicalView_Click);
      // 
      // chkLstlstAcquires
      // 
      this.chkLstlstAcquires.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.chkLstlstAcquires.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkLstlstAcquires.FormattingEnabled = true;
      this.chkLstlstAcquires.Location = new System.Drawing.Point(15, 361);
      this.chkLstlstAcquires.Name = "chkLstlstAcquires";
      this.chkLstlstAcquires.Size = new System.Drawing.Size(308, 72);
      this.chkLstlstAcquires.TabIndex = 15;
      // 
      // chkDiscount
      // 
      this.chkDiscount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chkDiscount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
      this.chkDiscount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.chkDiscount.ForeColor = System.Drawing.Color.Black;
      this.chkDiscount.Location = new System.Drawing.Point(15, 235);
      this.chkDiscount.Name = "chkDiscount";
      this.chkDiscount.Size = new System.Drawing.Size(316, 20);
      this.chkDiscount.TabIndex = 16;
      this.chkDiscount.Text = "Descuento";
      this.chkDiscount.UseVisualStyleBackColor = true;
      // 
      // Technical
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(901, 552);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.Title);
      this.Name = "Technical";
      this.Text = "Technical";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox web_admin_to_technical;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ListBox lstCurrencies;
        private System.Windows.Forms.Button getInitialization;
        private System.Windows.Forms.Button getInformation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInformationTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblTerminalID;
        private System.Windows.Forms.Label PINpadVersion;
        private System.Windows.Forms.Label PINpadSerial;
        private System.Windows.Forms.Label PINpadTerminalID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblInitializationTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTitleConfigVisibleFields;
        private System.Windows.Forms.CheckBox chkExpirationDate;
        private System.Windows.Forms.CheckBox chkLast4;
        private System.Windows.Forms.CheckBox chkTip;
        private System.Windows.Forms.CheckBox chkTax1;
        private System.Windows.Forms.CheckBox chkTax2;
        private System.Windows.Forms.CheckBox chkCuotas;
        private System.Windows.Forms.CheckBox chkPuntos;
        private System.Windows.Forms.CheckBox chkAlwaysCheckedPrintCommerce;
        private System.Windows.Forms.CheckBox chkAlwaysCheckedPrintCustom;
        private System.Windows.Forms.CheckBox chkAllowSesionExpired;
        private System.Windows.Forms.CheckBox chkAutoPrintSaleTicket;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCommerces;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button placeConfiguration;
    private System.Windows.Forms.CheckedListBox chkLstlstAcquires;
    private System.Windows.Forms.CheckBox chkDiscount;
  }
}