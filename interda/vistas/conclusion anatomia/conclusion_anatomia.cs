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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interda.vistas
{
    public partial class conclusion_anatomia : Form
    {
        conector conector = new conector();
        int index = 0;
        public conclusion_anatomia()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cargarDatos(index);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarDatos(int index)
        {
            DataTable datos = conector.leer("select * from formato_general");
            textBox_nombre.Text = datos.Rows[index]["Formato general nombre"].ToString();
            textBox_detalle.Text = datos.Rows[index]["Formato general detalle"].ToString();

            DataTable datos2 = conector.leer("SELECT `Formato general filtro tipo` FROM formato_general");
            comboBox_filtro.DataSource = datos2;
            comboBox_filtro.DisplayMember = "Formato general filtro tipo";
            comboBox_filtro.ValueMember = "Formato general filtro tipo";
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                cargarDatos(index);
            }
        }

        private void der_Click(object sender, EventArgs e)
        {
            if (index < conector.leer("select * from formato_general").Rows.Count - 1)
            {
                index++;
                cargarDatos(index);
            }
        }

        private void conclusion_anatomia_Load(object sender, EventArgs e)
        {

        }
    }
}
