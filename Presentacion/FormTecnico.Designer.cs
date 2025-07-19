namespace Presentacion
{
    partial class FormTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecnico));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbDisponible = new System.Windows.Forms.CheckBox();
            this.dgTecnicos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarTecnico = new System.Windows.Forms.Button();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(423, 191);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(141, 25);
            this.btnMostrarTodos.TabIndex = 52;
            this.btnMostrarTodos.Text = "Listar todos los Técnicos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.Location = new System.Drawing.Point(274, 436);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(126, 438);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(142, 20);
            this.tbBuscarNombre.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Buscar por Nombre: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(290, 190);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 27);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminar.Location = new System.Drawing.Point(202, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 27);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(114, 191);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 27);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 36);
            this.label2.TabIndex = 45;
            this.label2.Text = "Gestión de Técnicos";
            // 
            // chbDisponible
            // 
            this.chbDisponible.AutoSize = true;
            this.chbDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbDisponible.Location = new System.Drawing.Point(342, 123);
            this.chbDisponible.Name = "chbDisponible";
            this.chbDisponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbDisponible.Size = new System.Drawing.Size(75, 17);
            this.chbDisponible.TabIndex = 44;
            this.chbDisponible.Text = ":Disponible";
            this.chbDisponible.UseVisualStyleBackColor = true;
            // 
            // dgTecnicos
            // 
            this.dgTecnicos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTecnicos.Location = new System.Drawing.Point(26, 224);
            this.dgTecnicos.Name = "dgTecnicos";
            this.dgTecnicos.Size = new System.Drawing.Size(538, 206);
            this.dgTecnicos.TabIndex = 43;
            this.dgTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTecnicos_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(482, 436);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarTecnico
            // 
            this.btnRegistrarTecnico.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarTecnico.Location = new System.Drawing.Point(26, 192);
            this.btnRegistrarTecnico.Name = "btnRegistrarTecnico";
            this.btnRegistrarTecnico.Size = new System.Drawing.Size(82, 27);
            this.btnRegistrarTecnico.TabIndex = 41;
            this.btnRegistrarTecnico.Text = "Registrar";
            this.btnRegistrarTecnico.UseVisualStyleBackColor = false;
            this.btnRegistrarTecnico.Click += new System.EventHandler(this.btnRegistrarTecnico_Click);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.BackColor = System.Drawing.Color.LightGray;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Mecánica general",
            "Electricidad y electrónica automotriz",
            "Diagnóstico por escáner",
            "Sistemas de inyección y carburación",
            "Aire acondicionado y climatización",
            "Latonería y pintura",
            "Neumáticos y alineación",
            "Sistemas híbridos y eléctricos"});
            this.cbEspecialidad.Location = new System.Drawing.Point(99, 153);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(198, 21);
            this.cbEspecialidad.TabIndex = 40;
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackColor = System.Drawing.Color.LightGray;
            this.tbApellidos.Location = new System.Drawing.Point(99, 120);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(198, 20);
            this.tbApellidos.TabIndex = 39;
            // 
            // tbNombres
            // 
            this.tbNombres.BackColor = System.Drawing.Color.LightGray;
            this.tbNombres.Location = new System.Drawing.Point(99, 87);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(198, 20);
            this.tbNombres.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombres:";
            // 
            // FormTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(590, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbDisponible);
            this.Controls.Add(this.dgTecnicos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarTecnico);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormTecnico";
            this.Text = "Técnicos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbDisponible;
        private System.Windows.Forms.DataGridView dgTecnicos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarTecnico;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}