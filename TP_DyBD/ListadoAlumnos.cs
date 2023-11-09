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
    public partial class ListadoAlumnos : Form
    {
        public ListadoAlumnos()
        {
            InitializeComponent();
        }

        private void ListadoAlumnos_Load(object sender, EventArgs e)
        {
            //Data grid view settings
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AllowUserToResizeRows = false;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Load view
            RefreshView();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvAlumnos.SelectedRows[0];
            var nro_legajo = selectedRow.Cells[0].Value.ToString();
            Delete(nro_legajo);
        }

        private DataTable getAll()
        {
            return SQL.ExecuteQuery("SELECT * FROM ALUMNOS");
        }

        private void Delete(string legajo)
        {
            try
            {
                SQL.ExecuteNonQuery($"DELETE FROM ALUMNOS WHERE nro_legajo_a = {legajo}");
                RefreshView();
                MessageBox.Show("Alumno eliminado correctamente");
            }
            catch (SqlException ex)
            {
                // Verifica si la excepción se debe a una restricción FK
                if (ex.Number == 547)
                {
                    MessageBox.Show("El alumno posee conexiones con otras tablas. Elimina los registros relacionados antes de eliminar al alumno.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el alumno: " + ex.Message);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al eliminar el alumno: " + err.Message);
            }

        }

        private void RefreshView()
        {
            dgvAlumnos.DataSource = getAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            (new AgregarAlumno()).ShowDialog();
            Show();
        }

        private void ListadoAlumnos_Activated(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Hide();
            var selectedRow = dgvAlumnos.SelectedRows[0];
            var nro_legajo = int.Parse(selectedRow.Cells[0].Value.ToString());
            (new AgregarAlumno { legajoSeleccionado = nro_legajo }).ShowDialog();
            Show();
        }
    }
}
