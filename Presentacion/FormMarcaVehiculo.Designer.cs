namespace Presentacion
{
    partial class FormMarcaVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcaVehiculo));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgMarcas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarMarca = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadirModelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(450, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 84;
            this.pictureBox6.TabStop = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(366, 131);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(141, 25);
            this.btnMostrarTodos.TabIndex = 83;
            this.btnMostrarTodos.Text = "Listar todos las Marcas";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminar.Location = new System.Drawing.Point(194, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 82;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(106, 131);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 27);
            this.btnModificar.TabIndex = 81;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 36);
            this.label8.TabIndex = 80;
            this.label8.Text = "Marcas de Vehiculos";
            // 
            // dgMarcas
            // 
            this.dgMarcas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarcas.Location = new System.Drawing.Point(21, 166);
            this.dgMarcas.Name = "dgMarcas";
            this.dgMarcas.Size = new System.Drawing.Size(486, 205);
            this.dgMarcas.TabIndex = 79;
            this.dgMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMarcas_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(432, 377);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 78;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarMarca
            // 
            this.btnRegistrarMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarMarca.Location = new System.Drawing.Point(21, 131);
            this.btnRegistrarMarca.Name = "btnRegistrarMarca";
            this.btnRegistrarMarca.Size = new System.Drawing.Size(79, 27);
            this.btnRegistrarMarca.TabIndex = 77;
            this.btnRegistrarMarca.Text = "Registrar";
            this.btnRegistrarMarca.UseVisualStyleBackColor = false;
            this.btnRegistrarMarca.Click += new System.EventHandler(this.btnRegistrarMarca_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.Color.LightGray;
            this.tbMarca.Location = new System.Drawing.Point(132, 91);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(141, 20);
            this.tbMarca.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Marca del Vehiculo:";
            // 
            // btnAñadirModelo
            // 
            this.btnAñadirModelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAñadirModelo.Location = new System.Drawing.Point(21, 375);
            this.btnAñadirModelo.Name = "btnAñadirModelo";
            this.btnAñadirModelo.Size = new System.Drawing.Size(104, 27);
            this.btnAñadirModelo.TabIndex = 85;
            this.btnAñadirModelo.Text = "Añadir Modelo";
            this.btnAñadirModelo.UseVisualStyleBackColor = false;
            this.btnAñadirModelo.Click += new System.EventHandler(this.btnAñadirModelo_Click);
            // 
            // FormMarcaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 417);
            this.Controls.Add(this.btnAñadirModelo);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgMarcas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarMarca);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label3);
            this.Name = "FormMarcaVehiculo";
            this.Text = "Marcas de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgMarcas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAñadirModelo;
    }
}