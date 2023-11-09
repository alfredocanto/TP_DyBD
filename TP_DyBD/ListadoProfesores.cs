using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DyBD
{
    public partial class ListadoProfesores : Form
    {
        public ListadoProfesores()
        {
            InitializeComponent();
        }

        private void ListadoProfesores_Load(object sender, EventArgs e)
        {
            RefreshView();
            dgv_profesores.ReadOnly = true;
            dgv_profesores.AllowUserToAddRows = false;
            dgv_profesores.AllowUserToDeleteRows = false;
            dgv_profesores.AllowUserToResizeRows = false;
            dgv_profesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_profesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshView()
        {
            dgv_profesores.DataSource = SQL.ExecuteQuery("SELECT * FROM PROFESORES");
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_profesores.SelectedRows[0];
            var nro_legajo_p = selectedRow.Cells[0].Value.ToString();
            try
            {
                 SQL.ExecuteNonQuery($"DELETE FROM Profesores WHERE nro_legajo_p = {nro_legajo_p}");
                RefreshView();
                MessageBox.Show("Profesor eliminado correctamente");
            }
            catch (SqlException ex)
            {
                // Verifica si la excepción se debe a una restricción FK
                if (ex.Number == 547)
                {
                    MessageBox.Show("El profesor posee conexiones con otras tablas. Elimina los registros relacionados antes de eliminar al profesor.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el profesor: " + ex.Message);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al eliminar el profesor: " + err.Message);
            }


        }

        private void ListadoProfesores_Activated(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Hide();
            (new AgregarProfesor()).ShowDialog();
            Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Hide();
            var selectedRow = dgv_profesores.SelectedRows[0];
            var nro_legajo = int.Parse(selectedRow.Cells[0].Value.ToString());
            (new AgregarProfesor { legajoSeleccionado = nro_legajo }).ShowDialog();
            Show();
        }
    }
}
