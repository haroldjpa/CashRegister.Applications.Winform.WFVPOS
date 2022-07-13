using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.Database.Entity;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister.Applications.Winform.WFVPos.Forms
{
  public partial class Administrative : Form
  {

    static VPOSstructParams paymentParamsToPrintVoid;
    static string glvApprovalReport = "";
    static string glvApprovalVoid = "";
    static string glvApprovalSettle = "";

    public Administrative()
    {
      InitializeComponent();
      SetViewBagData();

      //this.glvApprovalVoid = glvApprovalVoid;
      //this.glvApprovalReport = glvApprovalReport;
      //this.glvApprovalSettle = glvApprovalSettle;
    }
    private void EnableWidgets()
    {
      
      btnCloseWindow.Enabled = true;
      btnDuplicate.Enabled = true;
      btnPrintLastDuplicate.Enabled = true  ;
      btnPrintReport.Enabled = true ;
      btnSettle.Enabled = true;
      btnVoid.Enabled = true;

    }


    private void DisableWidgets()
    {
      
      btnCloseWindow.Enabled = false;
      btnDuplicate.Enabled = false;
      btnPrintLastDuplicate.Enabled = false;
      btnPrintReport.Enabled = false;
      btnSettle.Enabled = false;
      btnVoid.Enabled = false;
      Application.DoEvents();

    }
    private void closeTransactionView_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }

    private void SetViewBagData()
    {

      if (GlobalInformation.Instance.SysCountryApplication == SYS_COUNTRY_APPLICATION.Honduras_Ficohsa)
      {

        this.lblResultVoid.Text = "Cargo:";
        //this.lblResultDuplicate.Text = "Cargo:";
      }
      else if (GlobalInformation.Instance.SysCountryApplication == SYS_COUNTRY_APPLICATION.Honduras_Banrural ||
        GlobalInformation.Instance.SysCountryApplication == SYS_COUNTRY_APPLICATION.Honduras_Atlantida)
      {
        this.lblResultVoid.Text = "Factura:";
        //this.lblResultDuplicate.Text = "Factura:";

      }
      else
      {
        this.lblResultVoid.Text = "Número de recibo:";
        //this.lblResultDuplicate = "Número de recibo:";
      }

      this.TitleView.Text = "Administrativo";
      this.tabReport.Text = "Reporte";
      this.tabVoid.Text = "Anulaciones";
      this.tabSettlement.Text = "Cierre";
      this.tabDuplicate.Text = "Duplicado";

      this.lblVoid.Text = "Anular recibo";

      this.lblApprCode.Text = "Código Aprobación:";
      this.lblAdminPassVoid.Text = "Contraseña administrador PINpad";
      this.btnSettle.Text = "Cierre";
      this.btnVoid.Text = "Anular";
      this.btnCloseWindow.Text = "Cerrar";
      //this.ButtonCaptionPrint = "Imprimir Voucher";
      this.btnPrintReport.Text = "Imprimir Reporte";
      this.lblSettle.Text = "Cierre ventas";

      this.btnDuplicate.Text = "Duplicado";
      this.btnPrintLastDuplicate.Text = "Último";
      this.lblDuplicate.Text = "Duplicado";



    }

    private void printReportResult_Click(object sender, EventArgs e)
    {


      try
      {
        DisableWidgets();
        VPOSstructParams paymentParams = new VPOSstructParams();
        paymentParams.ClientLocalIP = "localhost";
        paymentParams.SysCountryApplication = GlobalInformation.Instance.SysCountryApplication;
        paymentParams.VPOSTxType = VPOSTransactionType.TxReports;
        paymentParams.ReportType = ((int)VPOSReportType.Detail).ToString();
        paymentParams.VPOSAdmin = web_admin_to_report.Text;


        VPOSCommunication VPOSComm2 = new VPOSCommunication(paymentParams);
        VPOSstructParams paymentResponse2 = VPOSComm2.PerformVPOSTransaction();
        CoreMessage.GetErrorVposMessage(paymentResponse2.status);

        FinantialDataToView finantialDataToView = new FinantialDataToView();
        finantialDataToView.authNum = paymentParams.status;
        glvApprovalReport = paymentParams.status;

        codigoAprobacion.Text = finantialDataToView.authNum;


      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
      finally 
      { 
        EnableWidgets();
      }

    }

    private void voidResult_Click(object sender, EventArgs e)
    {
      string retValue = "";
      try
      {
        DisableWidgets();
        VPOSstructParams paymentParams = new VPOSstructParams();
        paymentParams.ClientLocalIP = "localhost";
        paymentParamsToPrintVoid = null;

        paymentParams.numReceipt = web_number_to_void.Text;
        paymentParams.VPOSAdmin = web_admin_to_void.Text  ;

        paymentParams.VPOSTxType = VPOSTransactionType.TxVoid;


        //TODO: Mostrar pantalla Modal para seleccional los numeros de recibo activos y repetidos 

        VPOSCommunication VPOSComm = new VPOSCommunication(paymentParams);
        VPOSstructParams paymentResponse = VPOSComm.PerformVPOSTransaction();
        retValue = paymentResponse.claAuth;
        CoreMessage.GetErrorVposMessage(paymentResponse.claAuth);



        PaymentCore paymentCore = new PaymentCore();
        List<pa_invoice_payment> pa_Invoice_Payments = paymentCore.GetInvoicePaymentsByReceiptNumber(paymentParams.numReceipt.PadLeft(6, '0'));
        string JsonPaymentInfo = Utils.ToJson(pa_Invoice_Payments.FirstOrDefault());
        dynamic jsonStruct = Utils.FromJson(JsonPaymentInfo);

        paymentCore.CancelInvoicePaymentsByInvoiceNumber(Convert.ToInt32(jsonStruct.invoice_id));


        paymentParamsToPrintVoid = new VPOSstructParams();
        paymentParamsToPrintVoid = paymentParams;

        paymentParamsToPrintVoid.Amount = Convert.ToString(jsonStruct.value);
        paymentParamsToPrintVoid.numReceipt = Convert.ToString(jsonStruct.receipt_number);
        paymentParamsToPrintVoid.NumberBill = Convert.ToString(jsonStruct.receipt_number);
        paymentParamsToPrintVoid.Last4 = Convert.ToString(jsonStruct.number);
        paymentParamsToPrintVoid.Brand = Convert.ToString(jsonStruct.card_brand);
        paymentParamsToPrintVoid.AcquireId = Convert.ToString(jsonStruct.acquire_id);
        paymentParamsToPrintVoid.AID = Convert.ToString(jsonStruct.aid);

        paymentParamsToPrintVoid.CurrencySymbol = Convert.ToString(jsonStruct.currency_symbol);
        paymentParamsToPrintVoid.PayEntryMode = Convert.ToString(jsonStruct.pay_entry_mode);
        paymentParamsToPrintVoid.CardHolderName = Convert.ToString(jsonStruct.cardholder);
        paymentParamsToPrintVoid.Lot = Convert.ToString(jsonStruct.lot);
        paymentParamsToPrintVoid.Reference = Convert.ToString(jsonStruct.reference);
        paymentParamsToPrintVoid.Charge = Convert.ToString(jsonStruct.charge);

        FinantialDataToView finantialDataToView = new FinantialDataToView();
        finantialDataToView.authNum = paymentParams.claAuth;
        glvApprovalVoid = paymentParams.claAuth;

        codigoVoidAprobacion.Text = paymentParams.claAuth;


        SendPrintVoucher(paymentParamsToPrintVoid);

      }
      catch (Exception Ex)
      {
        if (Ex.Message.Contains("void or closed") && retValue.Length > 0)
        {
          
          MessageBox.Show("Anulación realizada correctamente en terminal", "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
          MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
        }
        

      }
      finally
      {
        EnableWidgets();
      }
    }


    void SendPrintVoucher(VPOSstructParams paymentParams)
    {

      POSReceiptParemeters pOSReceiptParemeters = new POSReceiptParemeters(GlobalInformation.Instance.SysCountryApplication);
      pOSReceiptParemeters.VoucherType = Convert.ToString((int)VPOSTransactionType.TxVoid);
      pOSReceiptParemeters.CompanyName = GlobalInformation.Instance.CompanyName;
      pOSReceiptParemeters.CompanyAddress = GlobalInformation.Instance.CompanyAddress;
      pOSReceiptParemeters.CompanyPhone = GlobalInformation.Instance.CompanyPhone;
      pOSReceiptParemeters.WebPage = GlobalInformation.Instance.WebPage;
      pOSReceiptParemeters.NumberBill = Convert.ToInt32(paymentParams.NumberBill);
      pOSReceiptParemeters.ApprovalNumber = paymentParams.claAuth;
      pOSReceiptParemeters.VoidVoucherInfoOut = paymentParams.VoidVoucherInfoOut;
      pOSReceiptParemeters.lblCurrencySymbol = paymentParams.CurrencySymbol;
      pOSReceiptParemeters.Total = Convert.ToDecimal(paymentParams.Amount);
      pOSReceiptParemeters.CardAmount = Convert.ToDecimal(paymentParams.Amount);
      pOSReceiptParemeters.ReceiptNumber = paymentParams.numReceipt;
      pOSReceiptParemeters.CardNumber = paymentParams.Last4;
      pOSReceiptParemeters.CardBrand = paymentParams.Brand;
      pOSReceiptParemeters.PayEntryMode = paymentParams.PayEntryMode;
      pOSReceiptParemeters.CardHolderName = paymentParams.CardHolderName;
      pOSReceiptParemeters.Lot = paymentParams.Lot;
      pOSReceiptParemeters.Reference = paymentParams.Reference;
      pOSReceiptParemeters.Charge = paymentParams.Charge;

      pOSReceiptParemeters.AcquireId = paymentParams.AcquireId;
      pOSReceiptParemeters.AID = paymentParams.AID;
      pOSReceiptParemeters.IsComerce = true;

      POSReceiptItemInfo item = new POSReceiptItemInfo();

      if (GlobalInformation.Instance.SysCountryApplication == SYS_COUNTRY_APPLICATION.Belice_Atlantida)
      {
        pOSReceiptParemeters.lblInvoice = "VOID";
        item.Description = "Void";
      }
      else
      {
        item.Description = "Anulación";
        pOSReceiptParemeters.lblInvoice = "ANULACIÓN";
      }

      item.Quantity = 1;
      item.UnitPrice = 0;
      item.UnitTotal = 0;
      pOSReceiptParemeters.InvoiceItems.Add(item);

      // Send Merchant Voucher
      VPOSVoucherToJSON vPOSVoucherToJSON = new VPOSVoucherToJSON(pOSReceiptParemeters);
      paymentParams.JSONVoucher = Utils.Base64Encode(vPOSVoucherToJSON.GetJSON());
      paymentParams.VPOSTxType = VPOSTransactionType.TxPrintVoucher;
      VPOSCommunication VPOSComm2 = new VPOSCommunication(paymentParams);
      VPOSstructParams paymentResponse2 = VPOSComm2.PerformVPOSTransaction();

      Thread.Sleep(1000);

      //Send Customer Voucher
      pOSReceiptParemeters.IsComerce = false;
      VPOSVoucherToJSON vPOSVoucherToJSON2 = new VPOSVoucherToJSON(pOSReceiptParemeters);
      paymentParams.JSONVoucher = Utils.Base64Encode(vPOSVoucherToJSON2.GetJSON());
      paymentParams.VPOSTxType = VPOSTransactionType.TxPrintVoucher;
      VPOSCommunication VPOSComm3 = new VPOSCommunication(paymentParams);
      paymentResponse2 = VPOSComm3.PerformVPOSTransaction();

    }

    private void settleResult_Click(object sender, EventArgs e)
    {

      try
      {
        DisableWidgets();
        VPOSstructParams paymentParams = new VPOSstructParams();
        paymentParams.ClientLocalIP = "localhost";
        paymentParams.SysCountryApplication = GlobalInformation.Instance.SysCountryApplication;
        paymentParams.VPOSAdmin = web_admin_to_settle.Text;

        paymentParams.VPOSTxType = VPOSTransactionType.TxClose;
        paymentParams.ReportType = ((int)VPOSReportType.Void).ToString();
        VPOSCommunication VPOSComm = new VPOSCommunication(paymentParams);
        VPOSstructParams paymentResponse = VPOSComm.PerformVPOSTransaction();
        CoreMessage.GetErrorVposMessage(paymentResponse.claAuth);

        PaymentCore paymentCore = new PaymentCore();
        paymentCore.ChangeStateToTransactionToClose(paymentResponse.TerminalId, paymentResponse.AcquireId);

        glvApprovalSettle = paymentParams.claAuth;

        codigoSettleAprobacion.Text = glvApprovalSettle;

      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
      finally
      {
        EnableWidgets();
      }
    }

    private void duplicateResult_Click(object sender, EventArgs e)
    {

      PrintDuplicate(web_number_to_duplicate.Text);
    }


    void PrintDuplicate(string param)
    {
      try
      {
        DisableWidgets();
        VPOSstructParams paymentParamsToPrintDuplicate;

        string numReceipt = param ;
        PaymentCore paymentCore = new PaymentCore();
        pa_invoice_payment invoice;

        if (!numReceipt.Equals("last"))
        {
          //TODO: Mostrar pantalla Modal para seleccional los numeros de recibo activos y repetidos 
          List<pa_invoice_payment> pa_Invoice_Payments = paymentCore.GetInvoicePaymentsByReceiptNumber(numReceipt.PadLeft(6, '0'));
          invoice = pa_Invoice_Payments.FirstOrDefault();
        }
        else
          invoice = paymentCore.GetLastInvoicePayments();




        paymentParamsToPrintDuplicate = new VPOSstructParams();
        paymentParamsToPrintDuplicate.ClientLocalIP = "localhost";
        paymentParamsToPrintDuplicate.VPOSTxType = VPOSTransactionType.TxSale;
        paymentParamsToPrintDuplicate.Amount = Convert.ToString(invoice.value);
        paymentParamsToPrintDuplicate.numReceipt = invoice.receipt_number;
        paymentParamsToPrintDuplicate.NumberBill = invoice.receipt_number;
        paymentParamsToPrintDuplicate.Last4 = invoice.number;
        paymentParamsToPrintDuplicate.Brand = invoice.card_brand;
        paymentParamsToPrintDuplicate.AcquireId = invoice.acquire_id;
        paymentParamsToPrintDuplicate.AID = invoice.aid;
        paymentParamsToPrintDuplicate.TerminalId = invoice.terminal_id;
        paymentParamsToPrintDuplicate.authNum = invoice.approval;
        paymentParamsToPrintDuplicate.AccountNumber = invoice.number;
        paymentParamsToPrintDuplicate.TVR = invoice.tvr;
        paymentParamsToPrintDuplicate.ARQC = invoice.arqc;
        paymentParamsToPrintDuplicate.TC = invoice.tc;
        paymentParamsToPrintDuplicate.TSI = invoice.tsi;
        paymentParamsToPrintDuplicate.NA = invoice.na;
        paymentParamsToPrintDuplicate.Tax1 = Utils.GetValueWithoutPoint(Convert.ToString(invoice.tax1));
        paymentParamsToPrintDuplicate.Tax2 = Utils.GetValueWithoutPoint(Convert.ToString(invoice.tax2));
        paymentParamsToPrintDuplicate.Discount = Utils.GetValueWithoutPoint(Convert.ToString(invoice.discount));
        paymentParamsToPrintDuplicate.Tip = Utils.GetValueWithoutPoint(Convert.ToString(invoice.tip));
        paymentParamsToPrintDuplicate.SubTotal = Utils.GetValueWithoutPoint(Convert.ToString(invoice.base_amount));
        paymentParamsToPrintDuplicate.Amount = Utils.GetValueWithoutPoint(Convert.ToString(invoice.value));

        paymentParamsToPrintDuplicate.TransactionDateTime = invoice.creation_date;
        paymentParamsToPrintDuplicate.CurrencySymbol = invoice.currency_symbol;
        paymentParamsToPrintDuplicate.PayEntryMode = invoice.pay_entry_mode;
        paymentParamsToPrintDuplicate.CardHolderName = invoice.cardholder;
        paymentParamsToPrintDuplicate.Lot = invoice.lot;
        paymentParamsToPrintDuplicate.Reference = invoice.reference;
        paymentParamsToPrintDuplicate.Charge = invoice.charge;

        SendPrintDuplicateVoucher(paymentParamsToPrintDuplicate);

      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
      finally
      {
        EnableWidgets();
      }
    }

    void SendPrintDuplicateVoucher(VPOSstructParams paymentParams)
    {
      POSReceiptParemeters pOSReceiptParemeters = new POSReceiptParemeters(GlobalInformation.Instance.SysCountryApplication);

      pOSReceiptParemeters.VoucherType = Convert.ToString((int)VPOSTransactionType.TxSale);
      pOSReceiptParemeters.CompanyName = GlobalInformation.Instance.CompanyName;
      pOSReceiptParemeters.CompanyAddress = GlobalInformation.Instance.CompanyAddress;
      pOSReceiptParemeters.TransactionDateTime = paymentParams.TransactionDateTime;
      pOSReceiptParemeters.CompanyPhone = GlobalInformation.Instance.CompanyPhone;
      pOSReceiptParemeters.WebPage = GlobalInformation.Instance.WebPage;
      pOSReceiptParemeters.NumberBill = Convert.ToInt32(paymentParams.numReceipt);
      pOSReceiptParemeters.CardNumber = paymentParams.AccountNumber;
      pOSReceiptParemeters.CardBrand = paymentParams.Brand;
      pOSReceiptParemeters.ApprovalNumber = paymentParams.authNum;
      pOSReceiptParemeters.ReceiptNumber = paymentParams.numReceipt;
      pOSReceiptParemeters.CardAmount = Convert.ToDecimal(paymentParams.Amount) / 100;
      pOSReceiptParemeters.SubTotal = Convert.ToDecimal(paymentParams.SubTotal) / 100;
      pOSReceiptParemeters.Tax1 = (GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX1_FIELD.ToString()) ? Convert.ToDecimal(paymentParams.Tax1) : Convert.ToDecimal(-432100)) / 100;
      pOSReceiptParemeters.Tax2 = (GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TAX2_FIELD.ToString()) ? Convert.ToDecimal(paymentParams.Tax2) : Convert.ToDecimal(-432100)) / 100;
      pOSReceiptParemeters.Tip = (GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_TIP_FIELD.ToString()) ? Convert.ToDecimal(paymentParams.Tip) : Convert.ToDecimal(-432100)) / 100;
      pOSReceiptParemeters.Discount = (GlobalInformation.Instance.GetParameterBooleanValue(PA_PARAMETERS.SHOW_DISCOUNT_FIELD.ToString()) ? Convert.ToDecimal(paymentParams.Discount) : Convert.ToDecimal(-432100)) / 100;
      pOSReceiptParemeters.Total = Convert.ToDecimal(paymentParams.Amount) / 100;
      pOSReceiptParemeters.ReceiptNumber = paymentParams.numReceipt;
      pOSReceiptParemeters.AID = paymentParams.AID;
      pOSReceiptParemeters.TVR = paymentParams.TVR;
      pOSReceiptParemeters.ARQC = paymentParams.ARQC;
      pOSReceiptParemeters.TC = paymentParams.TC;
      pOSReceiptParemeters.TSI = paymentParams.TSI;
      pOSReceiptParemeters.NA = paymentParams.NA;
      pOSReceiptParemeters.TerminalId = paymentParams.TerminalId;
      pOSReceiptParemeters.AcquireId = paymentParams.AcquireId;
      pOSReceiptParemeters.PayEntryMode = paymentParams.PayEntryMode;
      pOSReceiptParemeters.CardHolderName = paymentParams.CardHolderName;
      pOSReceiptParemeters.Lot = paymentParams.Lot;
      pOSReceiptParemeters.Reference = paymentParams.Reference;
      pOSReceiptParemeters.Charge = paymentParams.Charge;
      pOSReceiptParemeters.IsDuplicate = true;
      pOSReceiptParemeters.lblCurrencySymbol = paymentParams.CurrencySymbol;
      pOSReceiptParemeters.IsComerce = true;


      POSReceiptItemInfo item = new POSReceiptItemInfo();
      if (pOSReceiptParemeters.PayEntryMode == "01 Manual")
        item.Description = "Pago manual";
      else
        item.Description = "Pago con tarjeta";
      item.Quantity = 1;
      item.UnitPrice = pOSReceiptParemeters.Total;
      item.UnitTotal = item.UnitPrice;
      pOSReceiptParemeters.InvoiceItems.Add(item);


      // Send Merchant Voucher
      VPOSVoucherToJSON vPOSVoucherToJSON = new VPOSVoucherToJSON(pOSReceiptParemeters);
      paymentParams.JSONVoucher = Utils.Base64Encode(vPOSVoucherToJSON.GetJSON());
      paymentParams.VPOSTxType = VPOSTransactionType.TxPrintVoucher;
      VPOSCommunication VPOSComm2 = new VPOSCommunication(paymentParams);
      VPOSstructParams paymentResponse2 = VPOSComm2.PerformVPOSTransaction();

      Thread.Sleep(3000);

      // Send Customer Voucher
      pOSReceiptParemeters.IsComerce = false;
      VPOSVoucherToJSON vPOSVoucherToJSON_2 = new VPOSVoucherToJSON(pOSReceiptParemeters);
      paymentParams.JSONVoucher = Utils.Base64Encode(vPOSVoucherToJSON_2.GetJSON());
      paymentParams.VPOSTxType = VPOSTransactionType.TxPrintVoucher;
      VPOSCommunication VPOSComm3 = new VPOSCommunication(paymentParams);
      paymentResponse2 = VPOSComm3.PerformVPOSTransaction();


    }

    private void printLastDuplicate_Click(object sender, EventArgs e)
    {
     
      try
      {
        PrintDuplicate("last");
      }
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      }
    }
  }
}
