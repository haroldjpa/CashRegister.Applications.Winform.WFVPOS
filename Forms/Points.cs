using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.Database.Entity;
using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.MessageResource;
using CashRegister.Libraries.Transaction;
using CashRegister.Libraries.Utilities;
using CashRegister.Libraries.VPOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister.Applications.Winform.WFVPos.Forms
{
  public partial class Points : Form
  {
    static AcquirerInfo acquirerInfoSelected;
    static VPOSstructParams paymentParamsToPrint;
    static bool AutoPrint = true;
    static string glvApproval = "";
    static string PointsAction = "2";
    public Points()
    {
      this.DoubleBuffered = true;
      paymentParamsToPrint = null;
      InitializeComponent();
      SetViewBagData();
    }

    private void SetViewBagData()
    {
      //TODO: Crear un metodo para este fin en las demas vistas y/o darle una mejor implementacion
      acquirerInfoSelected = new AcquirerInfo();
      if (SYS_COUNTRY_APPLICATION.Nicaragua_Lafise != GlobalInformation.Instance.SysCountryApplication)
      {
        this.web_impuesto15.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString());
        this.lblTax1.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString());
        this.web_impuesto18.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString());
        this.lblTax2.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString());
        this.web_propina.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString());
        this.lblTip.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString());
      }

      else
      {
        this.web_impuesto15.Visible = this.web_impuesto18.Visible = this.web_propina.Visible = false;
        this.lblTax1.Visible = this.lblTax2.Visible = this.lblTip.Visible = false;
      }

      this.web_fecha_expiracion.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_EXP_DATE_FIELD.ToString());
      this.lblExpirationDate.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_EXP_DATE_FIELD.ToString());
      this.web_ultimos4.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_LAST_4_FIELD.ToString());
      this.lblLast4.Visible = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_LAST_4_FIELD.ToString());
      this.print_commerce.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_COMMERCE.ToString());
      this.print_copy.Checked = GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.ALWAYS_CHECKED_PRINT_CUSTOM.ToString());

      this.enviar.Text = "Enviar";
      //this.enviarCtls.Text = "Enviar CTLS";
      this.limpiar.Text = "Limpiar";
      this.closeTran.Text = "Cerrar";
      this.lblTitle.Text = "Puntos";
      this.lblSubTotal.Text = "Importe Base";
      this.lblTip.Text = "Propina";
      this.lblExpirationDate.Text = "Fecha de Expiración";
      this.lblTotal.Text = "Puntos";
      this.lblTitleResult.Text = "Resultado";
      this.lblTitleResultTX.Text = "Resultado Transacción";
      this.lblApprovalNum.Text = "Código Aprobación:";
      //ViewBag.ButtonCaptionPrint = "Imprimir Voucher";
      this.print_copy.Text = "Cliente";
      this.print_commerce.Text = "Comercio";

      if (SYS_COUNTRY_APPLICATION.Belice_Atlantida == GlobalInformation.Instance.SysCountryApplication)
      {//Belice
        this.lblTax1.Text = "Impuesto 15%";
        this.lblTax2.Text = "Impuesto 18%";
        this.lblLast4.Text = "Últimos 4 de la tarjeta";

      }

      else if (SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
      {//Honduras
       //ViewBag.DiscountFunction = false;//true;
        this.lblTax1.Text = "Impuesto";
        this.lblTax2.Text = "Otros Impuestos";
        this.lblLast4.Text = "Últimos 4 de la tarjeta";

        this.web_impuesto15.Visible = this.web_impuesto18.Visible = this.web_propina.Visible = false;
        this.lblTax1.Visible = this.lblTax2.Visible = this.lblTip.Visible = false;

        this.lblSubTotal.Text = "Puntos";
        this.lblLast4.Text = "Últimos 4 de la tarjeta";
        this.lblMerchantName.Text = "Nombre";
        this.lblTerminalId.Text = "Terminal ID";
        this.lblMerchantId.Text = "Merchant ID";
        this.lblCommerce.Text = "Puntos";
        this.print_copy.Text = "Cliente";

        FillAdquirerList(0);
        //AcquirerInfo[] ArrayAcquirer = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        //int IndexAc = 0;
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //    ArrayAcquirer[IndexAc++] = item.Value;
        //}
        //if (ArrayAcquirer.Length > 1)
        //{
        //    //Dolar index 1
        //    acquirerInfo.name = ArrayAcquirer[0].name;
        //    acquirerInfo.MerchantID = ArrayAcquirer[0].MerchantID;
        //    acquirerInfo.TerminalID = ArrayAcquirer[0].TerminalID;
        //    acquirerInfo.id = ArrayAcquirer[0].id;
        //    acquirerInfo.ListCuotas = ArrayAcquirer[0].ListCuotas;
        //    acquirerInfo.CurrencyID = ArrayAcquirer[0].CurrencyID;

        //    ViewBag.MerchantId = ArrayAcquirer[0].MerchantID;
        //    ViewBag.TerminalId = ArrayAcquirer[0].TerminalID;
        //    ViewBag.MerchantName = ArrayAcquirer[0].name;
        //}
        //string[] ArrayAccion = "Canje de Puntos_Consulta de Puntos".Split('_');
        //ViewBag.lstCommerces = ArrayAccion;

      }

      else if (SYS_COUNTRY_APPLICATION.Honduras_Banrural == GlobalInformation.Instance.SysCountryApplication ||
  GlobalInformation.Instance.SysCountryApplication == SYS_COUNTRY_APPLICATION.Honduras_Atlantida)
      {
        //thi.DiscountFunction = false;//true;
        this.lblTax1.Text = "Impuesto";
        this.lblTax2.Text = "Otros Impuestos";
        this.lblLast4.Text = "Últimos 4 de la tarjeta";

      }


      else if (SYS_COUNTRY_APPLICATION.Nicaragua_Lafise == GlobalInformation.Instance.SysCountryApplication)
      {

        //ViewBag.DiscountFunction = false;//true;
        this.lblTax1.Text = "Impuesto";
        this.lblTax2.Text = "Otros Impuestos";
        this.lblLast4.Text = "Número de tarjeta";
        this.lblMerchantName.Text = "Nombre";
        this.lblTerminalId.Text = "Terminal ID";
        this.lblMerchantId.Text = "Merchant ID";
        this.lblCommerce.Text = "Comercio";

        FillAdquirerList(0);
        //ViewBag.lblSelectOption = "Seleccione un comercio";
        //AcquirerInfo[] ArrayAcquirer = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        //int IndexAc = 0;
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //    ArrayAcquirer[IndexAc++] = item.Value;
        //}

        //ViewBag.lstCommerces = ArrayAcquirer;

        //ViewBag.MerchantName ;
        //ViewBag.TerminalId;
        //ViewBag.MerchantId;
      }


      else if (SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
      {
        this.web_impuesto15.Visible = this.web_impuesto18.Visible = this.web_propina.Visible = false;
        this.lblTax1.Visible = this.lblTax2.Visible = this.lblTip.Visible = false;
        this.lblSubTotal.Text = "Puntos";
        this.lblLast4.Text = "Últimos 4 de la tarjeta";
        this.lblMerchantName.Text = "Nombre";
        this.lblTerminalId.Text = "Terminal ID";
        this.lblMerchantId.Text = "Merchant ID";
        this.lblCommerce.Text = "Puntos";
        //ViewBag.lblSelectOption = "Seleccione una acción";
        this.print_copy.Text = "Cliente";

        FillAdquirerList(1);

        //AcquirerInfo[] ArrayAcquirer = new AcquirerInfo[GlobalInformation.Instance.ListAcquirer.Count];
        //int IndexAc = 0;
        //foreach (var item in GlobalInformation.Instance.ListAcquirer)
        //{
        //    ArrayAcquirer[IndexAc++] = item.Value;
        //}
        //if (ArrayAcquirer.Length > 1)
        //{
        //    //Dolar index 1
        //    acquirerInfo.name = ArrayAcquirer[1].name;
        //    acquirerInfo.MerchantID = ArrayAcquirer[1].MerchantID;
        //    acquirerInfo.TerminalID = ArrayAcquirer[1].TerminalID;
        //    acquirerInfo.id = ArrayAcquirer[1].id;
        //    acquirerInfo.ListCuotas = ArrayAcquirer[1].ListCuotas;
        //    acquirerInfo.CurrencyID = ArrayAcquirer[1].CurrencyID;

        //    ViewBag.MerchantId = ArrayAcquirer[1].MerchantID;
        //    ViewBag.TerminalId = ArrayAcquirer[1].TerminalID;
        //    ViewBag.MerchantName = ArrayAcquirer[1].name;
        //}
        //string[] ArrayAccion = "Canje de Puntos_Consulta de Puntos".Split('_');
        //ViewBag.lstCommerces = ArrayAccion;

      }


    }

    private static object _sync = new object();

    private void enviar_Click(object sender, EventArgs e)
    {
      if ((SYS_COUNTRY_APPLICATION.Nicaragua_Lafise != GlobalInformation.Instance.SysCountryApplication) &&
          (SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa != GlobalInformation.Instance.SysCountryApplication) &&
          (SYS_COUNTRY_APPLICATION.Nicaragua_Lafise != GlobalInformation.Instance.SysCountryApplication))
      {
        realizarOperacion(5);
      }
      else
      {
        realizarOperacion(7);
      }

    }


    private void realizarOperacion(int tipoOperacion)
    {
      if (!IsCorrectTextboxInformation())
      {
        return;
      }

      lock (_sync)
      {
        DisableWidgets();
        bool OnlyTrack2 = false;
        string ResponseVPOSCode = string.Empty;
        try
        {
          VPOSstructParams paymentParams = new VPOSstructParams();
          paymentParamsToPrint = null;
          paymentParams.SysCountryApplication = GlobalInformation.Instance.SysCountryApplication;
          paymentParams.ClientLocalIP = "localhost";
          paymentParams.Last4 = web_ultimos4.Text;
          paymentParams.ExpDate = web_fecha_expiracion.Text;
          paymentParams.Currency = GetCurrency("moneda");
          paymentParams.Tip = Utils.GetValueWithoutPoint(web_propina.Text, false);
          paymentParams.Tax1 = Utils.GetValueWithoutPoint(web_impuesto15.Text, false);
          paymentParams.Tax2 = Utils.GetValueWithoutPoint(web_impuesto18.Text, false);
          paymentParams.SubTotal = Utils.GetValueWithoutPoint(web_importe_base.Text, false);
          paymentParams.Amount = Utils.GetValueWithoutPoint(web_total_transaccion.Text, false);
          paymentParams.PayEntryMode = ((PA_PAYMENT_ENTRY_MODE)Convert.ToInt32(tipoOperacion)).ToString();
          paymentParams.VPOSTxType = VPOSTransactionType.TxSale;
          paymentParams.ClientLocalIP = "localhost";
          paymentParams.VPOSTxSubType = VPOSTransactionSubType.TxPoints;
          paymentParams.TxInternalSubType = PointsAction;
          paymentParams.VPOSNonIntegred = "yes";

          paymentParams.PrintCopy = (print_copy.Checked ? "1" : "2");  //1-Yes copy  2-No copy
          paymentParams.PrintCommerce = (print_commerce.Checked ? "1" : "2");  //1-Yes copy  2-No copy

          //TODO: Refactorizar estas validaciones a clases polimorficas
          if (SYS_COUNTRY_APPLICATION.Nicaragua_Lafise == GlobalInformation.Instance.SysCountryApplication)
            paymentParams.AcquireId = acquirerInfoSelected.id;
          else if (SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
          {
            paymentParams.AcquireId = "2"; //GlobalInformation.Instance.ListAcquirer;
            paymentParams.Currency = "2";//GetCurrency(param["moneda"]);
            if (paymentParams.Amount.Equals("000") && !paymentParams.SubTotal.Equals("000"))
            {
              paymentParams.Amount = paymentParams.SubTotal;
            }
          }

          //TODO: SE CREO UNICAMENTE PARA EVALUER UNA PRUEBA, BORRAR O Crear un checkbox que indique que solo se pretende leer el track 2
          else if (SYS_COUNTRY_APPLICATION.Belice_Atlantida == GlobalInformation.Instance.SysCountryApplication)
          {
            paymentParams.AcquireId = "100";
            OnlyTrack2 = true;
          }
          else if (SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication)
            paymentParams.AcquireId = "2"; //GlobalInformation.Instance.ListAcquirer;


          VPOSCommunication VPOSComm = new VPOSCommunication(paymentParams);
          VPOSstructParams paymentResponse = VPOSComm.PerformVPOSTransaction();
          ResponseVPOSCode = paymentResponse.authNum;
          CoreMessage.GetErrorVposMessage(paymentResponse.authNum);

          if ((SYS_COUNTRY_APPLICATION.Honduras_Ficohsa == GlobalInformation.Instance.SysCountryApplication) ||
SYS_COUNTRY_APPLICATION.Honduras_Banrural == GlobalInformation.Instance.SysCountryApplication ||
SYS_COUNTRY_APPLICATION.Honduras_Atlantida == GlobalInformation.Instance.SysCountryApplication)
          {
            paymentParams.Amount = (Convert.ToInt32(paymentParams.Amount) - (Convert.ToInt32(paymentParams.Tax1) - Convert.ToInt32(paymentParams.Discount))).ToString();
            paymentParams.Discount = string.Format("-{0}", Convert.ToInt32(paymentParams.Tax1) - Convert.ToInt32(paymentParams.Discount));
          }

          paymentParamsToPrint = new VPOSstructParams();
          paymentParamsToPrint = paymentParams;

          if (!OnlyTrack2)
            SaveTransactionSale(paymentParams);

          //NO ENTIENDO PORQUE ESTA COMENTARIADO EN TRANSACTIONS.CS

          //FinantialDataToView finantialDataToView = new FinantialDataToView();

          //finantialDataToView.AccountNumber = paymentParams.AccountNumber;
          //finantialDataToView.authNum = paymentParams.authNum;
          //finantialDataToView.Brand = paymentParams.Brand;
          //finantialDataToView.CardHolderName = paymentParams.CardHolderName;
          //finantialDataToView.numReceipt = paymentParams.numReceipt;
          //resultAjax.Code = "0";

          //resultAjax.JsonData = Utils.ToJson(finantialDataToView);

          codigoAprobacion.Text = paymentParams.authNum;

          if (SYS_COUNTRY_APPLICATION.Belice_Atlantida == GlobalInformation.Instance.SysCountryApplication && OnlyTrack2)
            return;
        }
        catch (Exception Ex)
        {
          if (ResponseVPOSCode.Contains("ERR:07") || ResponseVPOSCode.Contains("ERR:98"))
            //resultAjax.Code = "2";
            MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          else
            //resultAjax.Code = "1";
            MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

          //resultAjax.Message = Ex.Message;

        }
        finally
        {
          EnableWidgets();
        }
      }
    }


    private string SaveTransactionSale(VPOSstructParams paymentParams)
    {
      ItemsCore itemsCore = new ItemsCore();
      TransactionInformation transactionInformation = new TransactionInformation(true, GlobalInformation.Instance.userInfo.user_id);
      PaymentCore paymentCore = new PaymentCore();

      DataContractItems dataContractItem = itemsCore.GetItemByCode("-2");
      dataContractItem.price = Convert.ToDecimal(paymentParams.Amount) / 100;
      glvApproval = paymentParams.authNum;
      transactionInformation.payment.approval = paymentParams.authNum;
      transactionInformation.payment.card_brand = paymentParams.Brand;
      transactionInformation.payment.value = Convert.ToDecimal(paymentParams.Amount) / 100;
      transactionInformation.payment.receipt_number = paymentParams.numReceipt;
      transactionInformation.payment.number = paymentParams.AccountNumber;
      transactionInformation.payment.aid = paymentParams.AID;
      transactionInformation.payment.tvr = paymentParams.TVR;
      transactionInformation.payment.arqc = paymentParams.ARQC;
      transactionInformation.payment.tc = paymentParams.TC;
      transactionInformation.payment.tsi = paymentParams.TSI;
      transactionInformation.payment.na = paymentParams.NA;
      transactionInformation.payment.terminal_id = paymentParams.TerminalId;
      transactionInformation.payment.acquire_id = paymentParams.AcquireId;
      transactionInformation.payment.pay_entry_mode = paymentParams.PayEntryMode;
      transactionInformation.payment.cardholder = paymentParams.CardHolderName;
      transactionInformation.payment.lot = paymentParams.Lot;
      transactionInformation.payment.reference = paymentParams.Reference;
      transactionInformation.payment.charge = paymentParams.Charge;
      transactionInformation.payment.tax1 = Convert.ToDecimal(paymentParams.Tax1) / 100;
      transactionInformation.payment.tax2 = Convert.ToDecimal(paymentParams.Tax2) / 100;
      transactionInformation.payment.discount = Convert.ToDecimal(paymentParams.Discount) / 100;
      transactionInformation.payment.tip = Convert.ToDecimal(paymentParams.Tip) / 100;
      transactionInformation.payment.base_amount = Convert.ToDecimal(paymentParams.SubTotal) / 100;

      CurrencyInfo curInfo = new CurrencyInfo();
      //TODO: Poder seleccionar la moneda desde la pantalla de venta para la no integrada
      GlobalInformation.Instance.ListCurrency.TryGetValue(paymentParams.Currency, out curInfo);
      transactionInformation.payment.currency = curInfo.name;
      transactionInformation.payment.currency_symbol = curInfo.symbol;
      //TODO: Saber si es una tarjeta credito o debito
      transactionInformation.payment.invoice_payment_type_id = (int)ButtonPayArray.btnPayCreditCard;
      transactionInformation.AddItem(dataContractItem, 1); // -2 From table ps_item Sale with nonintegrate system

      transactionInformation.CreateListItemsToArray();
      return paymentCore.PostTransactionSale(transactionInformation.GetInvoiceTransaction());

    }


    private void DisableWidgets()
    {
      pnlMain.Enabled = false;
      closeTran.Enabled = false;


    }

    private void EnableWidgets()
    {
      pnlMain.Enabled = true;
      closeTran.Enabled = true;
    }

    private bool IsCorrectTextboxInformation()
    {
      if (commerces.Text == "")
      {
        MessageBox.Show("Debe Seleccionar cuotas", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        commerces.Focus();
        return false;
      }
      if (web_importe_base.Text == "")
      {
        MessageBox.Show("Debe indicar un monto", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_importe_base.Focus();
        return false;
      }
      if (web_impuesto15.Visible && web_impuesto15.Text == "")
      {
        MessageBox.Show("Debe indicar un monto de impuesto", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_impuesto15.Focus();
        return false;
      }
      if (web_impuesto18.Visible && web_impuesto18.Text == "")
      {
        MessageBox.Show("Debe indicar un monto de impuesto", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_impuesto18.Focus();
        return false;
      }
      if (web_propina.Visible && web_propina.Text == "")
      {
        MessageBox.Show("Debe indicar un monto de propina", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_propina.Focus();
        return false;
      }

      if (web_ultimos4.Visible && web_ultimos4.Text == "")
      {
        MessageBox.Show("Debe indicar los 4 ultimos dígitos de la tarjeta", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_ultimos4.Focus();
        return false;
      }
      if (web_fecha_expiracion.Visible && web_fecha_expiracion.Text == "")
      {
        MessageBox.Show("Debe indicar la fecha de expiracion MMYY de la tarjeta", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        web_fecha_expiracion.Focus();
        return false;
      }

      return true;
    }

    void FillAdquirerList(int indice)
    {
      int comboListCount = 0;
      foreach (var item in GlobalInformation.Instance.ListAcquirer)
      {
        if (comboListCount == indice)
        {
          this.merchant_id.Text = item.Value.MerchantID;
          this.terminal_id.Text = item.Value.TerminalID;
          this.merchant_name.Text = item.Value.name;
          string[] ArrayPuntos = "Canje de Puntos_Consulta de Puntos".Split('_');
          foreach (string a in ArrayPuntos)
          {
            this.commerces.Items.Add(a);

          }

        }
        comboListCount++;
      }


      //Si solo hay un adquirente se selecciona por defecto automaticamente
      if (comboListCount == 1)
      {
        this.commerces.SelectedIndex = 0;
        this.commerces.Enabled = false;

      }
      else if (comboListCount == 0)
        this.commerces.Enabled = false;
      else
        this.commerces.Enabled = true;


    }

    private void commerces_SelectedValueChanged(object sender, EventArgs e)
    {
      string datos = this.commerces.Text;
      if (datos.Contains("Consulta"))
      {
        web_importe_base.Enabled = false;
        PointsAction = Convert.ToInt32(VPOSPointsTransactionSubType.TxBalance).ToString();
      }
      else
      {
        web_importe_base.Enabled = true;
        PointsAction = Convert.ToInt32(VPOSPointsTransactionSubType.TxRedemtion).ToString();

      }
    }

    private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
    {
      char DecimalPoint = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

      if (e.KeyChar == '.' || e.KeyChar == ',')
      {
        e.KeyChar = DecimalPoint;
      }

      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != DecimalPoint))
      {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == DecimalPoint) && ((sender as TextBox).Text.IndexOf(DecimalPoint) > -1))
      {
        e.Handled = true;
      }
    }

    private void txtNumericOnly_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }


    private void web_importe_base_Leave(object sender, EventArgs e)
    {
      if (ValidateCurrency(sender, ((TextBox)sender).Text))
      {
        double SumTotal = Convert.ToDouble((web_importe_base.Text == "" ? "0.00" : web_importe_base.Text)) +
        Convert.ToDouble((web_impuesto15.Text == "" ? "0.00" : web_impuesto15.Text)) +
        Convert.ToDouble((web_impuesto18.Text == "" ? "0.00" : web_impuesto18.Text)) +
        Convert.ToDouble((web_propina.Text == "" ? "0.00" : web_propina.Text));
        web_total_transaccion.Text = string.Format("{0:N2}", SumTotal);

      }

      //double TotalField =  Convert.ToDouble(sender.Text) ;
    }

    private bool ValidateCurrency(object sender, string value)
    {
      double dummy;
      bool valid = double.TryParse(value, NumberStyles.Currency, CultureInfo.CurrentCulture, out dummy);

      return valid;

    }

    private void limpiar_Click(object sender, EventArgs e)
    {
      commerces.Text = string.Empty;
      web_importe_base.Text = string.Empty;
      web_impuesto15.Text = string.Empty;
      web_impuesto18.Text = string.Empty;
      web_propina.Text = string.Empty;
      web_ultimos4.Text = string.Empty;
      web_fecha_expiracion.Text = string.Empty;
      codigoAprobacion.Text = string.Empty;
      web_total_transaccion.Text = "0.00";
      merchant_name.Text = string.Empty;
      merchant_id.Text = string.Empty;
      terminal_id.Text = string.Empty;

      FillAdquirerList(0);

    }
    private void closeTran_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private string GetCurrency(string moneda)
    {
      //TODO: parametro moneda debe venir de seleccionar en la vista el listado de monedas
      if ((SYS_COUNTRY_APPLICATION.Nicaragua_Lafise == GlobalInformation.Instance.SysCountryApplication ||
        SYS_COUNTRY_APPLICATION.Nicaragua_Ficohsa == GlobalInformation.Instance.SysCountryApplication) &&
        GlobalInformation.Instance.ListAcquirer.Count > 1)
      {
        if (acquirerInfoSelected.CurrencyID == "" || acquirerInfoSelected.CurrencyID == null)
          throw new Exception("Por favor, Seleccione un adquirente");
        return acquirerInfoSelected.CurrencyID;
      }
      else
      {
        return "1";
      }
    }

  }
}
