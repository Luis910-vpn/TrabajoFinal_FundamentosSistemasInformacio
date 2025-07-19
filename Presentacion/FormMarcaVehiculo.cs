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
    public partial class FormMarcaVehiculo : Form
    {
        private NMarca nMarca = new NMarca();
        private MarcaVehiculo marcaSeleccionada = null;

        public FormMarcaVehiculo()
        {
            InitializeComponent();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            // Listar todas las marcas de vehículos
            var marcas = nMarca.ListarMarcas();
            dgMarcas.DataSource = marcas;
        }
        private void LimpiarCampos()
        {
            tbMarca.Clear();
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text.Trim();

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("El nombre de la marca es obligatorio.");
                return;
            }

            // Registrar la nueva marca
            string mensaje = nMarca.Registrar(marca);
            MessageBox.Show(mensaje);

            // Recargar la lista de marcas
            CargarMarcas();
        }

        private void btnAñadirModelo_Click(object sender, EventArgs e)
        {
            if (dgMarcas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            int idMarca = Convert.ToInt32(dgMarcas.SelectedRows[0].Cells["IdMarca"].Value);

            // Abrir el formulario de modelo para registrar un modelo para la marca seleccionada
            FormModeloVehiculo formModelo = new FormModeloVehiculo(idMarca);
            formModelo.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (marcaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una marca para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbMarca.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la marca.");
                return;
            }

            string mensaje = nMarca.Modificar(marcaSeleccionada.IdMarca, tbMarca.Text.Trim());
            MessageBox.Show(mensaje);

            CargarMarcas();
            LimpiarCampos();
            marcaSeleccionada = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (marcaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una marca para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar esta marca?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string mensaje = nMarca.Eliminar(marcaSeleccionada.IdMarca);
                MessageBox.Show(mensaje);

                CargarMarcas();
                LimpiarCampos();
                marcaSeleccionada = null;
            }
        }

        private void dgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idMarca = Convert.ToInt32(dgMarcas.Rows[e.RowIndex].Cells["IdMarca"].Value);
                marcaSeleccionada = nMarca.ListarMarcas().FirstOrDefault(m => m.IdMarca == idMarca);

                if (marcaSeleccionada != null)
                {
                    tbMarca.Text = marcaSeleccionada.Nombre;
                }
            }
        }
    }
}
