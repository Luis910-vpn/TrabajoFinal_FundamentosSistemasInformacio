namespace Presentacion
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdenesEstados = new System.Windows.Forms.TabPage();
            this.btnEliminarOrdenSeleccionada = new System.Windows.Forms.Button();
            this.btnEliminarFinalizados = new System.Windows.Forms.Button();
            this.btnVerTodosEstado = new System.Windows.Forms.Button();
            this.btnFiltrarEstado = new System.Windows.Forms.Button();
            this.cbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.dgOrdenesEstado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiciosTecnico = new System.Windows.Forms.TabPage();
            this.dpHasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrarTecnico = new System.Windows.Forms.Button();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.dgServiciosTecnico = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.RepuestosUsados = new System.Windows.Forms.TabPage();
            this.dgRepuestosUtilizados = new System.Windows.Forms.DataGridView();
            this.IngresosMensuales = new System.Windows.Forms.TabPage();
            this.dgIngresosMensuales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.OrdenesEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesEstado)).BeginInit();
            this.ServiciosTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiciosTecnico)).BeginInit();
            this.RepuestosUsados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestosUtilizados)).BeginInit();
            this.IngresosMensuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresosMensuales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(554, 18);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrdenesEstados);
            this.tabControl1.Controls.Add(this.ServiciosTecnico);
            this.tabControl1.Controls.Add(this.RepuestosUsados);
            this.tabControl1.Controls.Add(this.IngresosMensuales);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 413);
            this.tabControl1.TabIndex = 15;
            // 
            // OrdenesEstados
            // 
            this.OrdenesEstados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrdenesEstados.Controls.Add(this.btnEliminarOrdenSeleccionada);
            this.OrdenesEstados.Controls.Add(this.btnEliminarFinalizados);
            this.OrdenesEstados.Controls.Add(this.btnVerTodosEstado);
            this.OrdenesEstados.Controls.Add(this.btnFiltrarEstado);
            this.OrdenesEstados.Controls.Add(this.cbEstadoFiltro);
            this.OrdenesEstados.Controls.Add(this.dgOrdenesEstado);
            this.OrdenesEstados.Controls.Add(this.label2);
            this.OrdenesEstados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenesEstados.Location = new System.Drawing.Point(4, 25);
            this.OrdenesEstados.Name = "OrdenesEstados";
            this.OrdenesEstados.Padding = new System.Windows.Forms.Padding(3);
            this.OrdenesEstados.Size = new System.Drawing.Size(608, 384);
            this.OrdenesEstados.TabIndex = 0;
            this.OrdenesEstados.Text = "Órdenes por Estado";
            // 
            // btnEliminarOrdenSeleccionada
            // 
            this.btnEliminarOrdenSeleccionada.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarOrdenSeleccionada.Location = new System.Drawing.Point(147, 336);
            this.btnEliminarOrdenSeleccionada.Name = "btnEliminarOrdenSeleccionada";
            this.btnEliminarOrdenSeleccionada.Size = new System.Drawing.Size(121, 42);
            this.btnEliminarOrdenSeleccionada.TabIndex = 52;
            this.btnEliminarOrdenSeleccionada.Text = "Eliminar Orden Seleccionada";
            this.btnEliminarOrdenSeleccionada.UseVisualStyleBackColor = false;
            this.btnEliminarOrdenSeleccionada.Click += new System.EventHandler(this.btnEliminarOrdenSeleccionada_Click);
            // 
            // btnEliminarFinalizados
            // 
            this.btnEliminarFinalizados.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminarFinalizados.Location = new System.Drawing.Point(20, 336);
            this.btnEliminarFinalizados.Name = "btnEliminarFinalizados";
            this.btnEliminarFinalizados.Size = new System.Drawing.Size(121, 42);
            this.btnEliminarFinalizados.TabIndex = 51;
            this.btnEliminarFinalizados.Text = "Eliminar Todos los Finalizados";
            this.btnEliminarFinalizados.UseVisualStyleBackColor = false;
            this.btnEliminarFinalizados.Click += new System.EventHandler(this.btnEliminarFinalizados_Click);
            // 
            // btnVerTodosEstado
            // 
            this.btnVerTodosEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerTodosEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodosEstado.Location = new System.Drawing.Point(495, 24);
            this.btnVerTodosEstado.Name = "btnVerTodosEstado";
            this.btnVerTodosEstado.Size = new System.Drawing.Size(88, 23);
            this.btnVerTodosEstado.TabIndex = 4;
            this.btnVerTodosEstado.Text = "Ver Todos";
            this.btnVerTodosEstado.UseVisualStyleBackColor = false;
            this.btnVerTodosEstado.Click += new System.EventHandler(this.btnVerTodosEstado_Click);
            // 
            // btnFiltrarEstado
            // 
            this.btnFiltrarEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrarEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEstado.Location = new System.Drawing.Point(204, 23);
            this.btnFiltrarEstado.Name = "btnFiltrarEstado";
            this.btnFiltrarEstado.Size = new System.Drawing.Size(109, 23);
            this.btnFiltrarEstado.TabIndex = 3;
            this.btnFiltrarEstado.Text = "Filtrar Estado";
            this.btnFiltrarEstado.UseVisualStyleBackColor = false;
            this.btnFiltrarEstado.Click += new System.EventHandler(this.btnFiltrarEstado_Click);
            // 
            // cbEstadoFiltro
            // 
            this.cbEstadoFiltro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbEstadoFiltro.FormattingEnabled = true;
            this.cbEstadoFiltro.Location = new System.Drawing.Point(77, 24);
            this.cbEstadoFiltro.Name = "cbEstadoFiltro";
            this.cbEstadoFiltro.Size = new System.Drawing.Size(121, 23);
            this.cbEstadoFiltro.TabIndex = 2;
            // 
            // dgOrdenesEstado
            // 
            this.dgOrdenesEstado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgOrdenesEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenesEstado.Location = new System.Drawing.Point(20, 53);
            this.dgOrdenesEstado.Name = "dgOrdenesEstado";
            this.dgOrdenesEstado.Size = new System.Drawing.Size(563, 277);
            this.dgOrdenesEstado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado:";
            // 
            // ServiciosTecnico
            // 
            this.ServiciosTecnico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ServiciosTecnico.Controls.Add(this.dpHasta);
            this.ServiciosTecnico.Controls.Add(this.label5);
            this.ServiciosTecnico.Controls.Add(this.dpDesde);
            this.ServiciosTecnico.Controls.Add(this.label4);
            this.ServiciosTecnico.Controls.Add(this.btnFiltrarTecnico);
            this.ServiciosTecnico.Controls.Add(this.cbTecnico);
            this.ServiciosTecnico.Controls.Add(this.dgServiciosTecnico);
            this.ServiciosTecnico.Controls.Add(this.label3);
            this.ServiciosTecnico.Location = new System.Drawing.Point(4, 25);
            this.ServiciosTecnico.Name = "ServiciosTecnico";
            this.ServiciosTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.ServiciosTecnico.Size = new System.Drawing.Size(608, 384);
            this.ServiciosTecnico.TabIndex = 1;
            this.ServiciosTecnico.Text = "Servicios por Técnico";
            // 
            // dpHasta
            // 
            this.dpHasta.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dpHasta.CustomFormat = "dd/MM/yyyy";
            this.dpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpHasta.Location = new System.Drawing.Point(462, 18);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(117, 23);
            this.dpHasta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasta:";
            // 
            // dpDesde
            // 
            this.dpDesde.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dpDesde.CustomFormat = "dd/MM/yyyy";
            this.dpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDesde.Location = new System.Drawing.Point(285, 18);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(117, 23);
            this.dpDesde.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde:";
            // 
            // btnFiltrarTecnico
            // 
            this.btnFiltrarTecnico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrarTecnico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTecnico.Location = new System.Drawing.Point(24, 59);
            this.btnFiltrarTecnico.Name = "btnFiltrarTecnico";
            this.btnFiltrarTecnico.Size = new System.Drawing.Size(109, 23);
            this.btnFiltrarTecnico.TabIndex = 8;
            this.btnFiltrarTecnico.Text = "Filtrar Técnico";
            this.btnFiltrarTecnico.UseVisualStyleBackColor = false;
            this.btnFiltrarTecnico.Click += new System.EventHandler(this.btnFiltrarTecnico_Click);
            // 
            // cbTecnico
            // 
            this.cbTecnico.BackColor = System.Drawing.Color.LightGray;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(88, 20);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(121, 24);
            this.cbTecnico.TabIndex = 7;
            // 
            // dgServiciosTecnico
            // 
            this.dgServiciosTecnico.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgServiciosTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServiciosTecnico.Location = new System.Drawing.Point(24, 88);
            this.dgServiciosTecnico.Name = "dgServiciosTecnico";
            this.dgServiciosTecnico.Size = new System.Drawing.Size(563, 239);
            this.dgServiciosTecnico.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Técnico:";
            // 
            // RepuestosUsados
            // 
            this.RepuestosUsados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RepuestosUsados.Controls.Add(this.dgRepuestosUtilizados);
            this.RepuestosUsados.Location = new System.Drawing.Point(4, 25);
            this.RepuestosUsados.Name = "RepuestosUsados";
            this.RepuestosUsados.Size = new System.Drawing.Size(608, 384);
            this.RepuestosUsados.TabIndex = 2;
            this.RepuestosUsados.Text = "Repuestos Utilizados";
            // 
            // dgRepuestosUtilizados
            // 
            this.dgRepuestosUtilizados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRepuestosUtilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepuestosUtilizados.Location = new System.Drawing.Point(22, 25);
            this.dgRepuestosUtilizados.Name = "dgRepuestosUtilizados";
            this.dgRepuestosUtilizados.Size = new System.Drawing.Size(563, 303);
            this.dgRepuestosUtilizados.TabIndex = 7;
            // 
            // IngresosMensuales
            // 
            this.IngresosMensuales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IngresosMensuales.Controls.Add(this.dgIngresosMensuales);
            this.IngresosMensuales.Location = new System.Drawing.Point(4, 25);
            this.IngresosMensuales.Name = "IngresosMensuales";
            this.IngresosMensuales.Size = new System.Drawing.Size(608, 384);
            this.IngresosMensuales.TabIndex = 3;
            this.IngresosMensuales.Text = "Ingresos Mensuales";
            // 
            // dgIngresosMensuales
            // 
            this.dgIngresosMensuales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgIngresosMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngresosMensuales.Location = new System.Drawing.Point(23, 23);
            this.dgIngresosMensuales.Name = "dgIngresosMensuales";
            this.dgIngresosMensuales.Size = new System.Drawing.Size(563, 303);
            this.dgIngresosMensuales.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reportes";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(643, 498);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.OrdenesEstados.ResumeLayout(false);
            this.OrdenesEstados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesEstado)).EndInit();
            this.ServiciosTecnico.ResumeLayout(false);
            this.ServiciosTecnico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiciosTecnico)).EndInit();
            this.RepuestosUsados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestosUtilizados)).EndInit();
            this.IngresosMensuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresosMensuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdenesEstados;
        private System.Windows.Forms.Button btnVerTodosEstado;
        private System.Windows.Forms.Button btnFiltrarEstado;
        private System.Windows.Forms.ComboBox cbEstadoFiltro;
        private System.Windows.Forms.DataGridView dgOrdenesEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ServiciosTecnico;
        private System.Windows.Forms.DateTimePicker dpHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrarTecnico;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.DataGridView dgServiciosTecnico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage RepuestosUsados;
        private System.Windows.Forms.DataGridView dgRepuestosUtilizados;
        private System.Windows.Forms.TabPage IngresosMensuales;
        private System.Windows.Forms.DataGridView dgIngresosMensuales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarOrdenSeleccionada;
        private System.Windows.Forms.Button btnEliminarFinalizados;
    }
}