
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class Points
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.codigoAprobacion = new System.Windows.Forms.Label();
            this.lblApprovalNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.limpiar = new System.Windows.Forms.Button();
            this.closeTran = new System.Windows.Forms.Button();
            this.print_copy = new System.Windows.Forms.CheckBox();
            this.print_commerce = new System.Windows.Forms.CheckBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.web_total_transaccion = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.web_ultimos4 = new System.Windows.Forms.TextBox();
            this.lblLast4 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.codigoAprobacion);
            this.panel3.Controls.Add(this.lblApprovalNum);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(514, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 182);
            this.panel3.TabIndex = 4;
            // 
            // codigoAprobacion
            // 
            this.codigoAprobacion.AutoSize = true;
            this.codigoAprobacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoAprobacion.ForeColor = System.Drawing.Color.Black;
            this.codigoAprobacion.Location = new System.Drawing.Point(162, 104);
            this.codigoAprobacion.Name = "codigoAprobacion";
            this.codigoAprobacion.Size = new System.Drawing.Size(35, 16);
            this.codigoAprobacion.TabIndex = 4;
            this.codigoAprobacion.Text = "xxxx";
            // 
            // lblApprovalNum
            // 
            this.lblApprovalNum.AutoSize = true;
            this.lblApprovalNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApprovalNum.ForeColor = System.Drawing.Color.Black;
            this.lblApprovalNum.Location = new System.Drawing.Point(15, 104);
            this.lblApprovalNum.Name = "lblApprovalNum";
            this.lblApprovalNum.Size = new System.Drawing.Size(141, 16);
            this.lblApprovalNum.TabIndex = 2;
            this.lblApprovalNum.Text = "Código Aprobación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultado Transacción";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 43);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.limpiar);
            this.panel1.Controls.Add(this.closeTran);
            this.panel1.Controls.Add(this.print_copy);
            this.panel1.Controls.Add(this.print_commerce);
            this.panel1.Controls.Add(this.lblTicket);
            this.panel1.Controls.Add(this.enviar);
            this.panel1.Controls.Add(this.web_total_transaccion);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblExpirationDate);
            this.panel1.Controls.Add(this.web_ultimos4);
            this.panel1.Controls.Add(this.lblLast4);
            this.panel1.Controls.Add(this.web_importe_base);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.merchant_id);
            this.panel1.Controls.Add(this.lblMerchantId);
            this.panel1.Controls.Add(this.terminal_id);
            this.panel1.Controls.Add(this.lblTerminalId);
            this.panel1.Controls.Add(this.merchant_name);
            this.panel1.Controls.Add(this.lblMerchantName);
            this.panel1.Controls.Add(this.lblCommerce);
            this.panel1.Controls.Add(this.commerces);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 594);
            this.panel1.TabIndex = 3;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.White;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(249, 403);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(110, 27);
            this.limpiar.TabIndex = 31;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            // 
            // closeTran
            // 
            this.closeTran.BackColor = System.Drawing.Color.White;
            this.closeTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTran.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeTran.ForeColor = System.Drawing.Color.Black;
            this.closeTran.Location = new System.Drawing.Point(164, 446);
            this.closeTran.Name = "closeTran";
            this.closeTran.Size = new System.Drawing.Size(75, 27);
            this.closeTran.TabIndex = 29;
            this.closeTran.Text = "Cerrar";
            this.closeTran.UseVisualStyleBackColor = false;
            this.closeTran.Click += new System.EventHandler(this.closeTran_Click);
            // 
            // print_copy
            // 
            this.print_copy.AutoSize = true;
            this.print_copy.ForeColor = System.Drawing.Color.Black;
            this.print_copy.Location = new System.Drawing.Point(230, 537);
            this.print_copy.Name = "print_copy";
            this.print_copy.Size = new System.Drawing.Size(63, 19);
            this.print_copy.TabIndex = 27;
            this.print_copy.Text = "Cliente";
            this.print_copy.UseVisualStyleBackColor = true;
            // 
            // print_commerce
            // 
            this.print_commerce.AutoSize = true;
            this.print_commerce.ForeColor = System.Drawing.Color.Black;
            this.print_commerce.Location = new System.Drawing.Point(85, 537);
            this.print_commerce.Name = "print_commerce";
            this.print_commerce.Size = new System.Drawing.Size(78, 19);
            this.print_commerce.TabIndex = 26;
            this.print_commerce.Text = "Comercio";
            this.print_commerce.UseVisualStyleBackColor = true;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicket.ForeColor = System.Drawing.Color.Black;
            this.lblTicket.Location = new System.Drawing.Point(173, 507);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(56, 21);
            this.lblTicket.TabIndex = 25;
            this.lblTicket.Text = "Ticket";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.White;
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enviar.ForeColor = System.Drawing.Color.Black;
            this.enviar.Location = new System.Drawing.Point(53, 403);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(110, 27);
            this.enviar.TabIndex = 23;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            // 
            // web_total_transaccion
            // 
            this.web_total_transaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.web_total_transaccion.ForeColor = System.Drawing.Color.DarkGray;
            this.web_total_transaccion.Location = new System.Drawing.Point(12, 342);
            this.web_total_transaccion.Name = "web_total_transaccion";
            this.web_total_transaccion.ReadOnly = true;
            this.web_total_transaccion.Size = new System.Drawing.Size(408, 23);
            this.web_total_transaccion.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(12, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Puntos";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(231, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 23);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "MMYY";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(231, 263);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(128, 17);
            this.lblExpirationDate.TabIndex = 19;
            this.lblExpirationDate.Text = "Fecha de Expiración";
            // 
            // web_ultimos4
            // 
            this.web_ultimos4.ForeColor = System.Drawing.Color.DarkGray;
            this.web_ultimos4.Location = new System.Drawing.Point(12, 283);
            this.web_ultimos4.Name = "web_ultimos4";
            this.web_ultimos4.Size = new System.Drawing.Size(189, 23);
            this.web_ultimos4.TabIndex = 18;
            this.web_ultimos4.Text = "XXXX XXXX XXXX 1234";
            // 
            // lblLast4
            // 
            this.lblLast4.AutoSize = true;
            this.lblLast4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLast4.ForeColor = System.Drawing.Color.Black;
            this.lblLast4.Location = new System.Drawing.Point(12, 263);
            this.lblLast4.Name = "lblLast4";
            this.lblLast4.Size = new System.Drawing.Size(191, 17);
            this.lblLast4.TabIndex = 17;
            this.lblLast4.Text = "Últimos 4 números de la tarjeta";
            // 
            // web_importe_base
            // 
            this.web_importe_base.ForeColor = System.Drawing.Color.DarkGray;
            this.web_importe_base.Location = new System.Drawing.Point(12, 215);
            this.web_importe_base.Name = "web_importe_base";
            this.web_importe_base.Size = new System.Drawing.Size(189, 23);
            this.web_importe_base.TabIndex = 10;
            this.web_importe_base.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 195);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(47, 17);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "Puntos";
            // 
            // merchant_id
            // 
            this.merchant_id.AutoSize = true;
            this.merchant_id.ForeColor = System.Drawing.Color.Black;
            this.merchant_id.Location = new System.Drawing.Point(90, 162);
            this.merchant_id.Name = "merchant_id";
            this.merchant_id.Size = new System.Drawing.Size(25, 15);
            this.merchant_id.TabIndex = 8;
            this.merchant_id.Text = "xxx";
            // 
            // lblMerchantId
            // 
            this.lblMerchantId.AutoSize = true;
            this.lblMerchantId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMerchantId.ForeColor = System.Drawing.Color.Black;
            this.lblMerchantId.Location = new System.Drawing.Point(12, 160);
            this.lblMerchantId.Name = "lblMerchantId";
            this.lblMerchantId.Size = new System.Drawing.Size(81, 17);
            this.lblMerchantId.TabIndex = 7;
            this.lblMerchantId.Text = "Merchant ID";
            // 
            // terminal_id
            // 
            this.terminal_id.AutoSize = true;
            this.terminal_id.ForeColor = System.Drawing.Color.Black;
            this.terminal_id.Location = new System.Drawing.Point(90, 140);
            this.terminal_id.Name = "terminal_id";
            this.terminal_id.Size = new System.Drawing.Size(25, 15);
            this.terminal_id.TabIndex = 6;
            this.terminal_id.Text = "xxx";
            // 
            // lblTerminalId
            // 
            this.lblTerminalId.AutoSize = true;
            this.lblTerminalId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerminalId.ForeColor = System.Drawing.Color.Black;
            this.lblTerminalId.Location = new System.Drawing.Point(12, 138);
            this.lblTerminalId.Name = "lblTerminalId";
            this.lblTerminalId.Size = new System.Drawing.Size(72, 17);
            this.lblTerminalId.TabIndex = 5;
            this.lblTerminalId.Text = "Terminal ID";
            // 
            // merchant_name
            // 
            this.merchant_name.AutoSize = true;
            this.merchant_name.ForeColor = System.Drawing.Color.Black;
            this.merchant_name.Location = new System.Drawing.Point(90, 119);
            this.merchant_name.Name = "merchant_name";
            this.merchant_name.Size = new System.Drawing.Size(25, 15);
            this.merchant_name.TabIndex = 4;
            this.merchant_name.Text = "xxx";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMerchantName.ForeColor = System.Drawing.Color.Black;
            this.lblMerchantName.Location = new System.Drawing.Point(12, 117);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(56, 17);
            this.lblMerchantName.TabIndex = 3;
            this.lblMerchantName.Text = "Nombre";
            // 
            // lblCommerce
            // 
            this.lblCommerce.AutoSize = true;
            this.lblCommerce.BackColor = System.Drawing.Color.White;
            this.lblCommerce.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommerce.ForeColor = System.Drawing.Color.Black;
            this.lblCommerce.Location = new System.Drawing.Point(12, 63);
            this.lblCommerce.Name = "lblCommerce";
            this.lblCommerce.Size = new System.Drawing.Size(47, 17);
            this.lblCommerce.TabIndex = 2;
            this.lblCommerce.Text = "Puntos";
            // 
            // commerces
            // 
            this.commerces.ForeColor = System.Drawing.Color.Silver;
            this.commerces.FormattingEnabled = true;
            this.commerces.Location = new System.Drawing.Point(12, 81);
            this.commerces.Name = "commerces";
            this.commerces.Size = new System.Drawing.Size(410, 23);
            this.commerces.TabIndex = 1;
            this.commerces.Text = "Seleccione una acción";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos";
            // 
            // Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Points";
            this.Text = "Points";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label codigoAprobacion;
        private System.Windows.Forms.Label lblApprovalNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button closeTran;
        private System.Windows.Forms.CheckBox print_copy;
        private System.Windows.Forms.CheckBox print_commerce;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox web_total_transaccion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox web_ultimos4;
        private System.Windows.Forms.Label lblLast4;
        private System.Windows.Forms.TextBox web_importe_base;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label merchant_id;
        private System.Windows.Forms.Label lblMerchantId;
        private System.Windows.Forms.Label terminal_id;
        private System.Windows.Forms.Label lblTerminalId;
        private System.Windows.Forms.Label merchant_name;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label lblCommerce;
        private System.Windows.Forms.ComboBox commerces;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}