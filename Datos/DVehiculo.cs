using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVehiculo
    {
        public string Registrar(int idCliente, Vehiculo vehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Obtener el cliente asociado
                    Cliente cliente = context.Cliente.Find(idCliente);
                    if (cliente == null)
                    {
                        return "Cliente no encontrado.";
                    }

                    // Obtener la marca y el modelo de la base de datos
                    var marca = context.MarcaVehiculo.Find(vehiculo.IdMarca);
                    var modelo = context.ModeloVehiculo.Find(vehiculo.IdModelo);

                    if (marca == null || modelo == null)
                    {
                        return "Marca o Modelo no encontrados.";
                    }

                    // Asociar el vehículo con la marca y el modelo
                    vehiculo.Marca = marca.Nombre;
                    vehiculo.Modelo = modelo.Nombre;

                    cliente.Vehiculo.Add(vehiculo);
                    context.SaveChanges();
                }
                return "Vehículo registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(int idCliente, Vehiculo vehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente cliente = context.Cliente.Find(idCliente);
                    if (cliente == null)
                    {
                        return "Cliente no encontrado.";
                    }

                    Vehiculo vehiculoExistente = cliente.Vehiculo.FirstOrDefault(v => v.IdVehiculo == vehiculo.IdVehiculo);
                    if (vehiculoExistente == null)
                    {
                        return "Vehículo no encontrado.";
                    }

                    // Actualizar todos los campos relevantes, incluidas las claves foráneas
                    vehiculoExistente.Placa = vehiculo.Placa;
                    vehiculoExistente.Anio = vehiculo.Anio;
                    vehiculoExistente.TipoMotor = vehiculo.TipoMotor;
                    vehiculoExistente.IdMarca = vehiculo.IdMarca;
                    vehiculoExistente.IdModelo = vehiculo.IdModelo;

                    // Opcional: actualizar los nombres si los usas en la UI
                    vehiculoExistente.Marca = vehiculo.Marca;
                    vehiculoExistente.Modelo = vehiculo.Modelo;

                    context.SaveChanges();
                }
                return "Vehículo modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int idCliente, Vehiculo vehiculo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Obtener el cliente asociado
                    Cliente cliente = context.Cliente.Find(idCliente);
                    if (cliente == null)
                    {
                        return "Cliente no encontrado.";
                    }

                    // Buscar el vehículo a eliminar
                    Vehiculo vehiculoExistente = cliente.Vehiculo.FirstOrDefault(v => v.IdVehiculo == vehiculo.IdVehiculo);
                    if (vehiculoExistente == null)
                    {
                        return "Vehículo no encontrado.";
                    }

                    // Verificar si el vehículo tiene órdenes de servicio asociadas
                    var ordenesDeServicio = context.OrdenServicio.Where(o => o.IdVehiculo == vehiculo.IdVehiculo).ToList();
                    if (ordenesDeServicio.Any())
                    {
                        // Si tiene órdenes, las desasociamos antes de eliminar el vehículo
                        foreach (var orden in ordenesDeServicio)
                        {
                            orden.IdVehiculo = null; // Desasociamos el vehículo de las órdenes de servicio
                        }

                        context.SaveChanges(); // Guardamos los cambios
                    }

                    // Eliminar el vehículo
                    context.Vehiculo.Remove(vehiculoExistente); // Eliminar el vehículo de la base de datos
                    context.SaveChanges(); // Guardamos los cambios

                    return "Vehículo eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el vehículo: " + ex.Message;
            }
        }

        public List<Vehiculo> ListarVehiculosPorCliente(int idCliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Cliente cliente = context.Cliente.Include("Vehiculo").FirstOrDefault(c => c.IdCliente == idCliente);
                    if (cliente == null)
                    {
                        return new List<Vehiculo>();
                    }
                    return cliente.Vehiculo.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Vehiculo>();
            }
        }

        public Vehiculo BuscarPorPlaca(int idCliente, string placa)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente cliente = context.Cliente.Include("Vehiculos").FirstOrDefault(c => c.IdCliente == idCliente);
                    return cliente?.Vehiculo.FirstOrDefault(v => v.Placa.ToLower() == placa.ToLower());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<Vehiculo> ListarTodos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Obtener todos los vehículos de la base de datos
                    return context.Vehiculo.ToList();
                }
            }
            catch (Exception ex)
            {
                // En caso de error, puedes registrar el error o retornar una lista vacía
                return new List<Vehiculo>();
            }
        }
    }
}

