namespace Presentacion
{
    partial class FormModeloVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModeloVehiculo));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgModelos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarModelo = new System.Windows.Forms.Button();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(452, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(368, 134);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(141, 25);
            this.btnMostrarTodos.TabIndex = 70;
            this.btnMostrarTodos.Text = "Listar todos los Modelos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminar.Location = new System.Drawing.Point(196, 134);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(108, 134);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 27);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 36);
            this.label8.TabIndex = 66;
            this.label8.Text = "Modelos de Vehiculos";
            // 
            // dgModelos
            // 
            this.dgModelos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModelos.Location = new System.Drawing.Point(23, 169);
            this.dgModelos.Name = "dgModelos";
            this.dgModelos.Size = new System.Drawing.Size(486, 205);
            this.dgModelos.TabIndex = 65;
            this.dgModelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModelos_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(434, 380);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 64;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarModelo
            // 
            this.btnRegistrarModelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarModelo.Location = new System.Drawing.Point(23, 134);
            this.btnRegistrarModelo.Name = "btnRegistrarModelo";
            this.btnRegistrarModelo.Size = new System.Drawing.Size(79, 27);
            this.btnRegistrarModelo.TabIndex = 63;
            this.btnRegistrarModelo.Text = "Registrar";
            this.btnRegistrarModelo.UseVisualStyleBackColor = false;
            this.btnRegistrarModelo.Click += new System.EventHandler(this.btnRegistrarModelo_Click);
            // 
            // tbModelo
            // 
            this.tbModelo.BackColor = System.Drawing.Color.LightGray;
            this.tbModelo.Location = new System.Drawing.Point(134, 94);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(141, 20);
            this.tbModelo.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre del Modelo:";
            // 
            // FormModeloVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(533, 417);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgModelos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarModelo);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label3);
            this.Name = "FormModeloVehiculo";
            this.Text = "Modelos de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgModelos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label3;
    }
}