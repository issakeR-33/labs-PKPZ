using System;
using System.Windows.Forms;

namespace GUI_interface
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1()); // Запуск форми
        }
    }
}
