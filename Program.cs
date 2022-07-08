using CashRegister.Applications.Winform;
using CashRegister.Applications.Winform.WFVPos.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CashRegister
{
  static class Program
  {
    private static string appGuid = "c0a76b5a-abab-45c5-b9d9-d693faa6e7b9";
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
          MessageBox.Show("Instance already running");
          return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());

      }


    }
  }
}
