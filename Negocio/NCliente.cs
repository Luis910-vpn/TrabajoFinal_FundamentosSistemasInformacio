using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();

        public string Registrar(Cliente cliente)
        {
            return dCliente.Registrar(cliente);
        }

        public string Modificar(Cliente cliente)
        {
            return dCliente.Modificar(cliente);
        }

        public string Eliminar(int idCliente)
        {
            return dCliente.Eliminar(idCliente);
        }

        public List<Cliente> ListarClientes()
        {
            return dCliente.ListarClientes();
        }

        public Cliente BuscarPorDNI(string dni)
        {
            return dCliente.BuscarPorDNI(dni);
        }
        public List<Vehiculo> ListarVehiculosPorCliente(int idCliente)
        {
            return dCliente.ListarVehiculosPorCliente(idCliente);
        }
    }
}
