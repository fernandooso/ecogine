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
    public partial class binforme : Form
    {
        private conector conector = new conector();
        

        public binforme()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select Fecha, CI, Nombres, Apellidos,`Tipo de exámen`,FUR,Ecografista,Correlativo from buscador limit 15");
            tablabuscador.DataSource = datos;
            this.Width = 800; 
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            tablabuscador.CellDoubleClick += tablabuscador_CellDoubleClick;
            tablabuscador.KeyDown += tablabuscador_Enter;
            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }
        private void tablabuscador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirVentana(e.RowIndex);
        }

        private void tablabuscador_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tablabuscador.SelectedCells.Count > 0)
                {
                    int rowIndex = tablabuscador.SelectedCells[0].RowIndex;
                    AbrirVentana(rowIndex);

                    // Deseleccionar la fila después de abrir la ventana
                    tablabuscador.Rows[rowIndex].Selected = false;
                    e.Handled = true;
                }
            }
        }

        private void AbrirVentana(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = tablabuscador.Rows[rowIndex];

                string nombre = filaSeleccionada.Cells["Nombres"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellidos"].Value.ToString();

                pb ventana = new pb(rowIndex);
                ventana.StartPosition = FormStartPosition.Manual;
                ventana.Location = new Point(520, 150);
                ventana.Show();
            }
        }


        private void pruebas_Load(object sender, EventArgs e)
        {

        }
        private void buscarci_Click(object sender, EventArgs e)
        {
            string textoci = textBoxci.Text;

            // Verificar si el campo de búsqueda está vacío o nulo
            string consultaSQL = string.IsNullOrEmpty(textoci)
                ? "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador limit 15"
                : "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador where CI='" + textoci + "'";

            DataTable datos = conector.leer(consultaSQL);
            tablabuscador.DataSource = datos;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void buscarapellidos_Click(object sender, EventArgs e)
        {
            string textoap = textBoxapellidos.Text;
            DataTable datos = conector.leer("SELECT Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo FROM buscador WHERE Apellidos LIKE '%" + textoap + "%'");
            tablabuscador.DataSource = datos;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void textBoxci_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablabuscador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
