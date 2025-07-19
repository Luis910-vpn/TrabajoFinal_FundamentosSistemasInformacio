using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCliente : Form
    {
        // Llamar a NCliente 
        private NCliente nCliente = new NCliente();
        private Cliente clienteSeleccionado = null;

        public FormCliente()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarClientes());
        }

        private void MostrarClientes(List<Cliente> clientes)
        {
            dgClientes.DataSource = null;
            if (clientes.Count == 0)
                return;

            var lista = clientes.Select(c => new
            {
                c.IdCliente,
                NombreCompleto = c.Nombres + " " + c.Apellidos,
                c.DNI,
                c.Telefono,
                c.Correo,
                c.Direccion
            }).ToList();

            dgClientes.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbDNI.Clear();
            tbTelefono.Clear();
            tbCorreo.Clear();
            tbDireccion.Clear();
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios vacíos
            if (string.IsNullOrWhiteSpace(tbNombres.Text) ||
                string.IsNullOrWhiteSpace(tbApellidos.Text) ||
                string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbTelefono.Text) ||
                string.IsNullOrWhiteSpace(tbCorreo.Text) ||
                string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar nombre y apellido (mínimo 2 caracteres, solo letras y espacios)
            var soloLetras = new Regex(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]{2,}$");
            if (!soloLetras.IsMatch(tbNombres.Text.Trim()))
            {
                MessageBox.Show("Nombres inválidos. Solo se permiten letras y deben tener al menos 2 caracteres.");
                return;
            }

            if (!soloLetras.IsMatch(tbApellidos.Text.Trim()))
            {
                MessageBox.Show("Apellidos inválidos. Solo se permiten letras y deben tener al menos 2 caracteres.");
                return;
            }

            // Validar DNI (exactamente 8 dígitos)
            if (!Regex.IsMatch(tbDNI.Text.Trim(), @"^\d{8}$"))
            {
                MessageBox.Show("DNI inválido. Debe contener exactamente 8 dígitos.");
                return;
            }

            // Validar teléfono (mínimo 7 y máximo 15 dígitos)
            if (!Regex.IsMatch(tbTelefono.Text.Trim(), @"^\d{7,15}$"))
            {
                MessageBox.Show("Teléfono inválido. Debe tener entre 7 y 15 dígitos.");
                return;
            }

            // Validar correo electrónico
            var regexCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexCorreo.IsMatch(tbCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo electrónico inválido.");
                return;
            }

            // Validar dirección (mínimo 2 caracteres)
            if (tbDireccion.Text.Trim().Length < 2)
            {
                MessageBox.Show("Dirección demasiado corta.");
                return;
            }

            // Verificar si el DNI ya fue registrado
            var dniExistente = nCliente.ListarClientes().Any(c => c.DNI == tbDNI.Text.Trim());
            if (dniExistente)
            {
                MessageBox.Show("Ya existe un cliente con ese DNI.");
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nombres = tbNombres.Text.Trim(),
                Apellidos = tbApellidos.Text.Trim(),
                DNI = tbDNI.Text.Trim(),
                Telefono = tbTelefono.Text.Trim(),
                Correo = tbCorreo.Text.Trim(),
                Direccion = tbDireccion.Text.Trim()
            };

            string mensaje = nCliente.Registrar(cliente);
            MessageBox.Show(mensaje);

            MostrarClientes(nCliente.ListarClientes());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbNombres.Text) ||
                string.IsNullOrWhiteSpace(tbApellidos.Text) ||
                string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbTelefono.Text) ||
                string.IsNullOrWhiteSpace(tbCorreo.Text) ||
                string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar nombre y apellido (mínimo 2 caracteres, solo letras y espacios)
            var soloLetras = new Regex(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]{2,}$");
            if (!soloLetras.IsMatch(tbNombres.Text.Trim()))
            {
                MessageBox.Show("Nombres inválidos. Solo se permiten letras y deben tener al menos 2 caracteres.");
                return;
            }

            if (!soloLetras.IsMatch(tbApellidos.Text.Trim()))
            {
                MessageBox.Show("Apellidos inválidos. Solo se permiten letras y deben tener al menos 2 caracteres.");
                return;
            }

            // Validar DNI (exactamente 8 dígitos)
            if (!Regex.IsMatch(tbDNI.Text.Trim(), @"^\d{8}$"))
            {
                MessageBox.Show("DNI inválido. Debe contener exactamente 8 dígitos.");
                return;
            }

            // Validar teléfono (mínimo 7 y máximo 15 dígitos)
            if (!Regex.IsMatch(tbTelefono.Text.Trim(), @"^\d{7,15}$"))
            {
                MessageBox.Show("Teléfono inválido. Debe tener entre 7 y 15 dígitos.");
                return;
            }

            // Validar correo electrónico
            var regexCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexCorreo.IsMatch(tbCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo electrónico inválido.");
                return;
            }

            // Validar dirección (mínimo 2 caracteres)
            if (tbDireccion.Text.Trim().Length < 2)
            {
                MessageBox.Show("Dirección demasiado corta.");
                return;
            }

            clienteSeleccionado.Nombres = tbNombres.Text.Trim();
            clienteSeleccionado.Apellidos = tbApellidos.Text.Trim();
            clienteSeleccionado.DNI = tbDNI.Text.Trim();
            clienteSeleccionado.Telefono = tbTelefono.Text.Trim();
            clienteSeleccionado.Correo = tbCorreo.Text.Trim();
            clienteSeleccionado.Direccion = tbDireccion.Text.Trim();

            string mensaje = nCliente.Modificar(clienteSeleccionado);
            MessageBox.Show(mensaje);

            MostrarClientes(nCliente.ListarClientes());
            LimpiarCampos();
            clienteSeleccionado = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Pasamos solo el IdCliente al eliminar
                string mensaje = nCliente.Eliminar(clienteSeleccionado.IdCliente);
                MessageBox.Show(mensaje);
                MostrarClientes(nCliente.ListarClientes());
                LimpiarCampos();
                clienteSeleccionado = null;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarClientes(nCliente.ListarClientes());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = nCliente.BuscarPorDNI(tbBuscarDNI.Text.Trim());

            if (cliente != null)
            {
                var resultado = new[]
                {
                    new
                    {
                        cliente.IdCliente,
                        NombreCompleto = cliente.Nombres + " " + cliente.Apellidos,
                        cliente.DNI,
                        cliente.Telefono,
                        cliente.Correo,
                        cliente.Direccion
                    }
                };

                dgClientes.DataSource = resultado.ToList();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
                LimpiarCampos();
                MostrarClientes(nCliente.ListarClientes());
            }
        }

        private void btnVerVehiculo_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            int id = int.Parse(dgClientes.SelectedRows[0].Cells[0].Value.ToString());
            FormVehiculo formVehiculo = new FormVehiculo(id);
            formVehiculo.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
                clienteSeleccionado = nCliente.ListarClientes().FirstOrDefault(c => c.IdCliente == id);

                if (clienteSeleccionado != null)
                {
                    tbNombres.Text = clienteSeleccionado.Nombres;
                    tbApellidos.Text = clienteSeleccionado.Apellidos;
                    tbDNI.Text = clienteSeleccionado.DNI;
                    tbTelefono.Text = clienteSeleccionado.Telefono;
                    tbCorreo.Text = clienteSeleccionado.Correo;
                    tbDireccion.Text = clienteSeleccionado.Direccion;
                }
            }
        }
    }
}
