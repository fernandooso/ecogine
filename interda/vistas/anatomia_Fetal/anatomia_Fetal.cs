
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
    public partial class anatomia_Fetal : Form
    {
        public anatomia_Fetal()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            this.BackgroundImage = Image.FromFile(rutaImagen);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }*/

        private void MostrarVentana(string tabla, string label)
        {
            ventanageneraldatagridview ventana = new ventanageneraldatagridview(tabla, label);
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }
        private void button_cerebro_Click(object sender, EventArgs e)
        {
            MostrarVentana("Cerebro", "select * from `Formato cerebro`");
        }

        private void button_cabeza_Click(object sender, EventArgs e)
        {
            MostrarVentana("Cabeza", "select * from `Formato cabeza`");
        }

        private void button_cara_Click(object sender, EventArgs e)
        {
            
            MostrarVentana("Cara", "select * from `Formato cara`");

        }

        private void button_columnaVertebral_Click(object sender, EventArgs e)
        {
            MostrarVentana("Columna Vertebral", "select* from Formato_columna_vertebral ");
               
        }

        private void button_torax_Click(object sender, EventArgs e)
        {
            MostrarVentana("Torax", "select * from Formato_torax");
                 
        }

        private void button_corazon_Click(object sender, EventArgs e)
        {
            MostrarVentana("Corazón", "select * from Formato_corazon");
                  
        }

        private void button_Tgastrointestinal_Click(object sender, EventArgs e)
        {
            MostrarVentana("Tracto Gastrointestinal", "select* from Formato_tracto_gastrointestinal ");
                   
        }

        private void button_riñones_Click(object sender, EventArgs e)
        {
            MostrarVentana("Riñones", "select * from Formato_rinones"
);
        }

        private void button_paredAbdominal_Click(object sender, EventArgs e)
        {
            MostrarVentana("Pared Abdominal", "select * from Formato_pared_abdominal");
;
        }

        private void button_vejigaFetal_Click(object sender, EventArgs e)
        {
            MostrarVentana("Vejiga Fetal", "select * from Formato_vejiga_fetal");
        }

        private void button_cordonUmbilical_Click(object sender, EventArgs e)
        {
            MostrarVentana("Cordón Umbilical", "select * from `Formato_cordon_umbilical`");

        }

        private void button_extremidades_Click(object sender, EventArgs e)
        {
            MostrarVentana("Extremidades", "select * from Formato_extremidades");
            
        }

        private void anatomia_Fetal_Load(object sender, EventArgs e)
        {

        }
    }
}
