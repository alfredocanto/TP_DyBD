namespace TP_DyBD
{
    partial class AgregarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_est_civil = new System.Windows.Forms.ComboBox();
            this.dtp_fec_nac = new System.Windows.Forms.DateTimePicker();
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.rad_sexo_masculino = new System.Windows.Forms.RadioButton();
            this.rad_sexo_femenino = new System.Windows.Forms.RadioButton();
            this.cmb_cod_doc = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.txt_nro_legajo = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_est_civil = new System.Windows.Forms.Label();
            this.lbl_fec_nac = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_cod_doc = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.lbl_ape_nom = new System.Windows.Forms.Label();
            this.lbl_nro_legajo = new System.Windows.Forms.Label();
            this.gb_sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_est_civil
            // 
            this.cmb_est_civil.FormattingEnabled = true;
            this.cmb_est_civil.Location = new System.Drawing.Point(187, 192);
            this.cmb_est_civil.Name = "cmb_est_civil";
            this.cmb_est_civil.Size = new System.Drawing.Size(206, 21);
            this.cmb_est_civil.TabIndex = 46;
            // 
            // dtp_fec_nac
            // 
            this.dtp_fec_nac.CustomFormat = "";
            this.dtp_fec_nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec_nac.Location = new System.Drawing.Point(187, 166);
            this.dtp_fec_nac.Name = "dtp_fec_nac";
            this.dtp_fec_nac.Size = new System.Drawing.Size(206, 20);
            this.dtp_fec_nac.TabIndex = 45;
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rad_sexo_masculino);
            this.gb_sexo.Controls.Add(this.rad_sexo_femenino);
            this.gb_sexo.Location = new System.Drawing.Point(187, 124);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(206, 36);
            this.gb_sexo.TabIndex = 44;
            this.gb_sexo.TabStop = false;
            // 
            // rad_sexo_masculino
            // 
            this.rad_sexo_masculino.AutoSize = true;
            this.rad_sexo_masculino.Location = new System.Drawing.Point(115, 13);
            this.rad_sexo_masculino.Name = "rad_sexo_masculino";
            this.rad_sexo_masculino.Size = new System.Drawing.Size(73, 17);
            this.rad_sexo_masculino.TabIndex = 1;
            this.rad_sexo_masculino.TabStop = true;
            this.rad_sexo_masculino.Text = "Masculino";
            this.rad_sexo_masculino.UseVisualStyleBackColor = true;
            // 
            // rad_sexo_femenino
            // 
            this.rad_sexo_femenino.AutoSize = true;
            this.rad_sexo_femenino.Location = new System.Drawing.Point(10, 13);
            this.rad_sexo_femenino.Name = "rad_sexo_femenino";
            this.rad_sexo_femenino.Size = new System.Drawing.Size(71, 17);
            this.rad_sexo_femenino.TabIndex = 0;
            this.rad_sexo_femenino.TabStop = true;
            this.rad_sexo_femenino.Text = "Femenino";
            this.rad_sexo_femenino.UseVisualStyleBackColor = true;
            // 
            // cmb_cod_doc
            // 
            this.cmb_cod_doc.FormattingEnabled = true;
            this.cmb_cod_doc.Location = new System.Drawing.Point(187, 71);
            this.cmb_cod_doc.Name = "cmb_cod_doc";
            this.cmb_cod_doc.Size = new System.Drawing.Size(206, 21);
            this.cmb_cod_doc.TabIndex = 43;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(187, 271);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(206, 20);
            this.txt_telefono.TabIndex = 42;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(187, 245);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(206, 20);
            this.txt_email.TabIndex = 41;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(187, 219);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(206, 20);
            this.txt_direccion.TabIndex = 40;
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(187, 98);
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(206, 20);
            this.txt_nro_doc.TabIndex = 39;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(293, 45);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 38;
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(187, 45);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(100, 20);
            this.txt_ape.TabIndex = 37;
            // 
            // txt_nro_legajo
            // 
            this.txt_nro_legajo.Location = new System.Drawing.Point(187, 19);
            this.txt_nro_legajo.Name = "txt_nro_legajo";
            this.txt_nro_legajo.Size = new System.Drawing.Size(206, 20);
            this.txt_nro_legajo.TabIndex = 36;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(237, 337);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 35;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(318, 337);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_est_civil
            // 
            this.lbl_est_civil.AutoSize = true;
            this.lbl_est_civil.Location = new System.Drawing.Point(17, 195);
            this.lbl_est_civil.Name = "lbl_est_civil";
            this.lbl_est_civil.Size = new System.Drawing.Size(47, 13);
            this.lbl_est_civil.TabIndex = 33;
            this.lbl_est_civil.Text = "Est. Civil";
            // 
            // lbl_fec_nac
            // 
            this.lbl_fec_nac.AutoSize = true;
            this.lbl_fec_nac.Location = new System.Drawing.Point(18, 172);
            this.lbl_fec_nac.Name = "lbl_fec_nac";
            this.lbl_fec_nac.Size = new System.Drawing.Size(63, 13);
            this.lbl_fec_nac.TabIndex = 32;
            this.lbl_fec_nac.Text = "Fecha Nac.";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(18, 139);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 31;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_cod_doc
            // 
            this.lbl_cod_doc.AutoSize = true;
            this.lbl_cod_doc.Location = new System.Drawing.Point(18, 74);
            this.lbl_cod_doc.Name = "lbl_cod_doc";
            this.lbl_cod_doc.Size = new System.Drawing.Size(54, 13);
            this.lbl_cod_doc.TabIndex = 30;
            this.lbl_cod_doc.Text = "Tipo Doc.";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(18, 274);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 29;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(18, 248);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 28;
            this.lbl_email.Text = "Email";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(18, 222);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 27;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Location = new System.Drawing.Point(18, 101);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(53, 13);
            this.lbl_nro_doc.TabIndex = 26;
            this.lbl_nro_doc.Text = "Nro. Doc.";
            // 
            // lbl_ape_nom
            // 
            this.lbl_ape_nom.AutoSize = true;
            this.lbl_ape_nom.Location = new System.Drawing.Point(18, 48);
            this.lbl_ape_nom.Name = "lbl_ape_nom";
            this.lbl_ape_nom.Size = new System.Drawing.Size(92, 13);
            this.lbl_ape_nom.TabIndex = 25;
            this.lbl_ape_nom.Text = "Apellido y Nombre";
            // 
            // lbl_nro_legajo
            // 
            this.lbl_nro_legajo.AutoSize = true;
            this.lbl_nro_legajo.Location = new System.Drawing.Point(18, 22);
            this.lbl_nro_legajo.Name = "lbl_nro_legajo";
            this.lbl_nro_legajo.Size = new System.Drawing.Size(62, 13);
            this.lbl_nro_legajo.TabIndex = 24;
            this.lbl_nro_legajo.Text = "Nro. Legajo";
            // 
            // AgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 395);
            this.Controls.Add(this.cmb_est_civil);
            this.Controls.Add(this.dtp_fec_nac);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.cmb_cod_doc);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nro_doc);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.txt_nro_legajo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_est_civil);
            this.Controls.Add(this.lbl_fec_nac);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_cod_doc);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_nro_doc);
            this.Controls.Add(this.lbl_ape_nom);
            this.Controls.Add(this.lbl_nro_legajo);
            this.Name = "AgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAlumno";
            this.Load += new System.EventHandler(this.AgregarAlumno_Load);
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_est_civil;
        private System.Windows.Forms.DateTimePicker dtp_fec_nac;
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.RadioButton rad_sexo_masculino;
        private System.Windows.Forms.RadioButton rad_sexo_femenino;
        private System.Windows.Forms.ComboBox cmb_cod_doc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.TextBox txt_nro_legajo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_est_civil;
        private System.Windows.Forms.Label lbl_fec_nac;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_cod_doc;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_ape_nom;
        private System.Windows.Forms.Label lbl_nro_legajo;
    }
}