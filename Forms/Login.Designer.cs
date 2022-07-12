
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnCloseWindow = new System.Windows.Forms.Button();
      this.btnLogin = new System.Windows.Forms.Button();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(257, 459);
      this.panel1.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(21, 429);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(223, 15);
      this.label3.TabIndex = 3;
      this.label3.Text = "Copyright VPOS Control 2022 Postek USA";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(66, 233);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(147, 25);
      this.label2.TabIndex = 2;
      this.label2.Text = "VPOS Control";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(69, 194);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "Bienvenido A";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(66, 32);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(131, 131);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnCloseWindow);
      this.panel2.Controls.Add(this.btnLogin);
      this.panel2.Controls.Add(this.panel4);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.panel2.Location = new System.Drawing.Point(257, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(386, 459);
      this.panel2.TabIndex = 1;
      // 
      // btnCloseWindow
      // 
      this.btnCloseWindow.FlatAppearance.BorderSize = 0;
      this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCloseWindow.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
      this.btnCloseWindow.Location = new System.Drawing.Point(351, 0);
      this.btnCloseWindow.Name = "btnCloseWindow";
      this.btnCloseWindow.Size = new System.Drawing.Size(34, 35);
      this.btnCloseWindow.TabIndex = 6;
      this.btnCloseWindow.Text = "X";
      this.btnCloseWindow.UseVisualStyleBackColor = true;
      this.btnCloseWindow.Click += new System.EventHandler(this.close_Click);
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(108, 306);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(145, 45);
      this.btnLogin.TabIndex = 5;
      this.btnLogin.Text = "Ingresar";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.Control;
      this.panel4.Controls.Add(this.txtPass);
      this.panel4.Controls.Add(this.iconPictureBox2);
      this.panel4.Location = new System.Drawing.Point(0, 205);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(386, 39);
      this.panel4.TabIndex = 4;
      // 
      // txtPass
      // 
      this.txtPass.BackColor = System.Drawing.SystemColors.Control;
      this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtPass.Font = new System.Drawing.Font("Century Gothic", 10F);
      this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.txtPass.Location = new System.Drawing.Point(46, 13);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new System.Drawing.Size(317, 17);
      this.txtPass.TabIndex = 2;
      this.txtPass.UseSystemPasswordChar = true;
      this.txtPass.Click += new System.EventHandler(this.textBox2_Click);
      this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // iconPictureBox2
      // 
      this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
      this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
      this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
      this.iconPictureBox2.IconSize = 21;
      this.iconPictureBox2.Location = new System.Drawing.Point(13, 10);
      this.iconPictureBox2.Name = "iconPictureBox2";
      this.iconPictureBox2.Size = new System.Drawing.Size(21, 21);
      this.iconPictureBox2.TabIndex = 1;
      this.iconPictureBox2.TabStop = false;
      this.iconPictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox2_MouseDown);
      this.iconPictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox2_MouseUp);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.txtUser);
      this.panel3.Controls.Add(this.iconPictureBox1);
      this.panel3.Location = new System.Drawing.Point(0, 160);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(386, 39);
      this.panel3.TabIndex = 3;
      // 
      // txtUser
      // 
      this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.txtUser.Location = new System.Drawing.Point(46, 10);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(317, 20);
      this.txtUser.TabIndex = 1;
      this.txtUser.Click += new System.EventHandler(this.textBox1_Click);
      // 
      // iconPictureBox1
      // 
      this.iconPictureBox1.BackColor = System.Drawing.Color.White;
      this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
      this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
      this.iconPictureBox1.IconSize = 21;
      this.iconPictureBox1.Location = new System.Drawing.Point(13, 10);
      this.iconPictureBox1.Name = "iconPictureBox1";
      this.iconPictureBox1.Size = new System.Drawing.Size(21, 21);
      this.iconPictureBox1.TabIndex = 0;
      this.iconPictureBox1.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.label4.Location = new System.Drawing.Point(55, 119);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(212, 24);
      this.label4.TabIndex = 2;
      this.label4.Text = "Ingrese a su cuenta";
      // 
      // Login
      // 
      this.AcceptButton = this.btnLogin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 459);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}