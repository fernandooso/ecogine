//using interda.vistas.idreferencias;
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
    public partial class idreferencias : Form
    {
        public idreferencias()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            // this.BackgroundImage = Image.FromFile(rutaImagen);
            this.BackgroundImage = Properties.Resources.fondo;
            this.Width = 800;
            this.Height = 583;
        }

        private void idreferencias_Load(object sender, EventArgs e)
        {

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
            
            MostrarVentana("Ecografista", "select * from ecografista");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            MostrarVentana("MHZ", "select * from mhz");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarVentana("Código Examen", "select * from codex");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarVentana("Valor Examen", "select * from valormonetario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarVentana("Ecgrafo", "select * from ecografo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarVentana("Tratante", "select * from tratante");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarVentana("Isapre ", "select * from isapre");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarVentana("Anexo ", "select * from anexos");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MostrarVentana("Douglas", "select * from douglas");
        }

        private void boton_conclusion_Click(object sender, EventArgs e)
        {
            MostrarVentana("Conclusión ", "select * from conclusion");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MostrarVentana("Endometrio", "select * from endometriotipo");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MostrarVentana(" Ovarios", "select * from ovarios");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MostrarVentana("Útero", "select * from utero");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MostrarVentana("Vejiga ", "select * from vejiga");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MostrarVentana("Secretarias ", "select * from secretarias");
        }
    }
}
