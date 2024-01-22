using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sinapse
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 principalForm = new Form1();
            principalForm.Icon = new System.Drawing.Icon("C:\\Users\\Administrator\\source\\repos\\Sistema_Sinapse\\Sistema_Sinapse\\cerebro.ico");
            Application.Run(new Form1());
        }
    }
}
