using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
        }

        private void btnVerTecnicos_Click(object sender, EventArgs e)
        {
            FormTecnico formTecnico = new FormTecnico();
            formTecnico.Show();
        }

        private void btnVerRespuestos_Click(object sender, EventArgs e)
        {
            FormRepuesto formRepuesto = new FormRepuesto();
            formRepuesto.Show();
        }

        private void VerOrdenServicio_Click(object sender, EventArgs e)
        {
            var nCliente = new NCliente();
            var nTecnico = new NTecnico();
            var nRepuesto = new NRepuesto();

            // Obtener las listas de clientes, técnicos y repuestos
            var clientes = nCliente.ListarClientes(); 
            var tecnicos = nTecnico.ListarTecnicos();
            var repuestos = nRepuesto.Listar();

            // Verificar si existen clientes
            if (clientes.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un cliente.");
                return;
            }

            // Verificar si hay vehículos asociados a los clientes
            // Cargar los vehículos para cada cliente antes de usarlo
            bool tieneVehiculos = clientes.Any(c => c.Vehiculo != null && c.Vehiculo.Count > 0);
            if (!tieneVehiculos)
            {
                MessageBox.Show("Debe registrar al menos un vehículo asociado a un cliente.");
                return;
            }

            // Verificar si existen técnicos
            if (tecnicos.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un técnico.");
                return;
            }

            // Verificar si existen repuestos
            if (repuestos.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un repuesto.");
                return;
            }

            // Si todo es válido, abrir el formulario de orden de servicio
            FormOrdenServicio formOrdenServicio = new FormOrdenServicio();
            formOrdenServicio.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
