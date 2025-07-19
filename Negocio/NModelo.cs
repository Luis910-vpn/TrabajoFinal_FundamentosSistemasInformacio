using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NModelo
    {
        private DModelo dModelo = new DModelo();

        public string Registrar(int idMarca, string modelo)
        {
            return dModelo.Registrar(idMarca, modelo);
        }

        public List<ModeloVehiculo> ListarModelosPorMarca(int idMarca)
        {
            return dModelo.ListarModelosPorMarca(idMarca);
        }
        public string Modificar(int idModelo, string nombreModelo)
        {
            return dModelo.Modificar(idModelo, nombreModelo);
        }

        public string Eliminar(int idModelo)
        {
            return dModelo.Eliminar(idModelo);
        }
    }
}
