using Agenda.View;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Agenda
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_Inicial());

        }
    }
}
