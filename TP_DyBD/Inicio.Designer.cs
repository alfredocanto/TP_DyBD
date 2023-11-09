namespace TP_DyBD
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosInscriptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosPresentesPorTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosAprobadosPorTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosDetalladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(730, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.registrosDeExamenToolStripMenuItem});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // registrosDeExamenToolStripMenuItem
            // 
            this.registrosDeExamenToolStripMenuItem.Name = "registrosDeExamenToolStripMenuItem";
            this.registrosDeExamenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrosDeExamenToolStripMenuItem.Text = "Registros de Examen";
            this.registrosDeExamenToolStripMenuItem.Click += new System.EventHandler(this.registrosDeExamenToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem1,
            this.turnosToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosInscriptosToolStripMenuItem,
            this.alumnosPresentesPorTurnoToolStripMenuItem,
            this.alumnosAprobadosPorTurnoToolStripMenuItem});
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.alumnosToolStripMenuItem1.Text = "Alumnos";
            // 
            // alumnosInscriptosToolStripMenuItem
            // 
            this.alumnosInscriptosToolStripMenuItem.Name = "alumnosInscriptosToolStripMenuItem";
            this.alumnosInscriptosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.alumnosInscriptosToolStripMenuItem.Text = "Alumnos Inscriptos";
            this.alumnosInscriptosToolStripMenuItem.Click += new System.EventHandler(this.alumnosInscriptosToolStripMenuItem_Click);
            // 
            // alumnosPresentesPorTurnoToolStripMenuItem
            // 
            this.alumnosPresentesPorTurnoToolStripMenuItem.Name = "alumnosPresentesPorTurnoToolStripMenuItem";
            this.alumnosPresentesPorTurnoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.alumnosPresentesPorTurnoToolStripMenuItem.Text = "Alumnos Presentes por Turno";
            this.alumnosPresentesPorTurnoToolStripMenuItem.Click += new System.EventHandler(this.alumnosPresentesPorTurnoToolStripMenuItem_Click);
            // 
            // alumnosAprobadosPorTurnoToolStripMenuItem
            // 
            this.alumnosAprobadosPorTurnoToolStripMenuItem.Name = "alumnosAprobadosPorTurnoToolStripMenuItem";
            this.alumnosAprobadosPorTurnoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.alumnosAprobadosPorTurnoToolStripMenuItem.Text = "Alumnos Aprobados por Turno";
            this.alumnosAprobadosPorTurnoToolStripMenuItem.Click += new System.EventHandler(this.alumnosAprobadosPorTurnoToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnosDetalladosToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // turnosDetalladosToolStripMenuItem
            // 
            this.turnosDetalladosToolStripMenuItem.Name = "turnosDetalladosToolStripMenuItem";
            this.turnosDetalladosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.turnosDetalladosToolStripMenuItem.Text = "Turnos detallados";
            this.turnosDetalladosToolStripMenuItem.Click += new System.EventHandler(this.turnosDetalladosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(332, 417);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 462);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosInscriptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosPresentesPorTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosAprobadosPorTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosDetalladosToolStripMenuItem;
    }
}

