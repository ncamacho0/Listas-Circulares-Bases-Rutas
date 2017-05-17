namespace ListaCircular
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.btnEliminarNombre = new System.Windows.Forms.Button();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnInsertarDespuesDe = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreRecorrer = new System.Windows.Forms.TextBox();
            this.txtHoraInicioRecorrer = new System.Windows.Forms.TextBox();
            this.txtHoraFinRecorrer = new System.Windows.Forms.TextBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.txtRecorrer = new System.Windows.Forms.TextBox();
            this.txtBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(81, 89);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(135, 257);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(100, 20);
            this.txtInsertar.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(15, 153);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarPorNombre.TabIndex = 7;
            this.btnBuscarPorNombre.Text = "Buscar por nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombre.Click += new System.EventHandler(this.btnBuscarPorNombre_Click);
            // 
            // btnEliminarNombre
            // 
            this.btnEliminarNombre.Location = new System.Drawing.Point(15, 194);
            this.btnEliminarNombre.Name = "btnEliminarNombre";
            this.btnEliminarNombre.Size = new System.Drawing.Size(75, 36);
            this.btnEliminarNombre.TabIndex = 8;
            this.btnEliminarNombre.Text = "Eliminar por nombre";
            this.btnEliminarNombre.UseVisualStyleBackColor = true;
            this.btnEliminarNombre.Click += new System.EventHandler(this.btnEliminarNombre_Click);
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(106, 124);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(75, 35);
            this.btnAgregarInicio.TabIndex = 9;
            this.btnAgregarInicio.Text = "Agregar al Inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(458, 31);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(106, 194);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(75, 36);
            this.btnEliminarInicio.TabIndex = 11;
            this.btnEliminarInicio.Text = "Eliminar Inicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnInsertarDespuesDe
            // 
            this.btnInsertarDespuesDe.Location = new System.Drawing.Point(15, 251);
            this.btnInsertarDespuesDe.Name = "btnInsertarDespuesDe";
            this.btnInsertarDespuesDe.Size = new System.Drawing.Size(114, 26);
            this.btnInsertarDespuesDe.TabIndex = 12;
            this.btnInsertarDespuesDe.Text = "Insertar despues de";
            this.btnInsertarDespuesDe.UseVisualStyleBackColor = true;
            this.btnInsertarDespuesDe.Click += new System.EventHandler(this.btnInsertarDespuesDe_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(539, 33);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(193, 155);
            this.txtReporte.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora de inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hora de fin";
            // 
            // txtNombreRecorrer
            // 
            this.txtNombreRecorrer.Location = new System.Drawing.Point(347, 203);
            this.txtNombreRecorrer.Name = "txtNombreRecorrer";
            this.txtNombreRecorrer.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRecorrer.TabIndex = 17;
            // 
            // txtHoraInicioRecorrer
            // 
            this.txtHoraInicioRecorrer.Location = new System.Drawing.Point(347, 229);
            this.txtHoraInicioRecorrer.Name = "txtHoraInicioRecorrer";
            this.txtHoraInicioRecorrer.Size = new System.Drawing.Size(100, 20);
            this.txtHoraInicioRecorrer.TabIndex = 18;
            // 
            // txtHoraFinRecorrer
            // 
            this.txtHoraFinRecorrer.Location = new System.Drawing.Point(347, 255);
            this.txtHoraFinRecorrer.Name = "txtHoraFinRecorrer";
            this.txtHoraFinRecorrer.Size = new System.Drawing.Size(100, 20);
            this.txtHoraFinRecorrer.TabIndex = 19;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(266, 291);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 20;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // txtRecorrer
            // 
            this.txtRecorrer.Location = new System.Drawing.Point(468, 203);
            this.txtRecorrer.Multiline = true;
            this.txtRecorrer.Name = "txtRecorrer";
            this.txtRecorrer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecorrer.Size = new System.Drawing.Size(291, 112);
            this.txtRecorrer.TabIndex = 21;
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Location = new System.Drawing.Point(266, 117);
            this.txtBuscarPorNombre.Multiline = true;
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(181, 42);
            this.txtBuscarPorNombre.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Buscar por nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarPorNombre);
            this.Controls.Add(this.txtRecorrer);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtHoraFinRecorrer);
            this.Controls.Add(this.txtHoraInicioRecorrer);
            this.Controls.Add(this.txtNombreRecorrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.btnInsertarDespuesDe);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnEliminarNombre);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.Button btnEliminarNombre;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button btnInsertarDespuesDe;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreRecorrer;
        private System.Windows.Forms.TextBox txtHoraInicioRecorrer;
        private System.Windows.Forms.TextBox txtHoraFinRecorrer;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.TextBox txtRecorrer;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.Label label6;
    }
}

