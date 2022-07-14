using CashRegister.Applications.Winform;
using CashRegister.Applications.Winform.WFVPos.Forms;
using CashRegister.Libraries.Basic.Core;
using CashRegister.Libraries.Basic.Database;
using CashRegister.Libraries.Basic.DataStore;
using CashRegister.Libraries.ControlDataBase;
using CashRegister.Libraries.Database.Interface;
using CashRegister.Libraries.Database.Repository;
using CashRegister.Libraries.DataStructs;
using CashRegister.Libraries.Utilities;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace CashRegister
{

  
  static class Program
  {
    private static string appGuid = "c0a76b5a-abas-45c5-b9d9-d693faa6e7r9";
    static public string DataBaseName = "cashregister";
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {

      using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
      {
        if (!mutex.WaitOne(0, false))
        {
          MessageBox.Show("La aplicación no se puede abrir más de una vez");
          return;
        }

        DiagnosticTrace.SetTraceSourceName("WinPostekTraceSource", "WinPostek");
        DiagnosticTrace.Trace(TraceEventType.Start, DiagnosticTrace.DefaultCategory + ".Main" + " v" + Application.ProductVersion, 0, "Iniciando WinPostek", string.Empty);

        

        if (ControlDB())
          ;
        //LoadDataBaseContainers();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());

      }


    }

    static private bool ControlDB()
    {
      try
      {
        DiagnosticTrace.TraceInformation("CheckDB", 0, "ControlDB", DateTime.Now + " : "  , false);

        ControlDataBaseEngine dataBaseEngine = new ControlDataBaseEngine();
        dataBaseEngine.ValidateDB();
        return true;
      }
      catch (Exception ex)
      {
        GlobalInformation._instance.WriteLog(ex.Message);
        throw new Exception(ex.Message + "\n        Cierre la aplicación y corrija el fallo");

      }

    }


    static private void LoadIoContainer()
    {

      IoContainer.Add<IPaymentRepository>(typeof(PaymentRepository));
      IoContainer.Add<IItemRepository>(typeof(ItemRepository));
      IoContainer.Add<IUserRepository>(typeof(UserRepository));
      IoContainer.Add<ICashRegisterRepository>(typeof(CashRegisterRepository));
      IoContainer.Add<IUnitOfWork>(typeof(DbUnitOfWork));
    }

    static private void LoadDataBaseContainers()
    {
      try
      {
        System.Configuration.ConnectionStringSettings connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"];
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connectionString"];
        DbMultiThreadManager.SetDefaultProvider(settings.ProviderName
          , @"Server=localhost;Port=5434;Database=" + DataBaseName + "; User Id=postgres;Password=PostekDB; Pooling=true; MinPoolSize=3; MaxPoolSize=50"/*settings.ConnectionString*/);
        LoadIoContainer();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
