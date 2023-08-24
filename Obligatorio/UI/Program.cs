using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ThreadException);
            Application.Run(new MainForm());
        }
        
        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Error de conexión a la base de datos, el programa se cerrará.", "Error");
            Application.Exit();
        }
    }
}
