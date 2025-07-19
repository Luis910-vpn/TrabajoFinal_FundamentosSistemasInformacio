using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOrdenServicio
    {
        public void Registrar(OrdenServicio orden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Verificar si el cliente existe en la base de datos
                    var clienteExistente = context.Cliente
                        .FirstOrDefault(c => c.IdCliente == orden.Vehiculo.Cliente.IdCliente);

                    if (clienteExistente == null)
                    {
                        throw new Exception("El cliente asociado no existe en la base de datos.");
                    }

                    // Asignar el cliente existente al vehículo, si es necesario
                    orden.Vehiculo.Cliente = clienteExistente;

                    // Verificar si el vehículo ya existe en la base de datos
                    var vehiculoExistente = context.Vehiculo
                        .FirstOrDefault(v => v.IdVehiculo == orden.Vehiculo.IdVehiculo);

                    if (vehiculoExistente == null)
                    {
                        throw new Exception("El vehículo asociado no existe en la base de datos.");
                    }

                    // Asignar el vehículo existente a la orden de servicio
                    orden.Vehiculo = vehiculoExistente;

                    // Verificar si el técnico ya existe en la base de datos
                    var tecnicoExistente = context.Tecnico
                        .FirstOrDefault(t => t.IdTecnico == orden.Tecnico.IdTecnico);

                    if (tecnicoExistente == null)
                    {
                        throw new Exception("El técnico asociado no existe en la base de datos.");
                    }

                    // Asignar el técnico existente a la orden de servicio
                    orden.Tecnico = tecnicoExistente;

                    // Verificar si los repuestos ya existen en la base de datos
                    foreach (var detalle in orden.DetalleRepuesto)
                    {
                        var repuestoExistente = context.Repuesto
                            .FirstOrDefault(r => r.IdRepuesto == detalle.Repuesto.IdRepuesto);

                        if (repuestoExistente == null)
                        {
                            throw new Exception($"El repuesto '{detalle.Repuesto.Nombre}' no existe en la base de datos.");
                        }

                        // Asignar el repuesto existente al detalle de la orden de servicio
                        detalle.Repuesto = repuestoExistente;
                    }

                    // Agregar la nueva orden de servicio
                    context.OrdenServicio.Add(orden);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la orden: " + ex.Message);
            }
        }

        public string EliminarOrdenPorId(int idOrden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Buscar la orden por Id
                    var ordenExistente = context.OrdenServicio.Find(idOrden);
                    if (ordenExistente != null)
                    {
                        context.OrdenServicio.Remove(ordenExistente);
                        context.SaveChanges();
                        return "Orden eliminada correctamente.";
                    }
                    else
                    {
                        return "Orden no encontrada.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la orden: " + ex.Message;
            }
        }
        public string EliminarOrdenesFinalizadas()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Obtener las órdenes de servicio con estado "Finalizado"
                    var ordenesFinalizadas = context.OrdenServicio
                        .Where(o => o.Estado == "Finalizado")
                        .ToList();

                    // Eliminar las órdenes finalizadas
                    context.OrdenServicio.RemoveRange(ordenesFinalizadas);
                    context.SaveChanges();
                }

                return "Órdenes finalizadas eliminadas correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar las órdenes finalizadas: " + ex.Message;
            }
        }
        public List<OrdenServicio> ListarPorTecnicoYFecha(int idTecnico, DateTime desde, DateTime hasta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Cargar las órdenes de servicio filtradas por técnico y fecha
                    return context.OrdenServicio
                        .Include("Vehiculo")         // Cargar el Vehiculo relacionado
                        .Include("Tecnico")          // Cargar el Tecnico relacionado
                        .Include("DetalleRepuesto")  // Cargar los Detalles de Repuesto
                        .Where(o => o.Tecnico.IdTecnico == idTecnico &&
                                    o.FechaRegistro >= desde && o.FechaRegistro <= hasta)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las órdenes por técnico y fecha: " + ex.Message);
            }
        }
        public List<OrdenServicio> ListarRepuestos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Cargar las órdenes con las propiedades relacionadas (Vehiculo, Tecnico, DetalleRepuesto, Repuesto)
                    return context.OrdenServicio
                        .Include("Vehiculo")      // Cargar el Vehiculo relacionado
                        .Include("Tecnico")       // Cargar el Tecnico relacionado
                        .Include("DetalleRepuesto") // Cargar los Detalles de Repuesto
                        .Include("DetalleRepuesto.Repuesto") // Cargar los Repuestos relacionados
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las órdenes: " + ex.Message);
            }
        }

        public List<OrdenServicio> Listar()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Cargar solo las órdenes con los vehículos y técnicos relacionados
                    var ordenes = context.OrdenServicio
                        .Include("Vehiculo")      // Cargar el Vehiculo relacionado
                        .Include("Tecnico")       // Cargar el Tecnico relacionado
                        .Include("DetalleRepuesto") // Cargar los Detalles de Repuesto
                        .ToList();

                    // Ahora que tenemos las órdenes, obtenemos todos los clientes para relacionarlos
                    var clientes = context.Cliente.ToList();

                    // Relacionamos cada orden con el cliente correspondiente
                    foreach (var orden in ordenes)
                    {
                        if (orden.Vehiculo != null)
                        {
                            orden.Vehiculo.Cliente = clientes.FirstOrDefault(c => c.IdCliente == orden.Vehiculo.IdCliente);
                        }
                    }

                    return ordenes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las órdenes: " + ex.Message);
            }
        }

        public OrdenServicio BuscarPorId(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.OrdenServicio.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la orden: " + ex.Message);
            }
        }
    }
}
