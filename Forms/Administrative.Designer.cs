﻿
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class Administrative
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeTransactionView = new System.Windows.Forms.Button();
            this.printReportResult = new System.Windows.Forms.Button();
            this.codigoAprobacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.web_admin_to_report = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.web_admin_to_void = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.closeAnulView = new System.Windows.Forms.Button();
            this.voidResult = new System.Windows.Forms.Button();
            this.codigoVoidAprobacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.web_number_to_void = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.web_admin_to_settle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeCierreView = new System.Windows.Forms.Button();
            this.settleResult = new System.Windows.Forms.Button();
            this.codigoSettleAprobacion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tab_4 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.duplicateResult = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.web_number_to_duplicate = new System.Windows.Forms.TextBox();
            this.closeDupView = new System.Windows.Forms.Button();
            this.printLastDuplicate = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tab_3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tab_4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 562);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 487);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_1);
            this.tabControl1.Controls.Add(this.tab_2);
            this.tabControl1.Controls.Add(this.tab_3);
            this.tabControl1.Controls.Add(this.tab_4);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(23, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_1
            // 
            this.tab_1.Controls.Add(this.panel3);
            this.tab_1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab_1.ForeColor = System.Drawing.Color.Black;
            this.tab_1.Location = new System.Drawing.Point(4, 31);
            this.tab_1.Name = "tab_1";
            this.tab_1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_1.Size = new System.Drawing.Size(782, 393);
            this.tab_1.TabIndex = 0;
            this.tab_1.Text = "Reporte";
            this.tab_1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.closeTransactionView);
            this.panel3.Controls.Add(this.printReportResult);
            this.panel3.Controls.Add(this.codigoAprobacion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.web_admin_to_report);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(34, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 292);
            this.panel3.TabIndex = 0;
            // 
            // closeTransactionView
            // 
            this.closeTransactionView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeTransactionView.ForeColor = System.Drawing.Color.Black;
            this.closeTransactionView.Location = new System.Drawing.Point(509, 227);
            this.closeTransactionView.Name = "closeTransactionView";
            this.closeTransactionView.Size = new System.Drawing.Size(167, 27);
            this.closeTransactionView.TabIndex = 7;
            this.closeTransactionView.Text = "Cerrar";
            this.closeTransactionView.UseVisualStyleBackColor = true;
            this.closeTransactionView.Click += new System.EventHandler(this.closeTransactionView_Click);
            // 
            // printReportResult
            // 
            this.printReportResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printReportResult.ForeColor = System.Drawing.Color.Black;
            this.printReportResult.Location = new System.Drawing.Point(314, 227);
            this.printReportResult.Name = "printReportResult";
            this.printReportResult.Size = new System.Drawing.Size(167, 27);
            this.printReportResult.TabIndex = 6;
            this.printReportResult.Text = "Imprimir Reporte";
            this.printReportResult.UseVisualStyleBackColor = true;
            // 
            // codigoAprobacion
            // 
            this.codigoAprobacion.AutoSize = true;
            this.codigoAprobacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoAprobacion.Location = new System.Drawing.Point(200, 175);
            this.codigoAprobacion.Name = "codigoAprobacion";
            this.codigoAprobacion.Size = new System.Drawing.Size(36, 19);
            this.codigoAprobacion.TabIndex = 4;
            this.codigoAprobacion.Text = "xxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código Aprobación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado Transacción";
            // 
            // web_admin_to_report
            // 
            this.web_admin_to_report.Location = new System.Drawing.Point(13, 83);
            this.web_admin_to_report.Name = "web_admin_to_report";
            this.web_admin_to_report.Size = new System.Drawing.Size(375, 31);
            this.web_admin_to_report.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña Administrador PINpad";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 43);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // tab_2
            // 
            this.tab_2.Controls.Add(this.panel5);
            this.tab_2.Location = new System.Drawing.Point(4, 31);
            this.tab_2.Name = "tab_2";
            this.tab_2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_2.Size = new System.Drawing.Size(782, 393);
            this.tab_2.TabIndex = 1;
            this.tab_2.Text = "Anulaciones";
            this.tab_2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.web_admin_to_void);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.closeAnulView);
            this.panel5.Controls.Add(this.voidResult);
            this.panel5.Controls.Add(this.codigoVoidAprobacion);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.web_number_to_void);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(40, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(703, 336);
            this.panel5.TabIndex = 1;
            // 
            // web_admin_to_void
            // 
            this.web_admin_to_void.Location = new System.Drawing.Point(13, 152);
            this.web_admin_to_void.Name = "web_admin_to_void";
            this.web_admin_to_void.Size = new System.Drawing.Size(375, 31);
            this.web_admin_to_void.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contraseña Administrador PINpad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cargo:";
            // 
            // closeAnulView
            // 
            this.closeAnulView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeAnulView.ForeColor = System.Drawing.Color.Black;
            this.closeAnulView.Location = new System.Drawing.Point(509, 227);
            this.closeAnulView.Name = "closeAnulView";
            this.closeAnulView.Size = new System.Drawing.Size(167, 27);
            this.closeAnulView.TabIndex = 7;
            this.closeAnulView.Text = "Cerrar";
            this.closeAnulView.UseVisualStyleBackColor = true;
            this.closeAnulView.Click += new System.EventHandler(this.closeAnulView_Click);
            // 
            // voidResult
            // 
            this.voidResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voidResult.ForeColor = System.Drawing.Color.Black;
            this.voidResult.Location = new System.Drawing.Point(314, 227);
            this.voidResult.Name = "voidResult";
            this.voidResult.Size = new System.Drawing.Size(167, 27);
            this.voidResult.TabIndex = 6;
            this.voidResult.Text = "Anular";
            this.voidResult.UseVisualStyleBackColor = true;
            // 
            // codigoVoidAprobacion
            // 
            this.codigoVoidAprobacion.AutoSize = true;
            this.codigoVoidAprobacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoVoidAprobacion.Location = new System.Drawing.Point(207, 202);
            this.codigoVoidAprobacion.Name = "codigoVoidAprobacion";
            this.codigoVoidAprobacion.Size = new System.Drawing.Size(36, 19);
            this.codigoVoidAprobacion.TabIndex = 4;
            this.codigoVoidAprobacion.Text = "xxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Código Aprobación:";
            // 
            // web_number_to_void
            // 
            this.web_number_to_void.Location = new System.Drawing.Point(13, 83);
            this.web_number_to_void.Name = "web_number_to_void";
            this.web_number_to_void.Size = new System.Drawing.Size(375, 31);
            this.web_number_to_void.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(701, 43);
            this.panel6.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Anular Recibo";
            // 
            // tab_3
            // 
            this.tab_3.Controls.Add(this.panel7);
            this.tab_3.Location = new System.Drawing.Point(4, 31);
            this.tab_3.Name = "tab_3";
            this.tab_3.Padding = new System.Windows.Forms.Padding(3);
            this.tab_3.Size = new System.Drawing.Size(782, 393);
            this.tab_3.TabIndex = 2;
            this.tab_3.Text = "Cierre";
            this.tab_3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.web_admin_to_settle);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.closeCierreView);
            this.panel7.Controls.Add(this.settleResult);
            this.panel7.Controls.Add(this.codigoSettleAprobacion);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(40, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(703, 336);
            this.panel7.TabIndex = 2;
            // 
            // web_admin_to_settle
            // 
            this.web_admin_to_settle.Location = new System.Drawing.Point(12, 88);
            this.web_admin_to_settle.Name = "web_admin_to_settle";
            this.web_admin_to_settle.Size = new System.Drawing.Size(375, 31);
            this.web_admin_to_settle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña Administrador PINpad";
            // 
            // closeCierreView
            // 
            this.closeCierreView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeCierreView.ForeColor = System.Drawing.Color.Black;
            this.closeCierreView.Location = new System.Drawing.Point(509, 227);
            this.closeCierreView.Name = "closeCierreView";
            this.closeCierreView.Size = new System.Drawing.Size(167, 27);
            this.closeCierreView.TabIndex = 7;
            this.closeCierreView.Text = "Cerrar";
            this.closeCierreView.UseVisualStyleBackColor = true;
            this.closeCierreView.Click += new System.EventHandler(this.closeCierreView_Click);
            // 
            // settleResult
            // 
            this.settleResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settleResult.ForeColor = System.Drawing.Color.Black;
            this.settleResult.Location = new System.Drawing.Point(314, 227);
            this.settleResult.Name = "settleResult";
            this.settleResult.Size = new System.Drawing.Size(167, 27);
            this.settleResult.TabIndex = 6;
            this.settleResult.Text = "Cierre";
            this.settleResult.UseVisualStyleBackColor = true;
            // 
            // codigoSettleAprobacion
            // 
            this.codigoSettleAprobacion.AutoSize = true;
            this.codigoSettleAprobacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codigoSettleAprobacion.Location = new System.Drawing.Point(199, 142);
            this.codigoSettleAprobacion.Name = "codigoSettleAprobacion";
            this.codigoSettleAprobacion.Size = new System.Drawing.Size(36, 19);
            this.codigoSettleAprobacion.TabIndex = 4;
            this.codigoSettleAprobacion.Text = "xxx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Código Aprobación:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel8.Controls.Add(this.label14);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(701, 43);
            this.panel8.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cierre Ventas";
            // 
            // tab_4
            // 
            this.tab_4.Controls.Add(this.panel9);
            this.tab_4.Location = new System.Drawing.Point(4, 31);
            this.tab_4.Name = "tab_4";
            this.tab_4.Padding = new System.Windows.Forms.Padding(3);
            this.tab_4.Size = new System.Drawing.Size(782, 393);
            this.tab_4.TabIndex = 3;
            this.tab_4.Text = "Duplicado";
            this.tab_4.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.duplicateResult);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.web_number_to_duplicate);
            this.panel9.Controls.Add(this.closeDupView);
            this.panel9.Controls.Add(this.printLastDuplicate);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(40, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(703, 336);
            this.panel9.TabIndex = 3;
            // 
            // duplicateResult
            // 
            this.duplicateResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duplicateResult.ForeColor = System.Drawing.Color.Black;
            this.duplicateResult.Location = new System.Drawing.Point(119, 227);
            this.duplicateResult.Name = "duplicateResult";
            this.duplicateResult.Size = new System.Drawing.Size(167, 27);
            this.duplicateResult.TabIndex = 11;
            this.duplicateResult.Text = "Duplicado";
            this.duplicateResult.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(12, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 22);
            this.label17.TabIndex = 10;
            this.label17.Text = "Cargo:";
            // 
            // web_number_to_duplicate
            // 
            this.web_number_to_duplicate.Location = new System.Drawing.Point(12, 95);
            this.web_number_to_duplicate.Name = "web_number_to_duplicate";
            this.web_number_to_duplicate.Size = new System.Drawing.Size(375, 31);
            this.web_number_to_duplicate.TabIndex = 9;
            // 
            // closeDupView
            // 
            this.closeDupView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeDupView.ForeColor = System.Drawing.Color.Black;
            this.closeDupView.Location = new System.Drawing.Point(509, 227);
            this.closeDupView.Name = "closeDupView";
            this.closeDupView.Size = new System.Drawing.Size(167, 27);
            this.closeDupView.TabIndex = 7;
            this.closeDupView.Text = "Cerrar";
            this.closeDupView.UseVisualStyleBackColor = true;
            this.closeDupView.Click += new System.EventHandler(this.closeDupView_Click);
            // 
            // printLastDuplicate
            // 
            this.printLastDuplicate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printLastDuplicate.ForeColor = System.Drawing.Color.Black;
            this.printLastDuplicate.Location = new System.Drawing.Point(314, 227);
            this.printLastDuplicate.Name = "printLastDuplicate";
            this.printLastDuplicate.Size = new System.Drawing.Size(167, 27);
            this.printLastDuplicate.TabIndex = 6;
            this.printLastDuplicate.Text = "Último";
            this.printLastDuplicate.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel10.Controls.Add(this.label16);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(701, 43);
            this.panel10.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Duplicado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrativo";
            // 
            // Administrative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 631);
            this.Controls.Add(this.panel1);
            this.Name = "Administrative";
            this.Text = "Administrative";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tab_3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tab_4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_1;
        private System.Windows.Forms.TabPage tab_2;
        private System.Windows.Forms.TabPage tab_3;
        private System.Windows.Forms.TabPage tab_4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox web_admin_to_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label codigoAprobacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getInitialization;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printReportResult;
        private System.Windows.Forms.Button closeTransactionView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button voidResult;
        private System.Windows.Forms.Label codigoVoidAprobacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox web_number_to_void;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox web_admin_to_void;
        private System.Windows.Forms.Button closeAnulView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button settleResult;
        private System.Windows.Forms.Label codigoSettleAprobacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox web_admin_to_settle;
        private System.Windows.Forms.Button closeCierreView;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button duplicateResult;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox web_number_to_duplicate;
        private System.Windows.Forms.Button printLastDuplicate;
        private System.Windows.Forms.Button closeDupView;
    }
}