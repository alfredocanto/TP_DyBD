using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DyBD
{
    public partial class AgregarAlumno : Form
    {
        public int? legajoSeleccionado { get; set; }

        public AgregarAlumno()
        {
            InitializeComponent();
            //Combo box estado civil
            cmb_est_civil.Items.Add("SOLTERO");
            cmb_est_civil.Items.Add("CASADO");
            cmb_est_civil.Items.Add("DIVOCIADO");
            cmb_est_civil.Items.Add("VIUDO");
            cmb_est_civil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_est_civil.SelectedIndex = 0;

            //Date time picker settings
            dtp_fec_nac.MaxDate = DateTime.Today;

            //Combo box tipo documento settings
            cmb_cod_doc.DataSource = SQL.ExecuteQuery("SELECT * FROM TIPODOC");
            cmb_cod_doc.DisplayMember = "desc_doc";
            cmb_cod_doc.ValueMember = "cod_doc";
            cmb_cod_doc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cod_doc.SelectedIndex = 0;
        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
        {
            if (legajoSeleccionado.HasValue)
            {
                btn_agregar.Text = "Editar";
                txt_nro_legajo.Enabled = false;

                var alumno = SQL.ExecuteQuery($"SELECT * FROM ALUMNOS WHERE nro_legajo_a = {legajoSeleccionado}");
                //mapear el alumno
                var leg = alumno.Rows[0]["nro_legajo_a"].ToString();
                var apenom = alumno.Rows[0]["ape_nom"].ToString();
                var ndoc = alumno.Rows[0]["nro_doc"].ToString();
                var direc = alumno.Rows[0]["direccion"].ToString();
                var email = alumno.Rows[0]["email"].ToString();
                var tel = alumno.Rows[0]["telefono"].ToString();
                var coddoc = alumno.Rows[0]["cod_doc"].ToString();
                var sexo = alumno.Rows[0]["sexo"].ToString();
                var nac = alumno.Rows[0]["fec_nac"].ToString();
                var estciv = alumno.Rows[0]["est_civil"].ToString();

                //separar apellido de nombre/s
                string pattern = @"^(?<Apellido>[^\s]+)\s+(?<Nombres>.+)$";
                Match match = Regex.Match(apenom, pattern);
                string ape = match.Groups["Apellido"].Value;
                string nombs = match.Groups["Nombres"].Value;

                //rellenar el formulario
                txt_nro_legajo.Text = leg;
                txt_nom.Text = nombs;
                txt_ape.Text = ape;
                cmb_cod_doc.SelectedValue = coddoc;
                txt_nro_doc.Text = ndoc;
                rad_sexo_femenino.Checked = (sexo == "F") ? true : false;
                rad_sexo_masculino.Checked = (sexo == "M") ? true : false;
                dtp_fec_nac.Value = DateTime.Parse(nac);
                cmb_est_civil.SelectedValue = estciv;
                txt_direccion.Text = direc;
                txt_email.Text = email;
                txt_telefono.Text = tel;

            }
 
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (legajoSeleccionado.HasValue)
                {
                    ModificarAlumno();
                } else
                {
                    InsertarAlumno();
                }
            }
        }

        private void InsertarAlumno()
        {
            var legajo = txt_nro_legajo.Text.Trim();
            var apenom = $"{txt_ape.Text.Trim()} {txt_nom.Text.Trim()}";
            var ndoc = txt_nro_doc.Text.Trim();
            var direc = txt_direccion.Text.Trim();
            var email = txt_email.Text.Trim();
            var tel = txt_telefono.Text.Trim();
            var coddoc = cmb_cod_doc.SelectedValue.ToString();
            var sexo = rad_sexo_masculino.Checked ? "M" : "F";
            var nac = dtp_fec_nac.Value.ToString("yyyy-MM-dd");
            var estciv = cmb_est_civil.Text.ToString();

            try
            {
                SQL.ExecuteNonQuery($"INSERT INTO Alumnos VALUES ({legajo}, '{apenom}', {ndoc}, '{direc}', '{email}', '{tel}', '{coddoc}', '{sexo}', '{nac}', '{estciv}')");
                MessageBox.Show("Alumno agregado correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ModificarAlumno()
        {
            var legajo = txt_nro_legajo.Text.Trim();
            var apenom = $"{txt_ape.Text.Trim()} {txt_nom.Text.Trim()}";
            var ndoc = txt_nro_doc.Text.Trim();
            var direc = txt_direccion.Text.Trim();
            var email = txt_email.Text.Trim();
            var tel = txt_telefono.Text.Trim();
            var coddoc = cmb_cod_doc.SelectedValue.ToString();
            var sexo = rad_sexo_masculino.Checked ? "M" : "F";
            var nac = dtp_fec_nac.Value.ToString("yyyy-dd-MM");
            var estciv = cmb_est_civil.Text.ToString();

            try
            {
                SQL.ExecuteNonQuery($"UPDATE Alumnos SET ape_nom = '{apenom}', nro_doc = {ndoc}, direccion = '{direc}', email = '{email}', telefono = '{tel}', cod_doc = '{coddoc}', sexo = '{sexo}', fec_nac = '{nac}', est_civil = '{estciv}' WHERE nro_legajo_a = {legajo}");
                MessageBox.Show("Alumno modificado correctamente");
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            int nroLegajo;
            if (!int.TryParse(txt_nro_legajo.Text.Trim(), out nroLegajo))
            {
                MessageBox.Show("El campo Nro. de legajo debe ser un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string apellido = txt_ape.Text.Trim();
            string nombre = txt_nom.Text.Trim();
            if (string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombre) || (apellido + nombre).Length > 254)
            {
                MessageBox.Show("Los campos Apellido y Nombre no pueden estar vacíos y su longitud total no debe exceder los 254 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int nroDoc;
            if (!int.TryParse(txt_nro_doc.Text.Trim(), out nroDoc))
            {
                MessageBox.Show("El campo Nro. de documento debe ser un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string direccion = txt_direccion.Text.Trim();
            if (string.IsNullOrEmpty(direccion) || direccion.Length > 50)
            {
                MessageBox.Show("El campo Dirección no puede estar vacío y su longitud no debe exceder los 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string email = txt_email.Text.Trim();
            if (string.IsNullOrEmpty(email) || email.Length > 255)
            {
                MessageBox.Show("El campo Email no puede estar vacío y su longitud no debe exceder los 255 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string telefono = txt_telefono.Text.Trim();
            if (string.IsNullOrEmpty(telefono) || telefono.Length > 128)
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío y su longitud no debe exceder los 128 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!rad_sexo_masculino.Checked && !rad_sexo_femenino.Checked)
            {
                MessageBox.Show("Debes seleccionar un sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmb_est_civil.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un estado civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

     
    }
}
