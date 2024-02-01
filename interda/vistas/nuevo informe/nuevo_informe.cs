using interda.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interda.vistas
{
    public partial class nuevo_informe : Form
    {
        conector conector= new conector();
        int index = 0;
        bool access = false;
        public nuevo_informe()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            comboBox2_procedencia.DropDownStyle= ComboBoxStyle.DropDownList;
            comboBox1_ecografista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_ecografo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_codigo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3_prevision.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_tipo_examen.DropDownStyle = ComboBoxStyle.DropDownList;
            cargarDatoscombobox();
        }

     

        private void cargarDatoscombobox()
        {
            DataTable datos = conector.leer("select * from tratante");
            comboBox2_procedencia.DataSource = datos;
            comboBox2_procedencia.DisplayMember = "Tratante";
            comboBox2_procedencia.ValueMember = "Tratante";

            DataTable datos2 = conector.leer("select * from ecografista");
            comboBox1_ecografista.DataSource = datos2;
            comboBox1_ecografista.DisplayMember = "Ecografista";
            comboBox1_ecografista.ValueMember = "Ecografista";

            DataTable datos3 = conector.leer("select * from ecografo");
            comboBox1_ecografo.DataSource = datos3;
            comboBox1_ecografo.DisplayMember = "Ecógrafo";
            comboBox1_ecografo.ValueMember = "Ecógrafo";

            DataTable datos4 = conector.leer("SELECT CONCAT(`Código del examen`, ' | ', detalle) AS codigoexamen FROM codex");
            comboBox1_codigo.DataSource = datos4;
            comboBox1_codigo.DisplayMember = "codigoexamen";
            comboBox1_codigo.ValueMember = "codigoexamen";

            DataTable datos5 = conector.leer("select * from isapre");
            comboBox3_prevision.DataSource = datos5;
            comboBox3_prevision.DisplayMember = "Isapre";
            comboBox3_prevision.ValueMember = "Isapre";

            DataTable datos6 = conector.leer("select * from Tipo_de_examen");
            comboBox1_tipo_examen.DataSource = datos6;
            comboBox1_tipo_examen.DisplayMember = "Tipo de exámen";
            comboBox1_tipo_examen.ValueMember = "Tipo de exámen";

        }


        private void nuevo_informe_close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void nuevo_informe_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_tipo_examen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            access = true;
            actualizar(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidadFilasTabla = ObtenerCantidadFilasTabla("buscador");
            if (index < cantidadFilasTabla && access==true)
            {
                index++;
                actualizar(index);
            }
        }

        private void actualizar(int index)
        {
            DataTable datos = conector.leer("select * from buscador");
            hospitales.Text = datos.Rows[index]["Institucion o empresa"].ToString();
            comboBox1_tipo_examen.Text = datos.Rows[index]["Tipo de exámen"].ToString();
            textBox1_CI.Text = datos.Rows[index]["CI"].ToString();
            textBox3_nombre.Text = datos.Rows[index]["Nombres"].ToString();
            textBox1_Apellido.Text = datos.Rows[index]["Apellidos"].ToString();
            textBox1_edad.Text = datos.Rows[index]["Edad"].ToString();
            comboBox1_codigo.Text = datos.Rows[index]["Código de la prestación"].ToString();
            textBox1_edad.Text = datos.Rows[index]["Edad"].ToString();
            comboBox2_procedencia.Text = datos.Rows[index]["Tratante"].ToString();
            comboBox3_prevision.Text = datos.Rows[index]["Isapre"].ToString();
            comboBox1_ecografista.Text = datos.Rows[index]["Ecografista"].ToString();
            comboBox1_ecografo.Text = datos.Rows[index]["Ecógrafo"].ToString();
            textBox1.Text = datos.Rows[index]["FURpaciente"].ToString();
            textBox9.Text = datos.Rows[index]["FUR"].ToString();
            comboBox1.Text = datos.Rows[index]["Pied de pagina"].ToString();

            string textoci = textBox1_CI.Text;
            string consultaSQL = string.IsNullOrEmpty(textoci)
                ? "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador limit 15"
                : "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador where CI='" + textoci + "'";

            DataTable datos2 = conector.leer(consultaSQL);
            tablabuscador.DataSource = datos2;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0 && access == true)
            {
                index--;
                actualizar(index);
            }
        }

        private int ObtenerCantidadFilasTabla(string nombreTabla)
        {
            string query = $"SELECT COUNT(*) FROM {nombreTabla}";
            int cantidadFilas = Convert.ToInt32(conector.leer(query).Rows[0][0]);
            return cantidadFilas;
        }


        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_CI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
