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
    public partial class pb : Form
    {
        conector miConector = new conector();
        public pb(int index)
        {
            InitializeComponent();
            cargarDatos(index);
            comboBox1_tipo_examen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarDatos(int index)
        {
            DataTable datos = miConector.leer("select * from Tipo_de_examen");
            comboBox1_tipo_examen.DataSource = datos;
            comboBox1_tipo_examen.DisplayMember = "Tipo de exámen";
            comboBox1_tipo_examen.ValueMember = "Tipo de exámen";

            DataTable datos2 = miConector.leer("select * from tratante");
            comboBox2_procedencia.DataSource = datos2;
            comboBox2_procedencia.DisplayMember = "Tratante";
            comboBox2_procedencia.ValueMember = "Tratante";

            DataTable datos3 = miConector.leer("select * from ecografista");
            comboBox1_ecografista.DataSource = datos3;
            comboBox1_ecografista.DisplayMember = "Ecografista";
            comboBox1_ecografista.ValueMember = "Ecografista";

            DataTable datos4 = miConector.leer("select * from ecografo");
            comboBox1_ecografo.DataSource = datos4;
            comboBox1_ecografo.DisplayMember = "Ecógrafo";
            comboBox1_ecografo.ValueMember = "Ecógrafo";

            DataTable datos5 = miConector.leer("SELECT CONCAT(`Código del examen`, ' | ', detalle) AS codigoexamen FROM codex");
            comboBox1_codigo.DataSource = datos5;
            comboBox1_codigo.DisplayMember = "codigoexamen";
            comboBox1_codigo.ValueMember = "codigoexamen";

            DataTable datos6 = miConector.leer("select * from isapre");
            comboBox3_prevision.DataSource = datos6;
            comboBox3_prevision.DisplayMember = "Isapre";
            comboBox3_prevision.ValueMember = "Isapre";

            DataTable data = miConector.leer("select * from buscador");
            hospitales.Text = data.Rows[index]["Institucion o empresa"].ToString();
            comboBox1_tipo_examen.Text = data.Rows[index]["Tipo de exámen"].ToString();
            textBox1_CI.Text = data.Rows[index]["CI"].ToString();
            textBox3_nombre.Text = data.Rows[index]["Nombres"].ToString();
            textBox1_Apellido.Text = data.Rows[index]["Apellidos"].ToString();
            textBox1_edad.Text = data.Rows[index]["Edad"].ToString();
            comboBox1_codigo.Text = data.Rows[index]["Código de la prestación"].ToString();
            textBox1_edad.Text = data.Rows[index]["Edad"].ToString();
            comboBox2_procedencia.Text = data.Rows[index]["Tratante"].ToString();
            comboBox3_prevision.Text = data.Rows[index]["Isapre"].ToString();
            comboBox1_ecografista.Text = data.Rows[index]["Ecografista"].ToString();
            comboBox1_ecografo.Text = data.Rows[index]["Ecógrafo"].ToString();
            textBox1.Text = data.Rows[index]["FURpaciente"].ToString();
            textBox1.Text = data.Rows[index]["FUR"].ToString();
            textBox2.Text = data.Rows[index]["Pied de pagina"].ToString();

            //cargar panel inferior
            string textoci = textBox1_CI.Text;
            string consultaSQL = string.IsNullOrEmpty(textoci)
                ? "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador limit 15"
                : "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador where CI='" + textoci + "'";

            DataTable panel = miConector.leer(consultaSQL);
            tablabuscador.DataSource = panel;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void pb_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void hospitales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
