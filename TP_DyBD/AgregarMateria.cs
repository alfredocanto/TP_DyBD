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
    public partial class AgregarMateria : Form
    {
        public string codSeleccionado { get; set; }
        public AgregarMateria()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var cod = txt_cod_materia.Text.Trim();
                var desc_m = txt_desc_materia.Text.Trim();
                var desc_c = txt_desc_carrera.Text.Trim();
                var leg_p = cmb_nro_legajo_p.SelectedValue.ToString();

                if (codSeleccionado == null)
                {

                    SQL.ExecuteNonQuery($"INSERT INTO Materias VALUES ('{cod}', '{desc_m}', '{desc_c}', {leg_p})");
                    MessageBox.Show("Agregada");
                    Close();
                } 
                else
                {
                    SQL.ExecuteNonQuery($"UPDATE Materias SET desc_mat = '{desc_m}', desc_carrera = '{desc_c}', nro_legajo_p = {leg_p} WHERE cod_materia = '{cod}'");
                    MessageBox.Show("Actualizada");
                    Close();
                }
            }
        }

        private bool ValidateForm()
        {
            // Validar txt_cod_materia
            if (string.IsNullOrEmpty(txt_cod_materia.Text.Trim()) || txt_cod_materia.Text.Trim().Length != 5)
            {
                MessageBox.Show("El código de la materia debe tener exactamente 5 caracteres y no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar txt_desc_materia
            if (string.IsNullOrEmpty(txt_desc_materia.Text.Trim()) || txt_desc_materia.Text.Trim().Length > 30)
            {
                MessageBox.Show("La descripción de la materia no puede estar vacía y debe tener como máximo 30 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar txt_desc_carrera
            if (string.IsNullOrEmpty(txt_desc_carrera.Text.Trim()) || txt_desc_carrera.Text.Trim().Length > 30)
            {
                MessageBox.Show("La descripción de la carrera no puede estar vacía y debe tener como máximo 30 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Todas las validaciones pasaron
            return true;
        }


        private void AgregarMateria_Load(object sender, EventArgs e)
        {
            cmb_nro_legajo_p.DataSource = SQL.ExecuteQuery("SELECT * FROM Profesores");
            cmb_nro_legajo_p.DisplayMember = "ape_nom";
            cmb_nro_legajo_p.ValueMember = "nro_legajo_p";
            cmb_nro_legajo_p.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nro_legajo_p.SelectedIndex = 0;

            if (codSeleccionado != null)
            {
                btn_aceptar.Text = "Editar";
                txt_cod_materia.Enabled = false;
                var materia = SQL.ExecuteQuery($"SELECT * FROM Materias where cod_materia = '{codSeleccionado}'");

                var cod = materia.Rows[0]["cod_materia"].ToString();
                var desc_m = materia.Rows[0]["desc_mat"].ToString();
                var desc_c = materia.Rows[0]["desc_carrera"].ToString();
                var leg_p = materia.Rows[0]["nro_legajo_p"].ToString();

                cmb_nro_legajo_p.SelectedValue = leg_p;
                txt_cod_materia.Text = cod;
                txt_desc_materia.Text = desc_m;
                txt_desc_carrera.Text = desc_c;
            }
        }
    }
    
}
