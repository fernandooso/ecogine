using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interda.vistas
{
    public partial class informeobstetrico : Form
    {
        public informeobstetrico()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            this.BackgroundImage = Image.FromFile(rutaImagen);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void MostrarVentana(string tabla, string label)
        {
            ventanageneraldatagridview ventana = new ventanageneraldatagridview(tabla, label);
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void btnconcldiaginfobst_Click(object sender, EventArgs e)
        {
            MostrarVentana("Conclusión Obstétrica", "select * from conclusiónobstétrica");
        }

        private void btnliquamniotico_Click(object sender, EventArgs e)
        {
            MostrarVentana("Liquido Amniotico", "select * from liquidoamniotico");
        }

        private void btnplacenta_Click(object sender, EventArgs e)
        {
            MostrarVentana("Placenta", "select * from placenta");
        }

        private void btnpresentacion_Click(object sender, EventArgs e)
        {
            MostrarVentana("Presentacion", "select * from presentacion");
        }


        private void informeobstetrico_Load(object sender, EventArgs e)
        {

        }
    }
}
