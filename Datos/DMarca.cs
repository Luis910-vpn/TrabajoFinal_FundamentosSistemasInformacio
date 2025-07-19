using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMarca
    {
        public string Registrar(string marca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var nuevaMarca = new MarcaVehiculo { Nombre = marca };
                    context.MarcaVehiculo.Add(nuevaMarca);
                    context.SaveChanges();
                }
                return "Marca registrada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<MarcaVehiculo> ListarMarcas()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.MarcaVehiculo.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<MarcaVehiculo>();
            }
        }
        public string Modificar(int idMarca, string nombreMarca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var marca = context.MarcaVehiculo.FirstOrDefault(m => m.IdMarca == idMarca);
                    if (marca != null)
                    {
                        marca.Nombre = nombreMarca;
                        context.SaveChanges();
                        return "Marca modificada correctamente.";
                    }
                    return "Marca no encontrada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar la marca: " + ex.Message;
            }
        }

        public string Eliminar(int idMarca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var marca = context.MarcaVehiculo.FirstOrDefault(m => m.IdMarca == idMarca);
                    if (marca != null)
                    {
                        context.MarcaVehiculo.Remove(marca);
                        context.SaveChanges();
                        return "Marca eliminada correctamente.";
                    }
                    return "Marca no encontrada.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la marca: " + ex.Message;
            }
        }
    }
}
