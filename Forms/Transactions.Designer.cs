
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class Transactions
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
      this.pnlMain = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel8 = new System.Windows.Forms.Panel();
      this.print_copy = new System.Windows.Forms.CheckBox();
      this.enviar = new System.Windows.Forms.Button();
      this.print_commerce = new System.Windows.Forms.CheckBox();
      this.limpiar = new System.Windows.Forms.Button();
      this.lblTicket = new System.Windows.Forms.Label();
      this.panel7 = new System.Windows.Forms.Panel();
      this.lblTotal = new System.Windows.Forms.Label();
      this.web_total_transaccion = new System.Windows.Forms.TextBox();
      this.panel6 = new System.Windows.Forms.Panel();
      this.lblLast4 = new System.Windows.Forms.Label();
      this.web_fecha_expiracion = new System.Windows.Forms.TextBox();
      this.web_ultimos4 = new System.Windows.Forms.TextBox();
      this.lblExpirationDate = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.lblTax2 = new System.Windows.Forms.Label();
      this.web_impuesto18 = new System.Windows.Forms.TextBox();
      this.lblTip = new System.Windows.Forms.Label();
      this.web_propina = new System.Windows.Forms.TextBox();
      this.web_impuesto15 = new System.Windows.Forms.TextBox();
      this.lblTax1 = new System.Windows.Forms.Label();
      this.web_importe_base = new System.Windows.Forms.TextBox();
      this.lblSubTotal = new System.Windows.Forms.Label();
      this.merchant_id = new System.Windows.Forms.Label();
      this.lblMerchantId = new System.Windows.Forms.Label();
      this.terminal_id = new System.Windows.Forms.Label();
      this.lblTerminalId = new System.Windows.Forms.Label();
      this.merchant_name = new System.Windows.Forms.Label();
      this.lblMerchantName = new System.Windows.Forms.Label();
      this.lblCommerce = new System.Windows.Forms.Label();
      this.commerces = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.closeTran = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.codigoAprobacion = new System.Windows.Forms.Label();
      this.lblApprovalNum = new System.Windows.Forms.Label();
      this.lblTitleResultTX = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.lblTitleResult = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.pnlMain.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlMain
      // 
      this.pnlMain.BackColor = System.Drawing.Color.White;
      this.pnlMain.Controls.Add(this.panel1);
      this.pnlMain.Controls.Add(this.web_impuesto15);
      this.pnlMain.Controls.Add(this.lblTax1);
      this.pnlMain.Controls.Add(this.web_importe_base);
      this.pnlMain.Controls.Add(this.lblSubTotal);
      this.pnlMain.Controls.Add(this.merchant_id);
      this.pnlMain.Controls.Add(this.lblMerchantId);
      this.pnlMain.Controls.Add(this.terminal_id);
      this.pnlMain.Controls.Add(this.lblTerminalId);
      this.pnlMain.Controls.Add(this.merchant_name);
      this.pnlMain.Controls.Add(this.lblMerchantName);
      this.pnlMain.Controls.Add(this.lblCommerce);
      this.pnlMain.Controls.Add(this.commerces);
      this.pnlMain.Controls.Add(this.panel2);
      this.pnlMain.Location = new System.Drawing.Point(34, 35);
      this.pnlMain.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(502, 525);
      this.pnlMain.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel8);
      this.panel1.Controls.Add(this.panel7);
      this.panel1.Controls.Add(this.panel6);
      this.panel1.Controls.Add(this.panel5);
      this.panel1.Location = new System.Drawing.Point(8, 230);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(491, 292);
      this.panel1.TabIndex = 13;
      // 
      // panel8
      // 
      this.panel8.AutoSize = true;
      this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel8.Controls.Add(this.print_copy);
      this.panel8.Controls.Add(this.enviar);
      this.panel8.Controls.Add(this.print_commerce);
      this.panel8.Controls.Add(this.limpiar);
      this.panel8.Controls.Add(this.lblTicket);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel8.Location = new System.Drawing.Point(0, 160);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(491, 118);
      this.panel8.TabIndex = 3;
      // 
      // print_copy
      // 
      this.print_copy.AutoSize = true;
      this.print_copy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.print_copy.ForeColor = System.Drawing.Color.Black;
      this.print_copy.Location = new System.Drawing.Point(388, 94);
      this.print_copy.Name = "print_copy";
      this.print_copy.Size = new System.Drawing.Size(73, 21);
      this.print_copy.TabIndex = 27;
      this.print_copy.Text = "Cliente";
      this.print_copy.UseVisualStyleBackColor = true;
      // 
      // enviar
      // 
      this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
      this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.enviar.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.enviar.ForeColor = System.Drawing.Color.Black;
      this.enviar.Location = new System.Drawing.Point(71, 20);
      this.enviar.Name = "enviar";
      this.enviar.Size = new System.Drawing.Size(136, 34);
      this.enviar.TabIndex = 23;
      this.enviar.Text = "Enviar";
      this.enviar.UseVisualStyleBackColor = false;
      this.enviar.Click += new System.EventHandler(this.enviar_Click);
      // 
      // print_commerce
      // 
      this.print_commerce.AutoSize = true;
      this.print_commerce.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.print_commerce.ForeColor = System.Drawing.Color.Black;
      this.print_commerce.Location = new System.Drawing.Point(12, 94);
      this.print_commerce.Name = "print_commerce";
      this.print_commerce.Size = new System.Drawing.Size(92, 21);
      this.print_commerce.TabIndex = 26;
      this.print_commerce.Text = "Comercio";
      this.print_commerce.UseVisualStyleBackColor = true;
      // 
      // limpiar
      // 
      this.limpiar.BackColor = System.Drawing.Color.White;
      this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.limpiar.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.limpiar.ForeColor = System.Drawing.Color.Black;
      this.limpiar.Location = new System.Drawing.Point(262, 20);
      this.limpiar.Name = "limpiar";
      this.limpiar.Size = new System.Drawing.Size(136, 34);
      this.limpiar.TabIndex = 24;
      this.limpiar.Text = "Limpiar";
      this.limpiar.UseVisualStyleBackColor = false;
      this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
      // 
      // lblTicket
      // 
      this.lblTicket.AutoSize = true;
      this.lblTicket.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTicket.ForeColor = System.Drawing.Color.Black;
      this.lblTicket.Location = new System.Drawing.Point(198, 75);
      this.lblTicket.Name = "lblTicket";
      this.lblTicket.Size = new System.Drawing.Size(67, 24);
      this.lblTicket.TabIndex = 25;
      this.lblTicket.Text = "Ticket";
      // 
      // panel7
      // 
      this.panel7.AutoSize = true;
      this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel7.Controls.Add(this.lblTotal);
      this.panel7.Controls.Add(this.web_total_transaccion);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel7.Location = new System.Drawing.Point(0, 112);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(491, 48);
      this.panel7.TabIndex = 2;
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblTotal.ForeColor = System.Drawing.Color.Black;
      this.lblTotal.Location = new System.Drawing.Point(65, 0);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(39, 17);
      this.lblTotal.TabIndex = 21;
      this.lblTotal.Text = "Total";
      // 
      // web_total_transaccion
      // 
      this.web_total_transaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.web_total_transaccion.Enabled = false;
      this.web_total_transaccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.web_total_transaccion.ForeColor = System.Drawing.Color.Black;
      this.web_total_transaccion.Location = new System.Drawing.Point(71, 18);
      this.web_total_transaccion.Name = "web_total_transaccion";
      this.web_total_transaccion.ReadOnly = true;
      this.web_total_transaccion.Size = new System.Drawing.Size(350, 27);
      this.web_total_transaccion.TabIndex = 22;
      this.web_total_transaccion.Text = "0.00";
      // 
      // panel6
      // 
      this.panel6.AutoSize = true;
      this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel6.Controls.Add(this.lblLast4);
      this.panel6.Controls.Add(this.web_fecha_expiracion);
      this.panel6.Controls.Add(this.web_ultimos4);
      this.panel6.Controls.Add(this.lblExpirationDate);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(0, 55);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(491, 57);
      this.panel6.TabIndex = 1;
      // 
      // lblLast4
      // 
      this.lblLast4.AutoSize = true;
      this.lblLast4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblLast4.ForeColor = System.Drawing.Color.Black;
      this.lblLast4.Location = new System.Drawing.Point(22, 10);
      this.lblLast4.Name = "lblLast4";
      this.lblLast4.Size = new System.Drawing.Size(208, 17);
      this.lblLast4.TabIndex = 17;
      this.lblLast4.Text = "Últimos 4 números de la tarjeta";
      // 
      // web_fecha_expiracion
      // 
      this.web_fecha_expiracion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_fecha_expiracion.ForeColor = System.Drawing.Color.Black;
      this.web_fecha_expiracion.Location = new System.Drawing.Point(283, 28);
      this.web_fecha_expiracion.MaxLength = 4;
      this.web_fecha_expiracion.Name = "web_fecha_expiracion";
      this.web_fecha_expiracion.Size = new System.Drawing.Size(178, 23);
      this.web_fecha_expiracion.TabIndex = 20;
      this.toolTip1.SetToolTip(this.web_fecha_expiracion, "MMYY");
      this.web_fecha_expiracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericOnly_KeyPress);
      // 
      // web_ultimos4
      // 
      this.web_ultimos4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_ultimos4.ForeColor = System.Drawing.Color.Black;
      this.web_ultimos4.Location = new System.Drawing.Point(22, 31);
      this.web_ultimos4.MaxLength = 16;
      this.web_ultimos4.Name = "web_ultimos4";
      this.web_ultimos4.Size = new System.Drawing.Size(178, 23);
      this.web_ultimos4.TabIndex = 18;
      this.toolTip1.SetToolTip(this.web_ultimos4, "XXXX XXXX XXXX 1234");
      this.web_ultimos4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericOnly_KeyPress);
      // 
      // lblExpirationDate
      // 
      this.lblExpirationDate.AutoSize = true;
      this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
      this.lblExpirationDate.Location = new System.Drawing.Point(283, 10);
      this.lblExpirationDate.Name = "lblExpirationDate";
      this.lblExpirationDate.Size = new System.Drawing.Size(138, 17);
      this.lblExpirationDate.TabIndex = 19;
      this.lblExpirationDate.Text = "Fecha de Expiración";
      // 
      // panel5
      // 
      this.panel5.AutoSize = true;
      this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel5.Controls.Add(this.lblTax2);
      this.panel5.Controls.Add(this.web_impuesto18);
      this.panel5.Controls.Add(this.lblTip);
      this.panel5.Controls.Add(this.web_propina);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(0, 0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(491, 55);
      this.panel5.TabIndex = 0;
      // 
      // lblTax2
      // 
      this.lblTax2.AutoSize = true;
      this.lblTax2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblTax2.ForeColor = System.Drawing.Color.Black;
      this.lblTax2.Location = new System.Drawing.Point(22, 11);
      this.lblTax2.Name = "lblTax2";
      this.lblTax2.Size = new System.Drawing.Size(111, 17);
      this.lblTax2.TabIndex = 13;
      this.lblTax2.Text = "Otros Impuestos";
      // 
      // web_impuesto18
      // 
      this.web_impuesto18.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_impuesto18.ForeColor = System.Drawing.Color.Black;
      this.web_impuesto18.Location = new System.Drawing.Point(22, 29);
      this.web_impuesto18.MaxLength = 16;
      this.web_impuesto18.Name = "web_impuesto18";
      this.web_impuesto18.Size = new System.Drawing.Size(178, 23);
      this.web_impuesto18.TabIndex = 14;
      this.toolTip1.SetToolTip(this.web_impuesto18, "0.00");
      this.web_impuesto18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
      this.web_impuesto18.Leave += new System.EventHandler(this.web_importe_base_Leave);
      // 
      // lblTip
      // 
      this.lblTip.AutoSize = true;
      this.lblTip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblTip.ForeColor = System.Drawing.Color.Black;
      this.lblTip.Location = new System.Drawing.Point(283, 11);
      this.lblTip.Name = "lblTip";
      this.lblTip.Size = new System.Drawing.Size(58, 17);
      this.lblTip.TabIndex = 15;
      this.lblTip.Text = "Propina";
      // 
      // web_propina
      // 
      this.web_propina.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_propina.ForeColor = System.Drawing.Color.Black;
      this.web_propina.Location = new System.Drawing.Point(283, 29);
      this.web_propina.MaxLength = 16;
      this.web_propina.Name = "web_propina";
      this.web_propina.Size = new System.Drawing.Size(178, 23);
      this.web_propina.TabIndex = 16;
      this.toolTip1.SetToolTip(this.web_propina, "0.00");
      this.web_propina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
      this.web_propina.Leave += new System.EventHandler(this.web_importe_base_Leave);
      // 
      // web_impuesto15
      // 
      this.web_impuesto15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_impuesto15.ForeColor = System.Drawing.Color.Black;
      this.web_impuesto15.Location = new System.Drawing.Point(291, 201);
      this.web_impuesto15.MaxLength = 16;
      this.web_impuesto15.Name = "web_impuesto15";
      this.web_impuesto15.Size = new System.Drawing.Size(178, 23);
      this.web_impuesto15.TabIndex = 12;
      this.toolTip1.SetToolTip(this.web_impuesto15, "0.00");
      this.web_impuesto15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
      this.web_impuesto15.Leave += new System.EventHandler(this.web_importe_base_Leave);
      // 
      // lblTax1
      // 
      this.lblTax1.AutoSize = true;
      this.lblTax1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblTax1.ForeColor = System.Drawing.Color.Black;
      this.lblTax1.Location = new System.Drawing.Point(291, 184);
      this.lblTax1.Name = "lblTax1";
      this.lblTax1.Size = new System.Drawing.Size(68, 17);
      this.lblTax1.TabIndex = 11;
      this.lblTax1.Text = "Impuesto";
      // 
      // web_importe_base
      // 
      this.web_importe_base.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.web_importe_base.ForeColor = System.Drawing.Color.Black;
      this.web_importe_base.Location = new System.Drawing.Point(30, 201);
      this.web_importe_base.MaxLength = 16;
      this.web_importe_base.Name = "web_importe_base";
      this.web_importe_base.Size = new System.Drawing.Size(178, 23);
      this.web_importe_base.TabIndex = 10;
      this.toolTip1.SetToolTip(this.web_importe_base, "0.00");
      this.web_importe_base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
      this.web_importe_base.Leave += new System.EventHandler(this.web_importe_base_Leave);
      // 
      // lblSubTotal
      // 
      this.lblSubTotal.AutoSize = true;
      this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
      this.lblSubTotal.Location = new System.Drawing.Point(30, 184);
      this.lblSubTotal.Name = "lblSubTotal";
      this.lblSubTotal.Size = new System.Drawing.Size(92, 17);
      this.lblSubTotal.TabIndex = 9;
      this.lblSubTotal.Text = "Importe Base";
      // 
      // merchant_id
      // 
      this.merchant_id.AutoSize = true;
      this.merchant_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.merchant_id.ForeColor = System.Drawing.Color.Black;
      this.merchant_id.Location = new System.Drawing.Point(188, 147);
      this.merchant_id.Name = "merchant_id";
      this.merchant_id.Size = new System.Drawing.Size(0, 16);
      this.merchant_id.TabIndex = 8;
      // 
      // lblMerchantId
      // 
      this.lblMerchantId.AutoSize = true;
      this.lblMerchantId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblMerchantId.ForeColor = System.Drawing.Color.Black;
      this.lblMerchantId.Location = new System.Drawing.Point(93, 147);
      this.lblMerchantId.Name = "lblMerchantId";
      this.lblMerchantId.Size = new System.Drawing.Size(86, 17);
      this.lblMerchantId.TabIndex = 7;
      this.lblMerchantId.Text = "Merchant ID";
      // 
      // terminal_id
      // 
      this.terminal_id.AutoSize = true;
      this.terminal_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.terminal_id.ForeColor = System.Drawing.Color.Black;
      this.terminal_id.Location = new System.Drawing.Point(188, 128);
      this.terminal_id.Name = "terminal_id";
      this.terminal_id.Size = new System.Drawing.Size(0, 16);
      this.terminal_id.TabIndex = 6;
      // 
      // lblTerminalId
      // 
      this.lblTerminalId.AutoSize = true;
      this.lblTerminalId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblTerminalId.ForeColor = System.Drawing.Color.Black;
      this.lblTerminalId.Location = new System.Drawing.Point(93, 128);
      this.lblTerminalId.Name = "lblTerminalId";
      this.lblTerminalId.Size = new System.Drawing.Size(78, 17);
      this.lblTerminalId.TabIndex = 5;
      this.lblTerminalId.Text = "Terminal ID";
      // 
      // merchant_name
      // 
      this.merchant_name.AutoSize = true;
      this.merchant_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.merchant_name.ForeColor = System.Drawing.Color.Black;
      this.merchant_name.Location = new System.Drawing.Point(188, 111);
      this.merchant_name.Name = "merchant_name";
      this.merchant_name.Size = new System.Drawing.Size(0, 16);
      this.merchant_name.TabIndex = 4;
      // 
      // lblMerchantName
      // 
      this.lblMerchantName.AutoSize = true;
      this.lblMerchantName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblMerchantName.ForeColor = System.Drawing.Color.Black;
      this.lblMerchantName.Location = new System.Drawing.Point(93, 110);
      this.lblMerchantName.Name = "lblMerchantName";
      this.lblMerchantName.Size = new System.Drawing.Size(61, 17);
      this.lblMerchantName.TabIndex = 3;
      this.lblMerchantName.Text = "Nombre";
      // 
      // lblCommerce
      // 
      this.lblCommerce.AutoSize = true;
      this.lblCommerce.BackColor = System.Drawing.Color.White;
      this.lblCommerce.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblCommerce.ForeColor = System.Drawing.Color.Black;
      this.lblCommerce.Location = new System.Drawing.Point(78, 51);
      this.lblCommerce.Name = "lblCommerce";
      this.lblCommerce.Size = new System.Drawing.Size(73, 17);
      this.lblCommerce.TabIndex = 2;
      this.lblCommerce.Text = "Comercio";
      // 
      // commerces
      // 
      this.commerces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.commerces.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.commerces.ForeColor = System.Drawing.Color.Black;
      this.commerces.FormattingEnabled = true;
      this.commerces.Location = new System.Drawing.Point(79, 70);
      this.commerces.Name = "commerces";
      this.commerces.Size = new System.Drawing.Size(350, 25);
      this.commerces.TabIndex = 1;
      this.toolTip1.SetToolTip(this.commerces, "Seleccione un adquirente");
      this.commerces.SelectedValueChanged += new System.EventHandler(this.commerces_SelectedValueChanged);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel2.Controls.Add(this.lblTitle);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(502, 37);
      this.panel2.TabIndex = 0;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ForeColor = System.Drawing.Color.Gray;
      this.lblTitle.Location = new System.Drawing.Point(10, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(65, 23);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Venta";
      // 
      // closeTran
      // 
      this.closeTran.BackColor = System.Drawing.Color.White;
      this.closeTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.closeTran.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.closeTran.ForeColor = System.Drawing.Color.Black;
      this.closeTran.Location = new System.Drawing.Point(792, 509);
      this.closeTran.Name = "closeTran";
      this.closeTran.Size = new System.Drawing.Size(136, 34);
      this.closeTran.TabIndex = 29;
      this.closeTran.Text = "Cerrar";
      this.closeTran.UseVisualStyleBackColor = false;
      this.closeTran.Click += new System.EventHandler(this.closeTran_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.codigoAprobacion);
      this.panel3.Controls.Add(this.lblApprovalNum);
      this.panel3.Controls.Add(this.lblTitleResultTX);
      this.panel3.Controls.Add(this.panel4);
      this.panel3.Location = new System.Drawing.Point(563, 35);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(365, 190);
      this.panel3.TabIndex = 1;
      // 
      // codigoAprobacion
      // 
      this.codigoAprobacion.AutoSize = true;
      this.codigoAprobacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.codigoAprobacion.ForeColor = System.Drawing.Color.Black;
      this.codigoAprobacion.Location = new System.Drawing.Point(175, 104);
      this.codigoAprobacion.Name = "codigoAprobacion";
      this.codigoAprobacion.Size = new System.Drawing.Size(0, 23);
      this.codigoAprobacion.TabIndex = 4;
      // 
      // lblApprovalNum
      // 
      this.lblApprovalNum.AutoSize = true;
      this.lblApprovalNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.lblApprovalNum.ForeColor = System.Drawing.Color.Black;
      this.lblApprovalNum.Location = new System.Drawing.Point(14, 111);
      this.lblApprovalNum.Name = "lblApprovalNum";
      this.lblApprovalNum.Size = new System.Drawing.Size(143, 17);
      this.lblApprovalNum.TabIndex = 2;
      this.lblApprovalNum.Text = "Código Aprobación:";
      // 
      // lblTitleResultTX
      // 
      this.lblTitleResultTX.AutoSize = true;
      this.lblTitleResultTX.Font = new System.Drawing.Font("Century Gothic", 14.25F);
      this.lblTitleResultTX.ForeColor = System.Drawing.Color.Black;
      this.lblTitleResultTX.Location = new System.Drawing.Point(13, 51);
      this.lblTitleResultTX.Name = "lblTitleResultTX";
      this.lblTitleResultTX.Size = new System.Drawing.Size(216, 22);
      this.lblTitleResultTX.TabIndex = 1;
      this.lblTitleResultTX.Text = "Resultado Transacción";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
      this.panel4.Controls.Add(this.lblTitleResult);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(365, 37);
      this.panel4.TabIndex = 0;
      // 
      // lblTitleResult
      // 
      this.lblTitleResult.AutoSize = true;
      this.lblTitleResult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
      this.lblTitleResult.ForeColor = System.Drawing.Color.Gray;
      this.lblTitleResult.Location = new System.Drawing.Point(13, 8);
      this.lblTitleResult.Name = "lblTitleResult";
      this.lblTitleResult.Size = new System.Drawing.Size(101, 23);
      this.lblTitleResult.TabIndex = 0;
      this.lblTitleResult.Text = "Resultado";
      // 
      // Transactions
      // 
      this.AcceptButton = this.enviar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(949, 560);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.closeTran);
      this.Controls.Add(this.panel3);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Transactions";
      this.Padding = new System.Windows.Forms.Padding(34, 35, 0, 0);
      this.Text = "Transactions";
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitleResult;
        private System.Windows.Forms.Label lblTitleResultTX;
        private System.Windows.Forms.ComboBox commerces;
        private System.Windows.Forms.Label lblCommerce;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label merchant_name;
        private System.Windows.Forms.Label lblTerminalId;
        private System.Windows.Forms.Label terminal_id;
        private System.Windows.Forms.Label merchant_id;
        private System.Windows.Forms.Label lblMerchantId;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox web_importe_base;
        private System.Windows.Forms.TextBox web_impuesto15;
        private System.Windows.Forms.Label lblTax1;
        private System.Windows.Forms.TextBox web_propina;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox web_impuesto18;
        private System.Windows.Forms.Label lblTax2;
        private System.Windows.Forms.TextBox web_ultimos4;
        private System.Windows.Forms.Label lblLast4;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox web_fecha_expiracion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox web_total_transaccion;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.CheckBox print_commerce;
        private System.Windows.Forms.CheckBox print_copy;
        private System.Windows.Forms.Button closeTran;
        private System.Windows.Forms.Label lblApprovalNum;
        private System.Windows.Forms.Label codigoAprobacion;
    private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}