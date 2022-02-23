using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    static class Program
    {
        public static Form form_menuvalasztek = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_menuvalasztek = new Form_Menuvalasztek();
            Application.Run(new Form1());
        }
    }
}
