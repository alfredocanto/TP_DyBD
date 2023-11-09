namespace TP_DyBD
{
    partial class AgregarMateria
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_nro_legajo_p = new System.Windows.Forms.ComboBox();
            this.txt_desc_carrera = new System.Windows.Forms.TextBox();
            this.txt_desc_materia = new System.Windows.Forms.TextBox();
            this.txt_cod_materia = new System.Windows.Forms.TextBox();
            this.lbl_nro_legajo_p = new System.Windows.Forms.Label();
            this.lbl_desc_carrera = new System.Windows.Forms.Label();
            this.lbl_desc_materia = new System.Windows.Forms.Label();
            this.lbl_cod_materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(320, 176);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 21;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(239, 176);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_nro_legajo_p
            // 
            this.cmb_nro_legajo_p.FormattingEnabled = true;
            this.cmb_nro_legajo_p.Location = new System.Drawing.Point(189, 102);
            this.cmb_nro_legajo_p.Name = "cmb_nro_legajo_p";
            this.cmb_nro_legajo_p.Size = new System.Drawing.Size(206, 21);
            this.cmb_nro_legajo_p.TabIndex = 19;
            // 
            // txt_desc_carrera
            // 
            this.txt_desc_carrera.Location = new System.Drawing.Point(189, 76);
            this.txt_desc_carrera.Name = "txt_desc_carrera";
            this.txt_desc_carrera.Size = new System.Drawing.Size(206, 20);
            this.txt_desc_carrera.TabIndex = 18;
            // 
            // txt_desc_materia
            // 
            this.txt_desc_materia.Location = new System.Drawing.Point(189, 50);
            this.txt_desc_materia.Name = "txt_desc_materia";
            this.txt_desc_materia.Size = new System.Drawing.Size(206, 20);
            this.txt_desc_materia.TabIndex = 17;
            // 
            // txt_cod_materia
            // 
            this.txt_cod_materia.Location = new System.Drawing.Point(189, 24);
            this.txt_cod_materia.Name = "txt_cod_materia";
            this.txt_cod_materia.Size = new System.Drawing.Size(206, 20);
            this.txt_cod_materia.TabIndex = 15;
            // 
            // lbl_nro_legajo_p
            // 
            this.lbl_nro_legajo_p.AutoSize = true;
            this.lbl_nro_legajo_p.Location = new System.Drawing.Point(20, 105);
            this.lbl_nro_legajo_p.Name = "lbl_nro_legajo_p";
            this.lbl_nro_legajo_p.Size = new System.Drawing.Size(104, 13);
            this.lbl_nro_legajo_p.TabIndex = 14;
            this.lbl_nro_legajo_p.Text = "Nro. Legajo Profesor";
            // 
            // lbl_desc_carrera
            // 
            this.lbl_desc_carrera.AutoSize = true;
            this.lbl_desc_carrera.Location = new System.Drawing.Point(20, 79);
            this.lbl_desc_carrera.Name = "lbl_desc_carrera";
            this.lbl_desc_carrera.Size = new System.Drawing.Size(72, 13);
            this.lbl_desc_carrera.TabIndex = 13;
            this.lbl_desc_carrera.Text = "Desc. Carrera";
            // 
            // lbl_desc_materia
            // 
            this.lbl_desc_materia.AutoSize = true;
            this.lbl_desc_materia.Location = new System.Drawing.Point(20, 53);
            this.lbl_desc_materia.Name = "lbl_desc_materia";
            this.lbl_desc_materia.Size = new System.Drawing.Size(73, 13);
            this.lbl_desc_materia.TabIndex = 12;
            this.lbl_desc_materia.Text = "Desc. Materia";
            // 
            // lbl_cod_materia
            // 
            this.lbl_cod_materia.AutoSize = true;
            this.lbl_cod_materia.Location = new System.Drawing.Point(20, 27);
            this.lbl_cod_materia.Name = "lbl_cod_materia";
            this.lbl_cod_materia.Size = new System.Drawing.Size(67, 13);
            this.lbl_cod_materia.TabIndex = 11;
            this.lbl_cod_materia.Text = "Cod. Materia";
            // 
            // AgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 221);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cmb_nro_legajo_p);
            this.Controls.Add(this.txt_desc_carrera);
            this.Controls.Add(this.txt_desc_materia);
            this.Controls.Add(this.txt_cod_materia);
            this.Controls.Add(this.lbl_nro_legajo_p);
            this.Controls.Add(this.lbl_desc_carrera);
            this.Controls.Add(this.lbl_desc_materia);
            this.Controls.Add(this.lbl_cod_materia);
            this.Name = "AgregarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMateria";
            this.Load += new System.EventHandler(this.AgregarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cmb_nro_legajo_p;
        private System.Windows.Forms.TextBox txt_desc_carrera;
        private System.Windows.Forms.TextBox txt_desc_materia;
        private System.Windows.Forms.TextBox txt_cod_materia;
        private System.Windows.Forms.Label lbl_nro_legajo_p;
        private System.Windows.Forms.Label lbl_desc_carrera;
        private System.Windows.Forms.Label lbl_desc_materia;
        private System.Windows.Forms.Label lbl_cod_materia;
    }
}