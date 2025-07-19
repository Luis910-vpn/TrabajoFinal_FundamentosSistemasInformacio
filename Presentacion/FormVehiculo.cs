using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormVehiculo : Form
    {
        private NVehiculo nVehiculo = new NVehiculo();
        private Vehiculo vehiculoSeleccionado = null;
        private int idCliente;
        private NMarca nMarcaVehiculo = new NMarca();
        private NModelo nModeloVehiculo = new NModelo();

        public FormVehiculo(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            // Cargar marcas en el ComboBox
            CargarMarcas();

            // Si ya hay marcas, cargar los modelos de la primera marca
            if (cbMarca.Items.Count > 0)
            {
                // Obtiene el ID de la primera marca seleccionada
                int idMarca = (int)cbMarca.SelectedValue;
                CargarModelos(idMarca); // Cargar modelos para esa marca
            }

            // Mostrar vehículos asociados al cliente
            MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));
        }

        // Cargar las marcas en el ComboBox
        private void CargarMarcas()
        {
            var marcas = nMarcaVehiculo.ListarMarcas();
            cbMarca.DataSource = marcas;
            cbMarca.DisplayMember = "Nombre";
            cbMarca.ValueMember = "IdMarca";
        }

        // Cargar los modelos de la marca seleccionada
        private void CargarModelos(int idMarca)
        {
            // Obtener la lista de modelos de la marca seleccionada
            var modelos = nModeloVehiculo.ListarModelosPorMarca(idMarca);

            // Asignar la lista de modelos al ComboBox
            cbModelo.DataSource = modelos;
            cbModelo.DisplayMember = "Nombre";  // El campo que se mostrará en el ComboBox
            cbModelo.ValueMember = "IdModelo"; // El valor asociado a cada elemento del ComboBox

            // Limpiar la selección del ComboBox de modelos
            cbModelo.SelectedIndex = -1;
        }
        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            dgVehiculos.DataSource = null;
            if (vehiculos.Count != 0)
            {
                dgVehiculos.DataSource = vehiculos;
            }
        }

        private void LimpiarCampos()
        {
            tbPlaca.Clear();
            cbMarca.SelectedIndex = -1; // Reiniciar el ComboBox de marca
            cbModelo.SelectedIndex = -1; // Reiniciar el ComboBox de modelo
            tbAnio.Clear();
            tbBuscarPlaca.Clear();
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(tbPlaca.Text) ||
                cbMarca.SelectedItem == null ||
                cbModelo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tbAnio.Text) ||
                string.IsNullOrWhiteSpace(cbTipoMotor.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar formato de año
            if (!int.TryParse(tbAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número válido.");
                return;
            }

            if (anio < 1900 || anio > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Ingrese un año válido (entre 1900 y el próximo año).");
                return;
            }

            // Validar formato exacto de placa: ABC-123
            var regexPlaca = new Regex(@"^[A-Z]{3}-\d{3}$");
            if (!regexPlaca.IsMatch(tbPlaca.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Formato de placa inválido. Use el formato ABC-123.");
                return;
            }

            // Validar que no existan placas duplicadas
            var todosLosVehiculos = nVehiculo.ListarTodos();
            if (todosLosVehiculos.Any(v => v.Placa.Equals(tbPlaca.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un vehículo registrado con esa placa.");
                return;
            }

            // Crear el objeto Vehiculo usando el ComboBox para Marca y Modelo
            Vehiculo vehiculo = new Vehiculo()
            {
                Placa = tbPlaca.Text.Trim().ToUpper(),
                Anio = anio,
                TipoMotor = cbTipoMotor.Text.Trim(),
                IdMarca = (int)cbMarca.SelectedValue, // Obtener el ID de la marca seleccionada
                IdModelo = (int)cbModelo.SelectedValue, // Obtener el ID del modelo seleccionado
            };

            string mensaje = nVehiculo.Registrar(idCliente, vehiculo);
            MessageBox.Show(mensaje);

            MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo para editar.");
                return;
            }

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(tbPlaca.Text) ||
                cbMarca.SelectedItem == null ||
                cbModelo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tbAnio.Text) ||
                string.IsNullOrWhiteSpace(cbTipoMotor.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar formato de año
            if (!int.TryParse(tbAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número válido.");
                return;
            }

            if (anio < 1900 || anio > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Ingrese un año válido (entre 1900 y el próximo año).");
                return;
            }

            // Modificar el vehículo seleccionado con los datos de los ComboBox
            vehiculoSeleccionado.Placa = tbPlaca.Text.Trim();
            vehiculoSeleccionado.IdMarca = (int)cbMarca.SelectedValue;   // CORRECTO
            vehiculoSeleccionado.IdModelo = (int)cbModelo.SelectedValue; // CORRECTO
            vehiculoSeleccionado.Anio = anio;
            vehiculoSeleccionado.TipoMotor = cbTipoMotor.Text.Trim();

            // Opcional: Si necesitas mostrar el nombre de la marca/modelo en algún lado:
            vehiculoSeleccionado.Marca = cbMarca.Text;
            vehiculoSeleccionado.Modelo = cbModelo.Text;

            string mensaje = nVehiculo.Modificar(idCliente, vehiculoSeleccionado);
            MessageBox.Show(mensaje);

            MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));
            LimpiarCampos();
            vehiculoSeleccionado = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este vehículo?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Eliminar el vehículo usando el servicio
                string mensaje = nVehiculo.Eliminar(idCliente, vehiculoSeleccionado);

                // Verifica si el mensaje es "Vehículo eliminado correctamente"
                if (mensaje == "Vehículo eliminado correctamente.")
                {
                    // Actualizar el DataGridView con los vehículos restantes del cliente
                    MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));

                    // Limpiar los campos después de la eliminación
                    LimpiarCampos();
                    MessageBox.Show("Vehículo eliminado correctamente.");
                }
                else
                {
                    // Mostrar mensaje si no se eliminó correctamente
                    MessageBox.Show(mensaje);
                }

                // Limpiar la selección
                vehiculoSeleccionado = null;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscarPlaca.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una placa para buscar.");
                return;
            }

            var resultado = nVehiculo.BuscarPorPlaca(idCliente, tbBuscarPlaca.Text.Trim());

            if (resultado != null)
            {
                MostrarVehiculos(new List<Vehiculo> { resultado });
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado.");
                MostrarVehiculos(nVehiculo.ListarVehiculosPorCliente(idCliente));
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idVehiculo = Convert.ToInt32(dgVehiculos.Rows[e.RowIndex].Cells["IdVehiculo"].Value);
                vehiculoSeleccionado = nVehiculo.ListarVehiculosPorCliente(idCliente).FirstOrDefault(v => v.IdVehiculo == idVehiculo);

                if (vehiculoSeleccionado != null)
                {
                    tbPlaca.Text = vehiculoSeleccionado.Placa;
                    cbMarca.SelectedValue = vehiculoSeleccionado.IdMarca;
                    CargarModelos(vehiculoSeleccionado.IdMarca);  // Cargar los modelos de la marca seleccionada
                    cbModelo.SelectedValue = vehiculoSeleccionado.IdModelo;
                    tbAnio.Text = vehiculoSeleccionado.Anio.ToString();
                    cbTipoMotor.Text = vehiculoSeleccionado.TipoMotor;
                }
            }
        }

        private void btnAñadirMarca_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar una nueva marca
            FormMarcaVehiculo formMarca = new FormMarcaVehiculo();
            formMarca.ShowDialog();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedValue != null && int.TryParse(cbMarca.SelectedValue.ToString(), out int idMarca))
            {
                cbModelo.DataSource = null;
                CargarModelos(idMarca);
            }
        }
    }
}
