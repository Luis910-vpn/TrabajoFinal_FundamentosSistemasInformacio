namespace Presentacion
{
    partial class FormOrdenServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenServicio));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnQuitarSeleccionado = new System.Windows.Forms.Button();
            this.tbCantidadRepuesto = new System.Windows.Forms.TextBox();
            this.cbRepuesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarOrden = new System.Windows.Forms.Button();
            this.dgDetalleRepuestos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarRepuesto = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(473, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(433, 505);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "--";
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Enabled = false;
            this.chkDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDisponible.Location = new System.Drawing.Point(210, 137);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDisponible.Size = new System.Drawing.Size(75, 17);
            this.chkDisponible.TabIndex = 52;
            this.chkDisponible.Text = ":Disponible";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(129, 534);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnQuitarSeleccionado
            // 
            this.btnQuitarSeleccionado.BackColor = System.Drawing.Color.LightPink;
            this.btnQuitarSeleccionado.Location = new System.Drawing.Point(24, 505);
            this.btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
            this.btnQuitarSeleccionado.Size = new System.Drawing.Size(121, 23);
            this.btnQuitarSeleccionado.TabIndex = 50;
            this.btnQuitarSeleccionado.Text = "Eliminar Seleccionado";
            this.btnQuitarSeleccionado.UseVisualStyleBackColor = false;
            this.btnQuitarSeleccionado.Click += new System.EventHandler(this.btnQuitarSeleccionado_Click);
            // 
            // tbCantidadRepuesto
            // 
            this.tbCantidadRepuesto.BackColor = System.Drawing.Color.LightGray;
            this.tbCantidadRepuesto.Location = new System.Drawing.Point(390, 206);
            this.tbCantidadRepuesto.Name = "tbCantidadRepuesto";
            this.tbCantidadRepuesto.Size = new System.Drawing.Size(121, 20);
            this.tbCantidadRepuesto.TabIndex = 49;
            // 
            // cbRepuesto
            // 
            this.cbRepuesto.BackColor = System.Drawing.Color.LightGray;
            this.cbRepuesto.FormattingEnabled = true;
            this.cbRepuesto.Location = new System.Drawing.Point(83, 206);
            this.cbRepuesto.Name = "cbRepuesto";
            this.cbRepuesto.Size = new System.Drawing.Size(121, 21);
            this.cbRepuesto.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "REPUESTOS USADOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Repuesto:";
            // 
            // cbTecnico
            // 
            this.cbTecnico.BackColor = System.Drawing.Color.LightGray;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(83, 134);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(121, 21);
            this.cbTecnico.TabIndex = 44;
            this.cbTecnico.SelectedIndexChanged += new System.EventHandler(this.cbTecnico_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Técnico:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.BackColor = System.Drawing.Color.LightGray;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(83, 82);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbVehiculo.TabIndex = 42;
            this.cbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbVehiculo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 36);
            this.label6.TabIndex = 41;
            this.label6.Text = "Registrar Orden de Servicio";
            // 
            // btnRegistrarOrden
            // 
            this.btnRegistrarOrden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarOrden.Location = new System.Drawing.Point(24, 534);
            this.btnRegistrarOrden.Name = "btnRegistrarOrden";
            this.btnRegistrarOrden.Size = new System.Drawing.Size(95, 23);
            this.btnRegistrarOrden.TabIndex = 40;
            this.btnRegistrarOrden.Text = "Registrar Orden";
            this.btnRegistrarOrden.UseVisualStyleBackColor = false;
            this.btnRegistrarOrden.Click += new System.EventHandler(this.btnRegistrarOrden_Click);
            // 
            // dgDetalleRepuestos
            // 
            this.dgDetalleRepuestos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDetalleRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleRepuestos.Location = new System.Drawing.Point(24, 282);
            this.dgDetalleRepuestos.Name = "dgDetalleRepuestos";
            this.dgDetalleRepuestos.Size = new System.Drawing.Size(487, 217);
            this.dgDetalleRepuestos.TabIndex = 39;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(436, 534);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(407, 242);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarRepuesto.TabIndex = 37;
            this.btnAgregarRepuesto.Text = "Agregar Repuesto";
            this.btnAgregarRepuesto.UseVisualStyleBackColor = false;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(390, 108);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowUpDown = true;
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 36;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.LightGray;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En proceso",
            "Finalizado"});
            this.cbEstado.Location = new System.Drawing.Point(390, 81);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 35;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.LightGray;
            this.txtCliente.Location = new System.Drawing.Point(83, 108);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCliente.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vehículo:";
            // 
            // FormOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(539, 568);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitarSeleccionado);
            this.Controls.Add(this.tbCantidadRepuesto);
            this.Controls.Add(this.cbRepuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTecnico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrarOrden);
            this.Controls.Add(this.dgDetalleRepuestos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarRepuesto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormOrdenServicio";
            this.Text = "Ordenes de Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnQuitarSeleccionado;
        private System.Windows.Forms.TextBox tbCantidadRepuesto;
        private System.Windows.Forms.ComboBox cbRepuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarOrden;
        private System.Windows.Forms.DataGridView dgDetalleRepuestos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarRepuesto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}