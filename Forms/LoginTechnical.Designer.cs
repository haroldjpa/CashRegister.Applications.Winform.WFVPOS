
namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    partial class LoginTechnical
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
      this.enviar_technical = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
      this.pass = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.enviar_technical);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Location = new System.Drawing.Point(38, 31);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(339, 196);
      this.panel1.TabIndex = 0;
      // 
      // enviar_technical
      // 
      this.enviar_technical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.enviar_technical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.enviar_technical.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.enviar_technical.ForeColor = System.Drawing.Color.White;
      this.enviar_technical.Location = new System.Drawing.Point(83, 118);
      this.enviar_technical.Name = "enviar_technical";
      this.enviar_technical.Size = new System.Drawing.Size(155, 36);
      this.enviar_technical.TabIndex = 6;
      this.enviar_technical.Text = "Ingresar";
      this.enviar_technical.UseVisualStyleBackColor = false;
      this.enviar_technical.Click += new System.EventHandler(this.enviar_technical_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.iconPictureBox1);
      this.panel3.Controls.Add(this.pass);
      this.panel3.Location = new System.Drawing.Point(15, 51);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(305, 43);
      this.panel3.TabIndex = 1;
      // 
      // iconPictureBox1
      // 
      this.iconPictureBox1.BackColor = System.Drawing.Color.White;
      this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
      this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
      this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconPictureBox1.IconSize = 27;
      this.iconPictureBox1.Location = new System.Drawing.Point(268, 8);
      this.iconPictureBox1.Name = "iconPictureBox1";
      this.iconPictureBox1.Size = new System.Drawing.Size(27, 28);
      this.iconPictureBox1.TabIndex = 2;
      this.iconPictureBox1.TabStop = false;
      // 
      // pass
      // 
      this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pass.Location = new System.Drawing.Point(20, 12);
      this.pass.Name = "pass";
      this.pass.Size = new System.Drawing.Size(233, 29);
      this.pass.TabIndex = 1;
      this.pass.UseSystemPasswordChar = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(339, 38);
      this.panel2.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(65, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(194, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Contraseña Técnico";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.panel1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(617, 352);
      this.panel4.TabIndex = 1;
      // 
      // LoginTechnical
      // 
      this.AcceptButton = this.enviar_technical;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(617, 352);
      this.Controls.Add(this.panel4);
      this.Name = "LoginTechnical";
      this.Text = "LoginTechnical";
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button enviar_technical;
        private System.Windows.Forms.Panel panel4;
    }
}