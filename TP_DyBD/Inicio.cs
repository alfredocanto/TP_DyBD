using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DyBD
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ListadoAlumnos()).ShowDialog();
            Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ListadoMaterias()).ShowDialog();
            Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ListadoProfesores()).ShowDialog();
            Show();
        }

        private void registrosDeExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ListadoExamenes()).ShowDialog();
            Show();
        }

        private void alumnosInscriptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Alumnos inscriptos por materia y turno";
            dataGridView1.DataSource = SQL.ExecuteQuery("EXEC alumnosPorTurnos");
        }

        private void alumnosPresentesPorTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Total de alumnos por turnos";
            dataGridView1.DataSource = SQL.ExecuteQuery("EXEC contarAlumnosPorTurnos");
        }

        private void alumnosAprobadosPorTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Porcentaje de alumnos aprobados por turno";
            dataGridView1.DataSource = SQL.ExecuteQuery("EXEC porcentajeAprobados");
        }

        private void turnosDetalladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Turnos detallados";
            dataGridView1.DataSource = SQL.ExecuteQuery("EXEC turnosDetallados");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
