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
    public partial class FormReporte : Form
    {
        private NOrdenServicio nOrdenServicio = new NOrdenServicio();
        private NTecnico nTecnico = new NTecnico();
        private NCliente nCliente = new NCliente();

        public FormReporte()
        {
            InitializeComponent();
            CargarEstados();
            CargarTecnicos();
            MostrarTodosReportes();
        }

        private void CargarEstados()
        {
            cbEstadoFiltro.Items.AddRange(new string[] { "Pendiente", "En proceso", "Finalizado" });
            cbEstadoFiltro.SelectedIndex = 0;
        }

        private void CargarTecnicos()
        {
            cbTecnico.DataSource = nTecnico.ListarTecnicos();
            cbTecnico.DisplayMember = "Nombres";
            cbTecnico.ValueMember = "IdTecnico";
        }

        private void MostrarTodosReportes()
        {
            MostrarTodasLasOrdenes();
            MostrarRepuestosUtilizados();
            MostrarIngresosMensuales();
        }

        // RF09.1 - Órdenes por estado
        private void MostrarOrdenesPorEstado()
        {
            var estadoSeleccionado = cbEstadoFiltro.SelectedItem.ToString();

            // Lista de clientes cargados previamente para evitar múltiples consultas a la base de datos
            var ordenes = nOrdenServicio.Listar()
                .Where(o => o.Estado == estadoSeleccionado)
                .Select(o => new
                {
                    o.IdOrden,
                    Placa = o.Vehiculo?.Placa ?? "No asignado", // Si Vehiculo es null, muestra "No asignado"
                    Cliente = o.Vehiculo?.Cliente?.Nombres ?? "No asignado", // Acceder directamente al Cliente desde el Vehiculo
                    Tecnico = o.Tecnico?.Nombres ?? "No asignado", // Si Tecnico es null, muestra "No asignado"
                    o.FechaRegistro,
                    o.Estado,
                    Total = o.DetalleRepuesto?.Sum(d => d.SubTotal) ?? 0 // Si DetalleRepuesto es null, el total es 0
                }).ToList();

            dgOrdenesEstado.DataSource = ordenes;
        }

        private void MostrarTodasLasOrdenes()
        {
            // Cargar todos los clientes y vehículos
            var clientes = nCliente.ListarClientes().ToList();
            var ordenes = nOrdenServicio.Listar()
                .Select(o => new
                {
                    o.IdOrden,
                    Placa = o.Vehiculo?.Placa ?? "No asignado", // Si Vehiculo es null, muestra "No asignado"
                    Cliente = clientes.FirstOrDefault(c => c.IdCliente == o.Vehiculo?.IdCliente)?.Nombres ?? "No asignado", // Buscar cliente por vehículo
                    Tecnico = o.Tecnico?.Nombres ?? "No asignado", // Si Tecnico es null, muestra "No asignado"
                    o.FechaRegistro,
                    o.Estado,
                    Total = o.DetalleRepuesto?.Sum(d => d.SubTotal) ?? 0 // Si DetalleRepuesto es null, el total es 0
                }).ToList();

            dgOrdenesEstado.DataSource = ordenes;
        }

        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            MostrarOrdenesPorEstado();
        }

        private void btnVerTodosEstado_Click(object sender, EventArgs e)
        {
            MostrarTodasLasOrdenes();
        }

        private void btnEliminarFinalizados_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Está seguro de que desea eliminar todas las órdenes de servicio finalizadas?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Llamar a un servicio o método para eliminar las órdenes finalizadas
                var mensaje = nOrdenServicio.EliminarOrdenesFinalizadas();
                // Mostrar mensaje de éxito o error
                MessageBox.Show(mensaje);
                // Refrescar los datos del reporte después de eliminar
                MostrarTodasLasOrdenes();
            }
        }

        private void btnEliminarOrdenSeleccionada_Click(object sender, EventArgs e)
        {
            // Verificar que se ha seleccionado una orden de servicio
            if (dgOrdenesEstado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden para eliminar.");
                return;
            }

            // Obtener el Id de la orden seleccionada
            var idOrdenSeleccionada = Convert.ToInt32(dgOrdenesEstado.SelectedRows[0].Cells["IdOrden"].Value);

            var confirm = MessageBox.Show("¿Está seguro de que desea eliminar esta orden?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Llamar a un servicio o método para eliminar la orden seleccionada
                var mensaje = nOrdenServicio.EliminarOrdenSeleccionada(idOrdenSeleccionada);

                // Mostrar mensaje de éxito o error
                MessageBox.Show(mensaje);

                // Refrescar los datos del reporte después de eliminar
                MostrarOrdenesPorEstado();
            }
        }

        // RF09.2 - Servicios por técnico en rango de fechas
        private void MostrarServiciosPorTecnico()
        {
            // Verificar si se ha seleccionado un técnico en el ComboBox
            if (cbTecnico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un técnico antes de filtrar los servicios.");
                return; // Salir de la función si no se ha seleccionado un técnico
            }

            // Obtener el técnico seleccionado
            var tecnico = (Tecnico)cbTecnico.SelectedItem;
            var desde = dpDesde.Value.Date;
            var hasta = dpHasta.Value.Date;

            // Obtener la lista de órdenes de servicio filtradas por técnico y fecha
            var servicios = nOrdenServicio.ListarPorTecnicoYFecha(tecnico.IdTecnico, desde, hasta)
                .Select(o => new
                {
                    o.IdOrden,
                    Placa = o.Vehiculo?.Placa ?? "No asignado",  // Mostrar "No asignado" si no hay vehículo
                    o.FechaRegistro,
                    o.Estado,
                    Total = o.DetalleRepuesto?.Sum(d => d.SubTotal) ?? 0  // Si DetalleRepuesto es null, asignar 0
                }).ToList();

            // Asignar la lista de servicios al DataGrid
            dgServiciosTecnico.DataSource = servicios;
        }

        private void btnFiltrarTecnico_Click(object sender, EventArgs e)
        {
            MostrarServiciosPorTecnico();
        }

        // RF09.3 - Repuestos utilizados por orden
        private void MostrarRepuestosUtilizados()
        {
            // Obtener la lista de repuestos utilizados desde el servicio
            var repuestos = nOrdenServicio.ListarRepuestos()
                .SelectMany(o => o.DetalleRepuesto.Select(d => new
                {
                    o.IdOrden,
                    Repuesto = d.Repuesto?.Nombre ?? "No asignado",  // Mostrar "No asignado" si Repuesto es null
                    d.Cantidad,
                    Fecha = o.FechaRegistro?.ToShortDateString() ?? "Fecha no disponible",
                    Subtotal = d.SubTotal
                })).ToList();

            // Asignar la lista de repuestos al DataGrid
            dgRepuestosUtilizados.DataSource = repuestos;
        }
        // RF09.4 - Ingresos mensuales
        private void MostrarIngresosMensuales()
        {
            var ingresos = nOrdenServicio.Listar()
                .Where(o => o.FechaRegistro.HasValue) // Filtrar para asegurarse de que FechaRegistro no sea null
                .GroupBy(o => new { Year = o.FechaRegistro.Value.Year, Month = o.FechaRegistro.Value.Month }) // Usar Value para acceder a Year y Month
                .Select(g => new
                {
                    Mes = $"{g.Key.Month:00}/{g.Key.Year}",
                    Total = g.Sum(o => o.DetalleRepuesto?.Sum(d => d.SubTotal) ?? 0) // Manejar null en DetalleRepuesto
                }).ToList();

            dgIngresosMensuales.DataSource = ingresos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
