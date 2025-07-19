namespace Presentacion
{
    partial class FormVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculo));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscarPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgVehiculos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.cbTipoMotor = new System.Windows.Forms.ComboBox();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadirMarca = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(618, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.Location = new System.Drawing.Point(273, 413);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscarPlaca
            // 
            this.tbBuscarPlaca.Location = new System.Drawing.Point(121, 415);
            this.tbBuscarPlaca.Name = "tbBuscarPlaca";
            this.tbBuscarPlaca.Size = new System.Drawing.Size(146, 20);
            this.tbBuscarPlaca.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Buscar por Placa: ";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(518, 167);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(141, 25);
            this.btnMostrarTodos.TabIndex = 48;
            this.btnMostrarTodos.Text = "Listar todos los Vehículos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(374, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 27);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminar.Location = new System.Drawing.Point(286, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(110, 167);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 27);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 36);
            this.label8.TabIndex = 44;
            this.label8.Text = "Gestión de Vehiculos";
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Location = new System.Drawing.Point(25, 202);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.Size = new System.Drawing.Size(634, 205);
            this.dgVehiculos.TabIndex = 43;
            this.dgVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehiculos_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(584, 413);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(25, 167);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(79, 27);
            this.btnRegistrarVehiculo.TabIndex = 41;
            this.btnRegistrarVehiculo.Text = "Registrar";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = false;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // cbTipoMotor
            // 
            this.cbTipoMotor.BackColor = System.Drawing.Color.LightGray;
            this.cbTipoMotor.FormattingEnabled = true;
            this.cbTipoMotor.Items.AddRange(new object[] {
            "Gasolina",
            "Diésel",
            "Eléctrico",
            "Híbrido",
            "Pila de combustible de hidrógeno"});
            this.cbTipoMotor.Location = new System.Drawing.Point(518, 92);
            this.cbTipoMotor.Name = "cbTipoMotor";
            this.cbTipoMotor.Size = new System.Drawing.Size(141, 21);
            this.cbTipoMotor.TabIndex = 40;
            // 
            // tbAnio
            // 
            this.tbAnio.BackColor = System.Drawing.Color.LightGray;
            this.tbAnio.Location = new System.Drawing.Point(273, 127);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(141, 20);
            this.tbAnio.TabIndex = 39;
            // 
            // tbPlaca
            // 
            this.tbPlaca.BackColor = System.Drawing.Color.LightGray;
            this.tbPlaca.Location = new System.Drawing.Point(71, 92);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(141, 20);
            this.tbPlaca.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipo de motor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Placa:";
            // 
            // btnAñadirMarca
            // 
            this.btnAñadirMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAñadirMarca.Location = new System.Drawing.Point(198, 167);
            this.btnAñadirMarca.Name = "btnAñadirMarca";
            this.btnAñadirMarca.Size = new System.Drawing.Size(82, 27);
            this.btnAñadirMarca.TabIndex = 53;
            this.btnAñadirMarca.Text = "Añadir Marca";
            this.btnAñadirMarca.UseVisualStyleBackColor = false;
            this.btnAñadirMarca.Click += new System.EventHandler(this.btnAñadirMarca_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.LightGray;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(71, 127);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(141, 21);
            this.cbMarca.TabIndex = 54;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.LightGray;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(273, 91);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(141, 21);
            this.cbModelo.TabIndex = 55;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(689, 449);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.btnAñadirMarca);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscarPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgVehiculos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarVehiculo);
            this.Controls.Add(this.cbTipoMotor);
            this.Controls.Add(this.tbAnio);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormVehiculo";
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscarPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgVehiculos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.ComboBox cbTipoMotor;
        private System.Windows.Forms.TextBox tbAnio;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAñadirMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
    }
}