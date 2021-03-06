using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashRegister.Libraries.DataStructs;
using FontAwesome.Sharp;

namespace CashRegister.Applications.Winform.WFVPos.Forms
{
  public partial class Dashboard : Form
  {
    //Campos
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;
    public Dashboard()
    {
      InitializeComponent();
      
      
      SetCountryConfig();

      leftBorderBtn = new Panel();
      leftBorderBtn.Size = new Size(7, 60);
      panelMenu.Controls.Add(leftBorderBtn);
      this.Text = String.Empty;
      this.ControlBox = false;
      this.DoubleBuffered = true;
      this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


    }

    private void SetCountryConfig()
    {
      if (SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa == GlobalInformation.Instance.SysCountryApplication ||
        SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
      {
        btnCuotas.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString());
        btnPuntos.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString());
        //ViewBag.UserImage = "user-default-ficohsa-160x160.jpg";

      }

      if (SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication )
        btnCuotas.Text = "Plan de pagos";


    }


    //Structs
    private struct RGBColors
    {
      public static Color color1 = Color.FromArgb(172, 126, 241);
      public static Color color2 = Color.FromArgb(249, 118, 176);
      public static Color color3 = Color.FromArgb(253, 138, 114);
      public static Color color4 = Color.FromArgb(95, 77, 221);
      public static Color color5 = Color.FromArgb(249, 88, 155);
      public static Color color6 = Color.FromArgb(24, 161, 251);
    }
    private void ActivateButton(object senderBtn, Color color)
    {
      if (senderBtn != null)
      {
        DisableButton();
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(37, 36, 81);
        currentBtn.ForeColor = color;
        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        currentBtn.IconColor = color;
        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        currentBtn.ImageAlign = ContentAlignment.MiddleRight;

        //Left border button
        leftBorderBtn.BackColor = color;
        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        leftBorderBtn.Visible = true;
        leftBorderBtn.BringToFront();

        //Icon Current Child Form
        iconCurrentChildForm.IconChar = currentBtn.IconChar;
        iconCurrentChildForm.IconColor = color;
        lblTitleChildForm.Text = currentBtn.Text;
      }
    }

    private void DisableButton()
    {
      if (currentBtn != null)
      {
        currentBtn.BackColor = Color.White;
        currentBtn.ForeColor = Color.Black;
        currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        currentBtn.IconColor = Color.Black;
        currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

      }
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
      panelDesktop.Controls.Add(childForm);
      panelDesktop.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();

    }

    private void bntTransacciones_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color1);
      OpenChildForm(new Transactions());
    }

    private void btnCuotas_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color2);
      OpenChildForm(new FinancialFee());
    }

    private void btnPuntos_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color3);
      OpenChildForm(new Points());
    }

    private void btnTrans_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color4);
      OpenChildForm(new Administrative());
    }

    private void btnTecnico_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color5);
      OpenChildForm(new LoginTechnical(1));
    }

    private void btnUsuarios_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new LoginTechnical(2));
            
        }

    private void rjCircularPictureBox2_Click(object sender, EventArgs e)
    {
      currentChildForm.Close();
      Reset();
    }

    private void Reset()
    {
      DisableButton();
      leftBorderBtn.Visible = false;
      iconCurrentChildForm.IconChar = IconChar.Home;
      iconCurrentChildForm.IconColor = Color.White;
      lblTitleChildForm.Text = "Inicio";
    }


    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void iconPictureBox1_Click(object sender, EventArgs e)
    {
      Application.Exit();

    }

    private void iconPictureBox2_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
      {
        WindowState = FormWindowState.Maximized;
      }
      else
      {
        WindowState = FormWindowState.Normal;
      }
    }

    private void iconPictureBox3_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }


  }
}
