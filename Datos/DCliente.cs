using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public string Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                return "Cliente registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente clienteExistente = context.Cliente.Find(cliente.IdCliente);
                    if (clienteExistente == null) return "Cliente no encontrado.";

                    clienteExistente.Nombres = cliente.Nombres;
                    clienteExistente.Apellidos = cliente.Apellidos;
                    clienteExistente.DNI = cliente.DNI;
                    clienteExistente.Telefono = cliente.Telefono;
                    clienteExistente.Correo = cliente.Correo;
                    clienteExistente.Direccion = cliente.Direccion;

                    context.SaveChanges();
                }
                return "Cliente modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int idCliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente cliente = context.Cliente.Include("Vehiculo").FirstOrDefault(c => c.IdCliente == idCliente);
                    if (cliente == null)
                    {
                        return "Cliente no encontrado.";
                    }

                    // Eliminar los vehículos asociados al cliente
                    foreach (var vehiculo in cliente.Vehiculo.ToList())
                    {
                        context.Vehiculo.Remove(vehiculo);
                    }

                    // Eliminar el cliente
                    context.Cliente.Remove(cliente);
                    context.SaveChanges();
                }
                return "Cliente y sus vehículos eliminados correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Cliente> ListarClientes()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Cliente.Include("Vehiculo").ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }

        public Cliente BuscarPorDNI(string dni)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Cliente.FirstOrDefault(c => c.DNI == dni);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<Vehiculo> ListarVehiculosPorCliente(int idCliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var cliente = context.Cliente.Include("Vehiculo")
                        .FirstOrDefault(c => c.IdCliente == idCliente);

                    return cliente?.Vehiculo.ToList() ?? new List<Vehiculo>();
                }
            }
            catch (Exception ex)
            {
                return new List<Vehiculo>();  // Retornamos una lista vacía en caso de error
            }
        }
    }
}
