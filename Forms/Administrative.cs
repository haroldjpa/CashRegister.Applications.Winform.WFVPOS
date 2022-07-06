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
    public partial class Administrative : Form
    {
        public Administrative()
        {
            InitializeComponent();
        }

        private void closeAnulView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeTransactionView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void closeCierreView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeDupView_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
