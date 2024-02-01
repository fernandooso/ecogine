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
    public partial class tablaobstetrica : Form
    {
        public tablaobstetrica()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarVentana("Abdómen", "select * from abdomen");
        }

        private void cerebelo_Click(object sender, EventArgs e)
        {
            MostrarVentana("Cerebelo", "select * from cerebelo");
        }

        private void cubito_Click(object sender, EventArgs e)
        {
            MostrarVentana("Cúbito", "select * from cubito");
        }

        private void bbp_Click(object sender, EventArgs e)
        {
            MostrarVentana("DBP", "select * from dbp");
        }

        private void dfo_Click(object sender, EventArgs e)
        {
            MostrarVentana("DFO", "select * from dfo");
        }

        private void femur_Click(object sender, EventArgs e)
        {
            MostrarVentana("Fémur", "select * from femur");
        }

        private void humero_Click(object sender, EventArgs e)
        {
            MostrarVentana("Húmero", "select * from humero");
        }

        private void lcn_Click(object sender, EventArgs e)
        {
            MostrarVentana("LCN", "select * from lcn");
        }

        private void perone_Click(object sender, EventArgs e)
        {
            MostrarVentana("Peroné", "select * from perone");
        }

        private void radio_Click(object sender, EventArgs e)
        {
            MostrarVentana("Radio", "select * from radio");
        }

        private void rnpg_Click(object sender, EventArgs e)
        {
            MostrarVentana("RN Partos Gemelares", "select * from rnpartosgemelares");
        }

        private void rnps_Click(object sender, EventArgs e)
        {
            MostrarVentana("RN Partos Simples", "select * from rnpartossimples");
        }

        private void tibia_Click(object sender, EventArgs e)
        {
            MostrarVentana("Tibia", "select * from tibia");
        }

        private void acm_Click(object sender, EventArgs e)
        {
            MostrarVentana("Arteria Cerebral media", "select * from arteriacerebralmedia");
        }

        private void au_Click(object sender, EventArgs e)
        {
            MostrarVentana("Arteria Uterina", "select * from arteriauerina");
        }

        private void aum_Click(object sender, EventArgs e)
        {
            MostrarVentana("Arteria Umbilical", "select * from arteriaumbilical");
        }

        private void ductus_Click(object sender, EventArgs e)
        {
            MostrarVentana("Ductus", "select * from ductus");
        }

        private void psacm_Click(object sender, EventArgs e)
        {
            MostrarVentana("Peak Sistólico ACM", "select Sem,Median,`15 Media`from peaksistolicoacm");
        }

        private void ad_Click(object sender, EventArgs e)
        {
            MostrarVentana("Aorta descendente", "select * from aortadescendente");
        }

        private void tablaobstetrica_Load(object sender, EventArgs e)
        {

        }
    }

}
