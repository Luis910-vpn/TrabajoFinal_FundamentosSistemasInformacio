using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVehiculo
    {
        private DVehiculo dVehiculo = new DVehiculo();

        public string Registrar(int idCliente, Vehiculo vehiculo)
        {
            return dVehiculo.Registrar(idCliente, vehiculo);
        }

        public string Modificar(int idCliente, Vehiculo vehiculo)
        {
            return dVehiculo.Modificar(idCliente, vehiculo);
        }

        public string Eliminar(int idCliente, Vehiculo vehiculo)
        {
            return dVehiculo.Eliminar(idCliente, vehiculo);
        }

        public List<Vehiculo> ListarVehiculosPorCliente(int idCliente)
        {
            return dVehiculo.ListarVehiculosPorCliente(idCliente);
        }

        public Vehiculo BuscarPorPlaca(int idCliente, string placa)
        {
            return dVehiculo.BuscarPorPlaca(idCliente, placa);
        }
        public List<Vehiculo> ListarTodos()
        {
            return dVehiculo.ListarTodos(); 
        }
    }
}
