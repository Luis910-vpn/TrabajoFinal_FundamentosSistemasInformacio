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
    public partial class FormTecnico : Form
    {
        // Llama a NTecnico
        private NTecnico nTecnico = new NTecnico();
        private Tecnico tecnicoSeleccionado = null;

        public FormTecnico()
        {
            InitializeComponent();
            MostrarTecnicos(nTecnico.ListarTecnicos());
        }

        private void MostrarTecnicos(List<Tecnico> tecnicos)
        {
            dgTecnicos.DataSource = null;

            if (tecnicos.Count == 0)
                return;

            var lista = tecnicos.Select(t => new
            {
                t.IdTecnico,
                NombreCompleto = t.Nombres + " " + t.Apellidos,
                t.Especialidad,
                Disponible = (bool)t.Disponible ? "Sí" : "No"
            }).ToList();

            dgTecnicos.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            cbEspecialidad.SelectedIndex = 0;
            chbDisponible.Checked = false;
            tbBuscarNombre.Clear();
            tecnicoSeleccionado = null;
        }

        private void btnRegistrarTecnico_Click(object sender, EventArgs e)
        {
            if (tbNombres.Text == "" || tbApellidos.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            int nuevoId = nTecnico.ListarTecnicos().Count > 0
                ? nTecnico.ListarTecnicos().Max(t => t.IdTecnico) + 1
                : 1;

            Tecnico tecnico = new Tecnico()
            {
                IdTecnico = nuevoId,
                Nombres = tbNombres.Text.Trim(),
                Apellidos = tbApellidos.Text.Trim(),
                Especialidad = cbEspecialidad.SelectedItem.ToString(),
                Disponible = chbDisponible.Checked
            };

            string mensaje = nTecnico.Registrar(tecnico);
            MessageBox.Show(mensaje);

            MostrarTecnicos(nTecnico.ListarTecnicos());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tecnicoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un técnico.");
                return;
            }

            if (tbNombres.Text == "" || tbApellidos.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            tecnicoSeleccionado.Nombres = tbNombres.Text.Trim();
            tecnicoSeleccionado.Apellidos = tbApellidos.Text.Trim();
            tecnicoSeleccionado.Especialidad = cbEspecialidad.SelectedItem.ToString();
            tecnicoSeleccionado.Disponible = chbDisponible.Checked;

            string mensaje = nTecnico.Modificar(tecnicoSeleccionado);
            MessageBox.Show(mensaje);

            MostrarTecnicos(nTecnico.ListarTecnicos());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tecnicoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un técnico para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este técnico?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string mensaje = nTecnico.Eliminar(tecnicoSeleccionado);
                MessageBox.Show(mensaje);

                MostrarTecnicos(nTecnico.ListarTecnicos());
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTecnicos(nTecnico.ListarTecnicos());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscarNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var tecnico = nTecnico.BuscarPorNombre(tbBuscarNombre.Text.Trim());

            if (tecnico != null)
            {
                MostrarTecnicos(new List<Tecnico> { tecnico });
            }
            else
            {
                MessageBox.Show("Técnico no encontrado.");
                MostrarTecnicos(nTecnico.ListarTecnicos());
            }
        }

        private void dgTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgTecnicos.Rows[e.RowIndex].Cells["IdTecnico"].Value);
                tecnicoSeleccionado = nTecnico.ListarTecnicos().FirstOrDefault(t => t.IdTecnico == id);

                if (tecnicoSeleccionado != null)
                {
                    tbNombres.Text = tecnicoSeleccionado.Nombres;
                    tbApellidos.Text = tecnicoSeleccionado.Apellidos;
                    cbEspecialidad.SelectedItem = tecnicoSeleccionado.Especialidad;
                    chbDisponible.Checked = (bool)tecnicoSeleccionado.Disponible;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
