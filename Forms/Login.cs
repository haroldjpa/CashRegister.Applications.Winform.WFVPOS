using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            iconPictureBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            iconPictureBox2.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            
        }

        private void iconPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void iconPictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

           var das = new Dashboard();
            das.Show();
            
        }
    }
}
