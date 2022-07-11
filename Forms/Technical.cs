using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.MessageResource;
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
  public partial class Technical : Form
  {
    public Technical()
    {
      InitializeComponent();
      SetViewBagData();
    }

    private void closeTechnicalView_Click(object sender, EventArgs e)
    {
      this.Close();
    }



    private void SetViewBagData()
    {

      this.Title.Text = "Técnico";
      this.getInitialization.Text = "Inicializar";
      this.getInformation.Text = "Información";
      this.lblPass.Text = "Contraseña";
      this.lblVersion.Text = "Version App:";
      this.lblSerial.Text = "Serial:";
      this.lblTerminalID.Text = "TerminalID:";
      this.lblInformation.Text = "Información de Terminal";
      this.lblInformationTitle.Text = "Información";
      this.lblInitializationTitle.Text = "Inicialización";
      this.lblCurrency.Text = "Monedas:";
      this.lblTitleConfigVisibleFields.Text = "Visualización de campos";
      this.chkLast4.Text = "Últimos cuatro dígitos de la tarjeta";
      this.chkExpirationDate.Text = "Fecha de expiración de la tarjeta";
      this.chkTip.Text = "Propina";
      this.chkCuotas.Text = "Mostrar cuotas";
      this.chkPuntos.Text = "Mostrar puntos";
      this.chkAlwaysCheckedPrintCustom.Text = "Activo ticket cliente";
      this.chkAlwaysCheckedPrintCommerce.Text = "Activo ticket comercio";
      this.chkAllowSesionExpired.Text = "Expirar Sesión";
      this.lblCommerces.Text = "Adquirentes disponibles para Venta Retail";
      this.chkAutoPrintSaleTicket.Text = "Imprimir ticket venta automaticamente";
      this.placeConfiguration.Text = "Tomar configuración";
      this.btnClose.Text = "Cerrar";


      this.chkLast4.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_LAST_4_FIELD.ToString());
      this.chkExpirationDate.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_EXP_DATE_FIELD.ToString());
      this.chkTip.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString());
      this.chkTax1.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString());
      this.chkTax2.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString());
      this.chkAlwaysCheckedPrintCommerce.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_COMMERCE.ToString());
      this.chkAlwaysCheckedPrintCustom.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_CUSTOM.ToString());
      this.chkAllowSesionExpired.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.ALLOW_SESION_EXPIRED.ToString());

      this.chkCuotas.Checked = false;
      this.chkPuntos.Checked = false;

      //TODO: Evaluar siguiente linea
      this.chkDiscount.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_DISCOUNT_FIELD.ToString());
      this.chkAutoPrintSaleTicket.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.AUTO_PRINT_SALE_TICKET.ToString());


      if (SYS_COUNTRY_APPLICATION.Belice_Atlantida == GlobalInformation.Instance.SysCountryApplication)
      {//Belice
        this.chkTax1.Text = "Impuesto 15%";
        this.chkTax2.Text = "Impuesto 18%";

        //this.DiscountFunction = false;
        this.chkDiscount.Visible = false;

      }
      else if (SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
      {//Honduras
        this.chkTax1.Text = "Impuesto";
        this.chkTax2.Text = "Otros impuestos";
        this.chkDiscount.Text = "Descuento";
        this.chkCuotas.Text = "Mostrar plan de pagos";
        this.chkCuotas.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString());
        this.chkPuntos.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString());
        TechnicalInformation technicalInformation = new TechnicalInformation();
        technicalInformation.ArrayAcquirerInfo = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        int IndexAc = 0;

        FillAdquirerList();
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //  item.Value.AliasName = "Acquirer" + item.Value.id;
        //  technicalInformation.ArrayAcquirerInfo[IndexAc++] = item.Value;
        //  this.chkLstlstAcquires.Items.Add(item.Value.name, item.Value.IsSaleVisible);
        //}

        

        // En todas las apariciones de esta configuracion para descuento, se dejó que siempre este activa para
        //la impresion pero no visible en las pantallas web, 
        //TODO: Eliminar donde este codigo fue establecido por hardcode para eliminarlo. 
        //Para Honduras (Ficosa, Banrural) debe aparecer en la impresion y no en la web
        this.chkDiscount.Visible = false;//true;
      }
      else if (SYS_COUNTRY_APPLICATION.Honduras_Banrural == GlobalInformation.Instance.SysCountryApplication ||
        SYS_COUNTRY_APPLICATION.Honduras_Atlantida == GlobalInformation.Instance.SysCountryApplication)
      {//Honduras
        this.chkTax1.Text = "Impuesto";
        this.chkTax2.Text = "Otros impuestos";
        this.chkDiscount.Text = "Descuento";

        this.chkDiscount.Visible = false;//true;
      }
      else if (SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
      {//Nicaragua
        this.chkTip.Checked = false;//GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString());
        this.chkTax1.Checked = false;//GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString());
        this.chkTax2.Checked = false;//GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString());
        this.chkCuotas.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString());
        this.chkPuntos.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString());
        this.chkTax1.Text = "Impuesto";
        this.chkTax2.Text = "Otros impuestos";
        this.chkDiscount.Text = "Descuento";

        this.chkDiscount.Visible = false;

        TechnicalInformation technicalInformation = new TechnicalInformation();
        technicalInformation.ArrayAcquirerInfo = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        int IndexAc = 0;

        FillAdquirerList();
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //  item.Value.AliasName = "Acquirer" + item.Value.id;
        //  technicalInformation.ArrayAcquirerInfo[IndexAc++] = item.Value;
        //  this.chkLstlstAcquires.Items.Add(item.Value.name, item.Value.IsSaleVisible);
        //}

        

      }
      else if (SYS_COUNTRY_APPLICATION.Nicaragua_Lafise == GlobalInformation.Instance.SysCountryApplication)
      {//Nicaragua
        this.chkTax1.Text = "Impuesto";
        this.chkTax2.Text = "Otros impuestos";
        this.chkDiscount.Text = "Descuento";
        this.chkLast4.Text = "Número de la tarjeta";
        this.chkDiscount.Visible = false;

        FillAdquirerList();

        //AcquirerInfo[] ArrayAcquirer = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        //int IndexAc = 0;
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //  ArrayAcquirer[IndexAc++] = item.Value;
        //  this.chkLstlstAcquires.Items.Add(item.Value.name, item.Value.IsSaleVisible);
        //}

      }


      FillCurrencyList();

    }

    private void placeConfiguration_Click(object sender, EventArgs e)
    {
      try
      {

        CashRegisterCore cashRegisterCore = new CashRegisterCore();

        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_EXP_DATE_FIELD.ToString(), chkExpirationDate.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_LAST_4_FIELD.ToString(), chkLast4.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString(), chkTax1.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString(), chkTax2.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString(), chkCuotas.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString(), chkPuntos.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_COMMERCE.ToString(), chkAlwaysCheckedPrintCommerce.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_CUSTOM.ToString(),  chkAlwaysCheckedPrintCustom.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.ALLOW_SESION_EXPIRED.ToString(),  chkAllowSesionExpired.Checked);



        //TODO: Eliminar si no hace falta la siguiente linea, el descuento no debe funcionar como caja de texto en la ventana de venta
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_DISCOUNT_FIELD.ToString(), true);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString(),  chkTip.Checked);
        cashRegisterCore.SetCashParameterBooleanValue(PA_PARAMETERS.AUTO_PRINT_SALE_TICKET.ToString(),  chkAutoPrintSaleTicket.Checked);

        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_EXP_DATE_FIELD.ToString(),  chkExpirationDate.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_LAST_4_FIELD.ToString(),  chkLast4.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString(),  chkTax1.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString(),  chkTax2.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString(),  chkCuotas.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString(),  chkPuntos.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_CUOTAS.ToString(),  chkCuotas.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_PUNTOS.ToString(),  chkPuntos.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_COMMERCE.ToString(),  chkAlwaysCheckedPrintCommerce.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_CUSTOM.ToString(),  chkAlwaysCheckedPrintCustom.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.ALLOW_SESION_EXPIRED.ToString(),  chkAllowSesionExpired.Checked);

        //TODO: Eliminar si no hace falta la siguiente linea, el descuento no debe funcionar como caja de texto en la ventana de venta
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_DISCOUNT_FIELD.ToString(), true);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString(),  chkTip.Checked);
        GlobalInformation.Instance.SetParameterBooleanValue(PA_PARAMETERS.AUTO_PRINT_SALE_TICKET.ToString(),  chkAutoPrintSaleTicket.Checked);

        SaveVisibleAcquirerSale();


        MessageBox.Show("Configuracion guardada","VPOS Control",MessageBoxButtons.OK,MessageBoxIcon.Information);


      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message + "  [" + Ex.Source + "][" + Ex.StackTrace + "][" + Ex.TargetSite + "]", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
    }

    private void SaveVisibleAcquirerSale()
    {

      for (int i = 1; i <= GlobalInformation.Instance.ListAcquirer.Count; i++)
      {
        GlobalInformation.Instance.ListAcquirer[i.ToString()].IsSaleVisible = chkLstlstAcquires.GetItemCheckState(i-1)== CheckState.Checked  ?true :false ;
      }

      string ListAcquirer = VPOSCore.AllAcquirerToString(GlobalInformation.Instance.ListAcquirer);

      GlobalInformation.Instance.SetParameterValue(PA_PARAMETERS.LIST_ACQUIRER.ToString(), ListAcquirer);
      CashRegisterCore cashRegisterCore = new CashRegisterCore();
      cashRegisterCore.SetCashParameterValue(PA_PARAMETERS.LIST_ACQUIRER.ToString(), ListAcquirer);

    }

    private void getInformation_Click(object sender, EventArgs e)
    {
      try
      {

        VPOSstructParams paymentParams = new VPOSstructParams();
        paymentParams.ClientLocalIP = "localhost";

        paymentParams.VPOSAdmin = web_admin_to_technical.Text;

        paymentParams.VPOSTxType = VPOSTransactionType.TxInfo;

        VPOSCommunication VPOSComm = new VPOSCommunication(paymentParams);
        VPOSstructParams paymentResponse = VPOSComm.PerformVPOSTransaction();
        CoreMessage.GetErrorVposMessage(paymentResponse.claSN);

        FinantialDataToView finantialDataToView = new FinantialDataToView();
        PINpadSerial.Text = paymentParams.claSN;
        PINpadTerminalID.Text = paymentParams.claTID;
        PINpadVersion.Text = paymentParams.claVer;

        
      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message , "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
    }

    private void getInitialization_Click(object sender, EventArgs e)
    {
      try
      {

        VPOSstructParams paymentParams = new VPOSstructParams();
        paymentParams.VPOSAdmin = web_admin_to_technical.Text;
        paymentParams.ClientLocalIP = "localhost";
        paymentParams.VPOSTxType = VPOSTransactionType.TxInitialization;

        VPOSCommunication VPOSComm = new VPOSCommunication(paymentParams);
        VPOSstructParams paymentResponse = VPOSComm.PerformVPOSTransaction();
        CoreMessage.GetErrorVposMessage(paymentResponse.status);

        VPOSCore.ProcessWebInitialization(paymentResponse);

        CashRegisterCore cashRegisterCore = new CashRegisterCore();
        cashRegisterCore.UpdateMerchantInformation(GlobalInformation.Instance.CompanyName, GlobalInformation.Instance.CompanyPhone, GlobalInformation.Instance.CompanyAddress);
        cashRegisterCore.SetCashParameterValue(PA_PARAMETERS.LIST_CURRENCIES.ToString(), paymentResponse.ListCurrency);
        cashRegisterCore.SetCashParameterValue(PA_PARAMETERS.LIST_ACQUIRER.ToString(), paymentResponse.ListAcquirer);


        string hash = Utils.GetSHA512(paymentResponse.Technical_Pass);
        cashRegisterCore.SetCashParameterValue(PA_PARAMETERS.TECHNICAL_PASS.ToString(), hash);
        GlobalInformation.Instance.SetParameterValue(PA_PARAMETERS.TECHNICAL_PASS.ToString(), hash);

        FillAdquirerList();
        FillCurrencyList();
      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    void FillCurrencyList()
    {
      CurrencyInfo[] ArrayCurrency = new CurrencyInfo[GlobalInformation.Instance.ListCurrency.Count];
      int Index = 0;
      foreach (var item in GlobalInformation.Instance.ListCurrency)
      {
        ArrayCurrency[Index++] = item.Value;
        this.lstCurrencies.Items.Add(item.Value.name);
      }
    }

    void FillAdquirerList()
    {
      foreach (var item in GlobalInformation.Instance.ListAcquirer)
      {
        item.Value.AliasName = "Acquirer" + item.Value.id;
        this.chkLstlstAcquires.Items.Add(item.Value.name, item.Value.IsSaleVisible);
      }
    }

  }



}
