using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRepuesto
    {
        public string Registrar(Repuesto repuesto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Repuesto.Add(repuesto);
                    context.SaveChanges();
                }
                return "Repuesto registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Repuesto repuesto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var repuestoExistente = context.Repuesto.FirstOrDefault(r => r.IdRepuesto == repuesto.IdRepuesto);
                    if (repuestoExistente == null)
                    {
                        return "Repuesto no encontrado.";
                    }

                    repuestoExistente.Nombre = repuesto.Nombre;
                    repuestoExistente.Marca = repuesto.Marca;
                    repuestoExistente.CantidadStock = repuesto.CantidadStock;
                    repuestoExistente.PrecioUnitario = repuesto.PrecioUnitario;
                    repuestoExistente.StockMinimo = repuesto.StockMinimo;

                    context.SaveChanges();
                }
                return "Repuesto modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(Repuesto repuesto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var repuestoExistente = context.Repuesto.FirstOrDefault(r => r.IdRepuesto == repuesto.IdRepuesto);
                    if (repuestoExistente == null)
                    {
                        return "Repuesto no encontrado.";
                    }

                    context.Repuesto.Remove(repuestoExistente);
                    context.SaveChanges();
                }
                return "Repuesto eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Repuesto> Listar()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Repuesto.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Repuesto>();
            }
        }

        public Repuesto BuscarPorNombre(string nombre)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Repuesto
                        .FirstOrDefault(r => r.Nombre.ToLower().Contains(nombre.ToLower()));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DescontarStock(Repuesto repuesto, int cantidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var repuestoExistente = context.Repuesto.FirstOrDefault(r => r.IdRepuesto == repuesto.IdRepuesto);
                    if (repuestoExistente != null)
                    {
                        repuestoExistente.CantidadStock -= cantidad;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al descontar stock: " + ex.Message);
            }
        }

        public bool EsStockBajo(Repuesto repuesto)
        {
            try
            {
                return repuesto.CantidadStock <= repuesto.StockMinimo;
            }
            catch
            {
                return false;
            }
        }
    }
}
