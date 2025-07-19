using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NOrdenServicio
    {
        private DOrdenServicio dOrdenServicio = new DOrdenServicio();

        public bool Registrar(OrdenServicio orden)
        {
            // Si ya existe una orden con ese ID, no la registrar
            if (dOrdenServicio.BuscarPorId(orden.IdOrden) != null)
                return false;

            dOrdenServicio.Registrar(orden);
            return true;
        }

        public string EliminarOrdenSeleccionada(int idOrden)
        {
            return dOrdenServicio.EliminarOrdenPorId(idOrden);
        }
        public string EliminarOrdenesFinalizadas()
        {
            return dOrdenServicio.EliminarOrdenesFinalizadas();
        }
        public List<OrdenServicio> ListarRepuestos()
        {
            return dOrdenServicio.ListarRepuestos();
        }
        public List<OrdenServicio> ListarPorTecnicoYFecha(int idTecnico, DateTime desde, DateTime hasta)
        {
            return dOrdenServicio.ListarPorTecnicoYFecha(idTecnico, desde, hasta);
        }

        public List<OrdenServicio> Listar()
        {
            return dOrdenServicio.Listar();
        }

        public OrdenServicio BuscarPorId(int id)
        {
            return dOrdenServicio.BuscarPorId(id);
        }
    }
}
