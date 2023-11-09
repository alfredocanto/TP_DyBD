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
    public partial class ListadoMaterias : Form
    {
        public ListadoMaterias()
        {
            InitializeComponent();
        }

        private void ListadoMaterias_Load(object sender, EventArgs e)
        {
            //Data grid view settings
            dgv_materias.ReadOnly = true;
            dgv_materias.AllowUserToAddRows = false;
            dgv_materias.AllowUserToDeleteRows = false;
            dgv_materias.AllowUserToResizeRows = false;
            dgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_materias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Load view
            RefreshView();
        }

        private void RefreshView()
        {
            dgv_materias.DataSource = SQL.ExecuteQuery("SELECT * FROM MATERIAS");
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv_materias.SelectedRows[0];
            var cod_materia = selectedRow.Cells[0].Value.ToString();
            Delete(cod_materia);
        }

        private void Delete(string cod_materia)
        {
            try
            {
                SQL.ExecuteNonQuery($"DELETE FROM Materias WHERE cod_materia = '{cod_materia}'");
                RefreshView();
                MessageBox.Show("Materia eliminada correctamente");
            }
            catch (SqlException ex)
            {
                // Verifica si la excepción se debe a una restricción FK
                if (ex.Number == 547)
                {
                    MessageBox.Show("La materia posee conexiones con otras tablas. Elimina los registros relacionados antes de eliminar la materia.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar la materia: " + ex.Message);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al eliminar el alumno: " + err.Message);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Hide();
            (new AgregarMateria()).ShowDialog();
            Show();
        }

        private void ListadoMaterias_Activated(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Hide();
            var selectedRow = dgv_materias.SelectedRows[0];
            var cod_mat = selectedRow.Cells[0].Value.ToString();
            (new AgregarMateria { codSeleccionado = cod_mat }).ShowDialog();
            Show();
        }
    }
}
