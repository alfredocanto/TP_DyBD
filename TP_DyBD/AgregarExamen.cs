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
    public partial class AgregarExamen : Form
    {
        public int? examenSeleccionado { get; set; }
        public AgregarExamen()
        {
            InitializeComponent();
        }

        private void AgregarExamen_Load(object sender, EventArgs e)
        {
            cmb_nro_leg_alumno.DataSource = SQL.ExecuteQuery("SELECT * FROM ALUMNOS");
            cmb_nro_leg_alumno.DisplayMember = "ape_nom";
            cmb_nro_leg_alumno.ValueMember = "nro_legajo_a";
            cmb_nro_leg_alumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nro_leg_alumno.SelectedIndex = 0;

            cmb_materia.DataSource = SQL.ExecuteQuery("SELECT * FROM MATERIAS");
            cmb_materia.DisplayMember = "desc_mat";
            cmb_materia.ValueMember = "cod_materia";
            cmb_materia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_materia.SelectedIndex = 0;

            cmb_turno.DataSource = SQL.ExecuteQuery("SELECT * FROM TURNOS");
            cmb_turno.DisplayMember = "desc_turno";
            cmb_turno.ValueMember = "cod_turno";
            cmb_turno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_turno.SelectedIndex = 0;

            if (examenSeleccionado.HasValue)
            {
                btnAgregar.Text = "Editar";
                txt_nro_examen.Enabled = false;

                var examen = SQL.ExecuteQuery($"SELECT * FROM EXAMENES WHERE nro_examen = {examenSeleccionado}");
                //mapear el examen
                var nro_e = examen.Rows[0]["nro_examen"].ToString();
                var leg_a = examen.Rows[0]["nro_legajo_a"].ToString();
                var cod_mat = examen.Rows[0]["cod_mat"].ToString();
                var cod_turno = examen.Rows[0]["cod_turno"].ToString();
                var año = examen.Rows[0]["año"].ToString();
                var nota = examen.Rows[0]["nota"].ToString();
                var fecha = examen.Rows[0]["fecha_inscripcion"].ToString();

                //rellenar el formulario
                txt_nro_examen.Text = nro_e;
                cmb_nro_leg_alumno.SelectedValue = leg_a;
                cmb_materia.SelectedValue = cod_mat;
                cmb_turno.SelectedValue = cod_turno;
                txt_año.Text = año;
                txt_nota.Text = nota;
                dtp_fec_inscripcion.Value = DateTime.Parse(fecha);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            if (ValidateForm())
            {
                if (examenSeleccionado.HasValue)
                {
                    ModificarExamen();
                }
                else
                {
                    InsertarExamen();
                }
            }
        }

        private void ModificarExamen()
        {
            var nro_e = txt_nro_examen.Text.Trim();
            var leg_a = cmb_nro_leg_alumno.SelectedValue.ToString().Trim();
            var codmat = cmb_materia.SelectedValue.ToString().Trim();
            var cod_turno = cmb_turno.SelectedValue.ToString().Trim();
            var año = txt_año.Text.ToString().Trim();
            var nota = txt_nota.Text.ToString().Trim();
            var fecha_i = dtp_fec_inscripcion.Value.ToString().Trim();

            try
            {
                SQL.ExecuteNonQuery($"UPDATE EXAMENES SET nro_legajo_a = {leg_a}, cod_mat = '{codmat}', cod_turno = '{cod_turno}', año = '{año}', nota = {nota}, fecha_inscripcion = '{fecha_i}' where nro_examen = {nro_e}");
                MessageBox.Show("Examen modificado correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InsertarExamen()
        {
            var nro_ex = txt_nro_examen.Text.Trim();
            var leg_a = cmb_nro_leg_alumno.SelectedValue.ToString();
            var codmat = cmb_materia.SelectedValue.ToString();
            var codturno = cmb_turno.SelectedValue.ToString();
            var año = txt_año.Text.ToString();
            var nota = txt_nota.Text.ToString();
            var fec_i = dtp_fec_inscripcion.Value.ToString("yyyy-dd-MM");
            try
            {
                SQL.ExecuteNonQuery($"INSERT INTO EXAMENES VALUES ({nro_ex}, {leg_a}, '{codmat}', '{codturno}', '{año}', {nota}, '{fec_i}')");
                MessageBox.Show("Examen agregado correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool ValidateForm()
        {
            int nro_examen;
            if (!int.TryParse(txt_nro_examen.Text.Trim(), out nro_examen))
            {
                MessageBox.Show("El campo Nro. de examen debe ser un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string año = txt_año.Text.Trim();
            if (string.IsNullOrEmpty(año) || año.Length >= 10)
            {
                MessageBox.Show("El campo año no puede estar vacío y su longitud no debe exceder los 10 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string nota = txt_nota.Text.Trim();
            if (string.IsNullOrEmpty(nota))
            {
                MessageBox.Show("El campo nota no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (int.TryParse(txt_nota.Text, out int value))
            {
                if (value < 0 || value > 10)
                {
                    MessageBox.Show("El valor de la nota debe estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } 
            }

            return true;
        }
    }
}
