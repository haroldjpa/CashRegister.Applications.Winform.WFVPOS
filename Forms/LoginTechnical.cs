using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.Utilities;
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
  public partial class LoginTechnical : Form
  {
    private Form currentChildForm;
        private int datoPantalla;
    public LoginTechnical(int origen)
    {
      InitializeComponent();
      this.DoubleBuffered = true;
            datoPantalla = origen;
    }

    public void OpenChildForm(Form childForm)
    {
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      currentChildForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      panel4.Controls.Add(childForm);
      panel4.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();

    }
    private void enviar_technical_Click(object sender, EventArgs e)
    {

      string password = pass.Text;
      try
      {
        string hash = Utils.GetSHA512(password);

        if (hash.Equals(GlobalInformation.Instance.GetParameterValue(PA_PARAMETERS.TECHNICAL_PASS.ToString())))
        {

                    if (datoPantalla == 1)
                    {
                        OpenChildForm(new Technical());
                    }
                    else if (datoPantalla == 2)
                    {
                        OpenChildForm(new Users());
                    }

                }
        else
        {
          MessageBox.Show("Contraseña equivocada", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

    }
  }
}
