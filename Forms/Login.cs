using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.Database.Entity;
using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.Utilities;
using CashRegister.Libraries.VPOS;
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
      txtUser.BackColor = Color.White;
      panel3.BackColor = Color.White;
      panel4.BackColor = SystemColors.Control;
      txtPass.BackColor = SystemColors.Control;
      iconPictureBox2.BackColor = SystemColors.Control;
    }

    private void textBox2_Click(object sender, EventArgs e)
    {
      txtPass.BackColor = Color.White;
      panel4.BackColor = Color.White;
      iconPictureBox2.BackColor = Color.White;
      txtUser.BackColor = SystemColors.Control;
      panel3.BackColor = SystemColors.Control;

    }

    private void iconPictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
      txtPass.UseSystemPasswordChar = false;
    }

    private void iconPictureBox2_MouseUp(object sender, MouseEventArgs e)
    {
      txtPass.UseSystemPasswordChar = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {


      string login = txtUser.Text.Trim();
      string password = txtPass.Text.Trim();
      
      try
      {

        //Admin, Admin
        UsersCore usr = new UsersCore();
        string hash = Utils.GetSHA512(password);
        DataContractUsers user = usr.GetCheckUser(login, hash);

        //RegisterSession(user);
        //SetGlobalInformationWebApp(user);
        this.Hide();

        var das = new Dashboard();
        das.Show();

      }
      //catch (UserExpiredCredentialException Ex)
      //{
      //  Session["login_change_credential"] = login;
      //  resultAjax.Code = "1";
      //  resultAjax.Message = Ex.Message;
      //  resultAjax.Url = Url.Action("Change", "Security");
      //}
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message,"VPOS");
        //resultAjax.Code = "1";
        //resultAjax.Message = Ex.Message;
      }

    }
    private void SetGlobalInformationWebApp(DataContractUsers user)
    {
      CashRegisterCore cashRegisterCore = new CashRegisterCore();
      DataContractCashRegisterCompany CompanyOwner = cashRegisterCore.GetCashRegisterOwnerCompany();
      UserInfo userInfo = new UserInfo();
      userInfo.user_id = user.user_id;
      userInfo.name = user.nickname;

      GlobalInformation.Instance.userInfo = userInfo;
      GlobalInformation.Instance.CompanyAddress = CompanyOwner.address;
      GlobalInformation.Instance.CompanyName = CompanyOwner.name;
      GlobalInformation.Instance.CompanyPhone = CompanyOwner.phone;
      GlobalInformation.Instance.WebPage = CompanyOwner.web_page;
      List<DataTable> lstDataTables = cashRegisterCore.GetTablesBasicInformation();
      GlobalInformation.Instance.dtCategory = lstDataTables.Find(x => x.TableName == "category");
      GlobalInformation.Instance.dtMeasure = lstDataTables.Find(x => x.TableName == "measure");
      GlobalInformation.Instance.dtParameters = lstDataTables.Find(x => x.TableName == "parameters");
      GlobalInformation.Instance.dtState = lstDataTables.Find(x => x.TableName == "states");
      GlobalInformation.Instance.dtTaxes = lstDataTables.Find(x => x.TableName == "taxes");
      GlobalInformation.Instance.dtPaymentsType = lstDataTables.Find(x => x.TableName == "payment_types");
      GlobalInformation.Instance.SysCountryApplication = (SYS_COUNTRY_APPLICATION)GlobalInformation.Instance.GetParameterIntegerValue(PA_PARAMETERS.SYS_PROGRAM_COUNTRY.ToString());

      GlobalInformation.Instance.ListCurrency = VPOSCore.GetAllCurrency(GlobalInformation.Instance.GetParameterValue(PA_PARAMETERS.LIST_CURRENCIES.ToString()));
      GlobalInformation.Instance.ListAcquirer = VPOSCore.GetAllAcquirer(GlobalInformation.Instance.GetParameterValue(PA_PARAMETERS.LIST_ACQUIRER.ToString()));
    }

  }
}
