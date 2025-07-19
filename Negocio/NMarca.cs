using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMarca
    {
        private DMarca dMarca = new DMarca();

        public string Registrar(string marca)
        {
            return dMarca.Registrar(marca);
        }

        public List<MarcaVehiculo> ListarMarcas()
        {
            return dMarca.ListarMarcas();
        }
        public string Modificar(int idMarca, string nombreMarca)
        {
            return dMarca.Modificar(idMarca, nombreMarca);
        }

        public string Eliminar(int idMarca)
        {
            return dMarca.Eliminar(idMarca);
        }
    }
}
