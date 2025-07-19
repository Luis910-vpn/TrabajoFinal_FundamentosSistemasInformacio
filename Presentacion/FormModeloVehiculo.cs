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
    public partial class FormModeloVehiculo : Form
    {
        private NModelo nModelo = new NModelo();
        private ModeloVehiculo modeloSeleccionado = null;
        private int idMarca;

        public FormModeloVehiculo(int idMarca)
        {
            InitializeComponent();
            this.idMarca = idMarca;
            CargarModelos();
        }

        private void CargarModelos()
        {
            // Listar todos los modelos de la marca seleccionada
            var modelos = nModelo.ListarModelosPorMarca(idMarca);
            dgModelos.DataSource = modelos;
        }
        private void LimpiarCampos()
        {
            tbModelo.Clear();
        }
        private void btnRegistrarModelo_Click(object sender, EventArgs e)
        {
            string modelo = tbModelo.Text.Trim();

            if (string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("El nombre del modelo es obligatorio.");
                return;
            }

            // Registrar el nuevo modelo
            string mensaje = nModelo.Registrar(idMarca, modelo);
            MessageBox.Show(mensaje);

            // Recargar la lista de modelos
            CargarModelos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (modeloSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un modelo para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbModelo.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el modelo.");
                return;
            }

            string mensaje = nModelo.Modificar(modeloSeleccionado.IdModelo, tbModelo.Text.Trim());
            MessageBox.Show(mensaje);

            CargarModelos();
            LimpiarCampos();
            modeloSeleccionado = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (modeloSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un modelo para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este modelo?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string mensaje = nModelo.Eliminar(modeloSeleccionado.IdModelo);
                MessageBox.Show(mensaje);

                CargarModelos();
                LimpiarCampos();
                modeloSeleccionado = null;
            }
        }

        private void dgModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idModelo = Convert.ToInt32(dgModelos.Rows[e.RowIndex].Cells["IdModelo"].Value);
                modeloSeleccionado = nModelo.ListarModelosPorMarca(idMarca).FirstOrDefault(m => m.IdModelo == idModelo);

                if (modeloSeleccionado != null)
                {
                    tbModelo.Text = modeloSeleccionado.Nombre;
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarModelos();
        }
    }
}
