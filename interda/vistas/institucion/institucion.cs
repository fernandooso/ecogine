using interda.controlador;
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
    public partial class institucion : Form
    {
        conector conector = new conector();
        int index = 0;
        public institucion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cargarDatos(index);
        }
        private void cargarDatos(int index)
        {
            DataTable datos = conector.leer("select * from institucion");
            textBox4.Text = datos.Rows[index]["Nombre de fantasia"].ToString();
            textBox1.Text = datos.Rows[index]["Nombre tributario"].ToString();
            textBox2.Text = datos.Rows[index]["Region"].ToString();
            textBox3.Text = datos.Rows[index]["Cuidad"].ToString();
            textBox5.Text = datos.Rows[index]["Mail 1"].ToString();
            textBox6.Text = datos.Rows[index]["Mail 2"].ToString();
            textBox7.Text = datos.Rows[index]["Texto de salida mail"].ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index = 0;
                cargarDatos(index);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                cargarDatos(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < conector.leer("select * from institucion").Rows.Count - 1)
            {
                index++;
                cargarDatos(index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cantidadFilasTabla = ObtenerCantidadFilasTabla("institucion");
            if (cantidadFilasTabla > 0)
            {
                index = cantidadFilasTabla - 1;
                cargarDatos(index);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void institucion_Load(object sender, EventArgs e)
        {

        }

        private int ObtenerCantidadFilasTabla(string nombreTabla)
        {
            string query = $"SELECT COUNT(*) FROM {nombreTabla}";
            int cantidadFilas = Convert.ToInt32(conector.leer(query).Rows[0][0]);
            return cantidadFilas;
        }
    }
}
