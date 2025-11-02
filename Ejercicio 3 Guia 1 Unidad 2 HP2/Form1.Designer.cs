namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    partial class FrmSistemaCursos
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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNumeroEstudiantes = new System.Windows.Forms.TextBox();
            this.lblNumeroEstudiantes = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDuracionCurso = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtDuracionCurso = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(215, 18);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(198, 24);
            this.cboTipo.TabIndex = 37;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(148, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 36;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNumeroEstudiantes
            // 
            this.txtNumeroEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumeroEstudiantes.Location = new System.Drawing.Point(218, 140);
            this.txtNumeroEstudiantes.Name = "txtNumeroEstudiantes";
            this.txtNumeroEstudiantes.Size = new System.Drawing.Size(198, 22);
            this.txtNumeroEstudiantes.TabIndex = 34;
            // 
            // lblNumeroEstudiantes
            // 
            this.lblNumeroEstudiantes.AutoSize = true;
            this.lblNumeroEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumeroEstudiantes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumeroEstudiantes.Location = new System.Drawing.Point(3, 140);
            this.lblNumeroEstudiantes.Name = "lblNumeroEstudiantes";
            this.lblNumeroEstudiantes.Size = new System.Drawing.Size(195, 20);
            this.lblNumeroEstudiantes.TabIndex = 33;
            this.lblNumeroEstudiantes.Text = "Numero de estudiantes";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMostrar.Location = new System.Drawing.Point(415, 411);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(177, 77);
            this.btnMostrar.TabIndex = 32;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAñadir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAñadir.Location = new System.Drawing.Point(183, 410);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(195, 78);
            this.btnAñadir.TabIndex = 31;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lstCursos
            // 
            this.lstCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.ItemHeight = 16;
            this.lstCursos.Location = new System.Drawing.Point(435, 42);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(523, 228);
            this.lstCursos.TabIndex = 30;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombreCurso.Location = new System.Drawing.Point(215, 212);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(198, 22);
            this.txtNombreCurso.TabIndex = 29;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombreCurso.Location = new System.Drawing.Point(49, 214);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(149, 20);
            this.lblNombreCurso.TabIndex = 28;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // lblDuracionCurso
            // 
            this.lblDuracionCurso.AutoSize = true;
            this.lblDuracionCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDuracionCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDuracionCurso.Location = new System.Drawing.Point(35, 350);
            this.lblDuracionCurso.Name = "lblDuracionCurso";
            this.lblDuracionCurso.Size = new System.Drawing.Size(159, 20);
            this.lblDuracionCurso.TabIndex = 27;
            this.lblDuracionCurso.Text = "Duracion del curso";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombreDocente.Location = new System.Drawing.Point(215, 285);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(198, 22);
            this.txtNombreDocente.TabIndex = 26;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreDocente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombreDocente.Location = new System.Drawing.Point(28, 285);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(170, 20);
            this.lblNombreDocente.TabIndex = 25;
            this.lblNombreDocente.Text = "Nombre del docente";
            // 
            // txtDuracionCurso
            // 
            this.txtDuracionCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDuracionCurso.Location = new System.Drawing.Point(215, 350);
            this.txtDuracionCurso.Name = "txtDuracionCurso";
            this.txtDuracionCurso.Size = new System.Drawing.Size(198, 22);
            this.txtDuracionCurso.TabIndex = 38;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(215, 80);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(198, 22);
            this.txtPrecio.TabIndex = 40;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecio.Location = new System.Drawing.Point(132, 82);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 20);
            this.lblPrecio.TabIndex = 39;
            this.lblPrecio.Text = "Precio";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Orange;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(626, 410);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 77);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmSistemaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 529);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDuracionCurso);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNumeroEstudiantes);
            this.Controls.Add(this.lblNumeroEstudiantes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblDuracionCurso);
            this.Controls.Add(this.txtNombreDocente);
            this.Controls.Add(this.lblNombreDocente);
            this.Name = "FrmSistemaCursos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNumeroEstudiantes;
        private System.Windows.Forms.Label lblNumeroEstudiantes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDuracionCurso;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtDuracionCurso;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnEliminar;
    }
}

