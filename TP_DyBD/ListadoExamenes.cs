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
    public partial class ListadoExamenes : Form
    {
        public ListadoExamenes()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListadoExamenes_Load(object sender, EventArgs e)
        {
            dgv_examenes.ReadOnly = true;
            dgv_examenes.AllowUserToAddRows = false;
            dgv_examenes.AllowUserToDeleteRows = false;
            dgv_examenes.AllowUserToResizeRows = false;
            dgv_examenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_examenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_examenes.SelectedRows[0];
            var nro_examen = selectedRow.Cells[0].Value.ToString();
            Delete(nro_examen);
        }

        private void Delete(string nro_examen)
        {
            try
            {
                SQL.ExecuteNonQuery($"DELETE FROM Examenes WHERE nro_examen = {nro_examen}");
                RefreshView();
                MessageBox.Show("Examen eliminado correctamente");
            }
            catch (SqlException ex)
            {
                // Verifica si la excepción se debe a una restricción FK
                if (ex.Number == 547)
                {
                    MessageBox.Show("El examen posee conexiones con otras tablas. Elimina los registros relacionados antes de eliminar al examen.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el examen: " + ex.Message);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al eliminar el examen: " + err.Message);
            }
        }

        private void RefreshView()
        {
            dgv_examenes.DataSource = SQL.ExecuteQuery("SELECT * FROM Examenes");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            (new AgregarExamen()).ShowDialog();
            Show();
        }

        private void ListadoExamenes_Activated(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Hide();
            var selectedRow = dgv_examenes.SelectedRows[0];
            var nro_examen = int.Parse(selectedRow.Cells[0].Value.ToString());
            (new AgregarExamen { examenSeleccionado = nro_examen }).ShowDialog();
            Show();
        }
    }
}
