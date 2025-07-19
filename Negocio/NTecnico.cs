using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTecnico
    {
        private DTecnico dTecnico = new DTecnico();

        public string Registrar(Tecnico tecnico)
        {
            return dTecnico.Registrar(tecnico);
        }

        public string Modificar(Tecnico tecnico)
        {
            return dTecnico.Modificar(tecnico);
        }

        public string Eliminar(Tecnico tecnico)
        {
            return dTecnico.Eliminar(tecnico);
        }

        public List<Tecnico> ListarTecnicos()
        {
            return dTecnico.ListarTecnicos();
        }

        public Tecnico BuscarPorNombre(string nombre)
        {
            return dTecnico.BuscarPorNombre(nombre);
        }
        public void MarcarNoDisponible(Tecnico tecnico)
        {
            dTecnico.MarcarNoDisponible(tecnico);
        }
    }
}
