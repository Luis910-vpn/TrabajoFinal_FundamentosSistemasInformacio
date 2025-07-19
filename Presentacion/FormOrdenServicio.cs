using Datos;
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
    public partial class FormOrdenServicio : Form
    {
        // Llamar al negocio en lugar del servicio
        private NOrdenServicio nOrdenServicio = new NOrdenServicio();
        private NCliente nCliente = new NCliente();
        private NTecnico nTecnico = new NTecnico();
        private NRepuesto nRepuesto = new NRepuesto();

        private List<DetalleRepuesto> detalleRepuestos = new List<DetalleRepuesto>();

        public FormOrdenServicio()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Now;

            CargarVehiculos();
            CargarTecnicos();
            CargarRepuestos();

            RefrescarGrid();
            CalcularTotal();
        }

        private void CargarVehiculos()
        {
            var clientes = nCliente.ListarClientes();  // Llamar al negocio para obtener los clientes

            // Para cada cliente, se obtiene su lista de vehículos
            var lista = clientes
                .Where(c => c.Vehiculo != null && c.Vehiculo.Count > 0)
                .SelectMany(c => c.Vehiculo)
                .ToList();

            cbVehiculo.DataSource = lista;  // Asignamos la lista de vehículos
            cbVehiculo.DisplayMember = "Placa";  // Mostramos la placa del vehículo en el ComboBox
            cbVehiculo.ValueMember = "IdVehiculo";  // Establecemos el ID del vehículo como el valor asociado
        }

        private void CargarTecnicos()
        {
            var tecnicos = nTecnico.ListarTecnicos();  // Usar el negocio
            cbTecnico.DataSource = tecnicos;
            cbTecnico.DisplayMember = "Nombres";
        }

        private void CargarRepuestos()
        {
            var repuestos = nRepuesto.Listar();  // Usar el negocio
            cbRepuesto.DataSource = repuestos;
            cbRepuesto.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVehiculo.SelectedItem is Vehiculo selectedVehiculo)
            {
                // Usamos el IdVehiculo para buscar el cliente correspondiente
                var cliente = nCliente.ListarClientes().FirstOrDefault(c => c.Vehiculo.Any(v => v.IdVehiculo == selectedVehiculo.IdVehiculo));

                if (cliente != null)
                {
                    // Mostramos el nombre del cliente
                    txtCliente.Text = $"{cliente.Nombres} {cliente.Apellidos}";
                }
                else
                {
                    txtCliente.Text = string.Empty;  // Limpiamos el campo si no encontramos el cliente
                }
            }
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCantidadRepuesto.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            var repuesto = (Repuesto)cbRepuesto.SelectedItem;

            var detalle = detalleRepuestos.FirstOrDefault(d => d.Repuesto == repuesto);
            if (detalle != null)
            {
                detalle.Cantidad += cantidad;
                detalle.SubTotal = detalle.Repuesto.PrecioUnitario * detalle.Cantidad;  // Calculamos el SubTotal
            }
            else
            {
                var nuevoDetalle = new DetalleRepuesto
                {
                    Repuesto = repuesto,
                    Cantidad = cantidad,
                    SubTotal = repuesto.PrecioUnitario * cantidad  // Calculamos el SubTotal
                };

                detalleRepuestos.Add(nuevoDetalle);
            }

            RefrescarGrid();
            CalcularTotal();
            tbCantidadRepuesto.Clear();
        }

        private void RefrescarGrid()
        {
            dgDetalleRepuestos.DataSource = null;

            var lista = detalleRepuestos.Select(d => new
            {
                d.Repuesto.Nombre,
                d.Repuesto.Marca,
                d.Cantidad,
                Precio = $"S/ {d.Repuesto.PrecioUnitario:F2}",
                Subtotal = $"S/ {d.SubTotal:F2}"
            }).ToList();

            dgDetalleRepuestos.DataSource = lista;
        }

        private void CalcularTotal()
        {
            decimal total = detalleRepuestos.Sum(d => d.SubTotal);
            lblTotal.Text = $"Total: S/ {total:F2}";
        }

        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgDetalleRepuestos.CurrentRow != null)
            {
                string nombre = dgDetalleRepuestos.CurrentRow.Cells["Nombre"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"¿Estás seguro de quitar el repuesto '{nombre}'?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    var detalle = detalleRepuestos.FirstOrDefault(d => d.Repuesto.Nombre == nombre);
                    if (detalle != null)
                    {
                        detalleRepuestos.Remove(detalle);
                        RefrescarGrid();
                        CalcularTotal();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un repuesto de la lista.");
            }
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            if (cbVehiculo.SelectedItem == null || cbTecnico.SelectedItem == null || cbEstado.SelectedItem == null || detalleRepuestos.Count == 0)
            {
                MessageBox.Show("Complete todos los datos.");
                return;
            }

            var selected = (Vehiculo)cbVehiculo.SelectedItem;
            var vehiculo = selected;
            var tecnico = (Tecnico)cbTecnico.SelectedItem;

            if ((bool)!tecnico.Disponible)
            {
                MessageBox.Show("El técnico seleccionado no está disponible. Por favor, elija otro.");
                return;
            }

            // Verificar stock disponible para todos los repuestos
            foreach (var detalle in detalleRepuestos)
            {
                if (detalle.Repuesto.CantidadStock < detalle.Cantidad)
                {
                    MessageBox.Show($"No hay stock suficiente para el repuesto '{detalle.Repuesto.Nombre}'.");
                    return;
                }
            }

            int nuevoId = nOrdenServicio.Listar().Count > 0
                ? nOrdenServicio.Listar().Max(o => o.IdOrden) + 1
                : 1;

            var orden = new OrdenServicio
            {
                IdOrden = nuevoId,
                Vehiculo = vehiculo,
                Tecnico = tecnico,
                Estado = cbEstado.SelectedItem.ToString(),
                FechaRegistro = dtpFecha.Value,
                DetalleRepuesto = new List<DetalleRepuesto>(detalleRepuestos)
            };

            bool registrado = nOrdenServicio.Registrar(orden);

            if (!registrado)
            {
                MessageBox.Show("Ya existe una orden con ese ID.");
                return;
            }

            // Marcar técnico como no disponible
            nTecnico.MarcarNoDisponible(tecnico);

            // Descontar stock
            foreach (var detalle in detalleRepuestos)
            {
                nRepuesto.DescontarStock(detalle.Repuesto, detalle.Cantidad);

                // Verificar si se quedó con poco stock
                if (nRepuesto.EsStockBajo(detalle.Repuesto))
                {
                    MessageBox.Show($"⚠️ El repuesto '{detalle.Repuesto.Nombre}' ha llegado a su stock mínimo.");
                }
            }

            MessageBox.Show("Orden registrada exitosamente.");

            LimpiarTodo();
            CargarTecnicos();
            CargarRepuestos();
        }

        private void LimpiarTodo()
        {
            cbVehiculo.SelectedIndex = 0;
            cbTecnico.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            detalleRepuestos.Clear();
            RefrescarGrid();
            CalcularTotal();
            tbCantidadRepuesto.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        private void cbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTecnico.SelectedItem is Tecnico tecnico)
            {
                chkDisponible.Checked = (bool)tecnico.Disponible;
            }
        }
    }
}
