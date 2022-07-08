using CashRegister.Libraries.Basic.Database;
using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.Database.Entity;
using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.Utilities;
using CashRegister.Libraries.VPOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CashRegister.Libraries.Basic.Core;
using CashRegister.Libraries.Basic.DataStore;
using CashRegister.Libraries.Database.Interface;
using CashRegister.Libraries.Database.Repository;

namespace CashRegister.Applications.Winform.WFVPos.Forms
{
  public partial class Login : Form
  {
    string DataBaseName = "cashregister";
    public Login()
    {
      StartDBBinding();
      InitializeComponent();
    }

    private void LoadIoContainer()
    {

      IoContainer.Add<IPaymentRepository>(typeof(PaymentRepository));
      IoContainer.Add<IItemRepository>(typeof(ItemRepository));
      IoContainer.Add<IUserRepository>(typeof(UserRepository));
      IoContainer.Add<ICashRegisterRepository>(typeof(CashRegisterRepository));
      IoContainer.Add<IUnitOfWork>(typeof(DbUnitOfWork));
    }
    private void StartDBBinding()
    {
      try
      {
        System.Configuration.ConnectionStringSettings connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"];
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connectionString"];
        DbMultiThreadManager.SetDefaultProvider("Npgsql"
          , @"Server=localhost;Port=5434;Database=" + DataBaseName + "; User Id=postgres;Password=PostekDB; Pooling=true; MinPoolSize=3; MaxPoolSize=50"/*settings.ConnectionString*/);
        LoadIoContainer();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
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

        SetGlobalInformationWebApp(user);
        



      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS");

      }

      this.Hide();
      var das = new Dashboard();
      das.Show();
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
