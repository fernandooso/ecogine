using interda.vistas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//hola chao2
//aja
//cambios
//jijii
//uuuuuuu
namespace interda
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
            vistaprincipal vistaprincipal = new vistaprincipal();
            vistaprincipal.StartPosition = FormStartPosition.Manual;
            vistaprincipal.Location = new Point(10, 10);
            Application.Run(vistaprincipal);
        }
    }
}



