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
    public partial class piedepa : Form
    {
        conector conector=new conector();
        public piedepa()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
           // string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            //this.BackgroundImage = Image.FromFile(rutaImagen);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Label label1 = new Label();
            label1.Text = "Pie de Pagina";
            label1.Font = new Font(label1.Font.FontFamily, 15, label1.Font.Style);
            DataGridView dataGridView1 = new DataGridView();
            Color nuevoColorDeFondo = Color.FromArgb(240, 240, 240);
            dataGridView1.BackgroundColor = nuevoColorDeFondo;
            label1.AutoSize = true;
       
            this.Controls.Add(dataGridView1);
            this.Controls.Add(label1);
            DataTable datos = conector.leer("select * from `pie de pagina`");
            dataGridView1.DataSource = datos;
            label1.Location = new Point(40, 90);
            dataGridView1.Location = new Point(50, 130);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.ScrollBars = ScrollBars.Both;


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Width = 700;
            dataGridView1.Height = 350;
            
        }

        private void piedepa_Load(object sender, EventArgs e)
        {

        }
    }
}
