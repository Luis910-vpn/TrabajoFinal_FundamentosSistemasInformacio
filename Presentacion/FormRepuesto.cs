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
    public partial class FormRepuesto : Form
    {
        private NRepuesto nRepuesto = new NRepuesto();
        private Repuesto repuestoSeleccionado = null;

        public FormRepuesto()
        {
            InitializeComponent();
            MostrarRepuestos(nRepuesto.Listar());  // Usamos el método de la capa de negocio
        }

        private void MostrarRepuestos(List<Repuesto> repuestos)
        {
            dgRepuestos.DataSource = null;

            if (repuestos.Count == 0)
                return;

            var lista = repuestos.Select(r => new
            {
                r.IdRepuesto,
                r.Nombre,
                r.Marca,
                r.CantidadStock,
                Precio = "S/ " + r.PrecioUnitario.ToString("F2"),
                r.StockMinimo,
                Advertencia = nRepuesto.EsStockBajo(r) ? "¡Stock Bajo!" : ""
            }).ToList();

            dgRepuestos.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbMarca.Clear();
            tbStock.Clear();
            tbPrecio.Clear();
            tbStockMinimo.Clear();
            tbBuscar.Clear();
            repuestoSeleccionado = null;
        }

        private void btnRegistrarRepuesto_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbMarca.Text == "" || tbStock.Text == "" || tbPrecio.Text == "" || tbStockMinimo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            if (!int.TryParse(tbStock.Text, out int stock) ||
                !int.TryParse(tbStockMinimo.Text, out int stockMin) ||
                !decimal.TryParse(tbPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Stock y precio deben ser numéricos válidos.");
                return;
            }

            int nuevoId = nRepuesto.Listar().Count > 0
                ? nRepuesto.Listar().Max(r => r.IdRepuesto) + 1
                : 1;

            Repuesto repuesto = new Repuesto()
            {
                IdRepuesto = nuevoId,
                Nombre = tbNombre.Text.Trim(),
                Marca = tbMarca.Text.Trim(),
                CantidadStock = stock,
                PrecioUnitario = precio,
                StockMinimo = stockMin
            };

            bool registrado = nRepuesto.Registrar(repuesto); // Usamos el método de negocio

            if (!registrado)
            {
                MessageBox.Show("Ya existe un repuesto con ese ID.");
                return;
            }

            MessageBox.Show("Repuesto registrado correctamente.");
            MostrarRepuestos(nRepuesto.Listar());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (repuestoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un repuesto.");
                return;
            }

            // Validar que todos los campos estén completos
            if (tbNombre.Text == "" || tbMarca.Text == "" || tbStock.Text == "" || tbPrecio.Text == "" || tbStockMinimo.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar que los valores de stock, precio y stock mínimo sean válidos
            if (!int.TryParse(tbStock.Text, out int stock) ||
                !int.TryParse(tbStockMinimo.Text, out int stockMin) ||
                !decimal.TryParse(tbPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Stock y precio deben ser numéricos válidos.");
                return;
            }

            // Actualizar los valores del repuesto seleccionado con los nuevos datos
            repuestoSeleccionado.Nombre = tbNombre.Text.Trim();
            repuestoSeleccionado.Marca = tbMarca.Text.Trim();
            repuestoSeleccionado.CantidadStock = stock;
            repuestoSeleccionado.PrecioUnitario = precio;
            repuestoSeleccionado.StockMinimo = stockMin;

            // Llamar al servicio de negocio para actualizar el repuesto
            string mensaje = nRepuesto.Modificar(repuestoSeleccionado);

            if (mensaje == "Repuesto modificado correctamente.")
            {
                MessageBox.Show(mensaje);
                MostrarRepuestos(nRepuesto.Listar());
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el repuesto.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (repuestoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un repuesto para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este repuesto?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                nRepuesto.Eliminar(repuestoSeleccionado);  // Usamos el método de negocio
                MessageBox.Show("Repuesto eliminado.");
                MostrarRepuestos(nRepuesto.Listar());
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarRepuestos(nRepuesto.Listar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var repuesto = nRepuesto.BuscarPorNombre(tbBuscar.Text.Trim());  // Usamos el método de negocio

            if (repuesto != null)
            {
                MostrarRepuestos(new List<Repuesto> { repuesto });
            }
            else
            {
                MessageBox.Show("Repuesto no encontrado.");
                MostrarRepuestos(nRepuesto.Listar());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgRepuestos.Rows[e.RowIndex].Cells["IdRepuesto"].Value);
                repuestoSeleccionado = nRepuesto.Listar().FirstOrDefault(r => r.IdRepuesto == id);

                if (repuestoSeleccionado != null)
                {
                    tbNombre.Text = repuestoSeleccionado.Nombre;
                    tbMarca.Text = repuestoSeleccionado.Marca;
                    tbStock.Text = repuestoSeleccionado.CantidadStock.ToString();
                    tbPrecio.Text = repuestoSeleccionado.PrecioUnitario.ToString("F2");
                    tbStockMinimo.Text = repuestoSeleccionado.StockMinimo.ToString();
                }
            }
        }
    }
}
