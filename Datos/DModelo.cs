using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DModelo
    {
        public string Registrar(int idMarca, string modelo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var nuevoModelo = new ModeloVehiculo
                    {
                        IdMarca = idMarca,
                        Nombre = modelo
                    };
                    context.ModeloVehiculo.Add(nuevoModelo);
                    context.SaveChanges();
                }
                return "Modelo registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ModeloVehiculo> ListarModelosPorMarca(int idMarca)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.ModeloVehiculo.Where(m => m.IdMarca == idMarca).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<ModeloVehiculo>();
            }
        }
        public string Modificar(int idModelo, string nombreModelo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var modelo = context.ModeloVehiculo.FirstOrDefault(m => m.IdModelo == idModelo);
                    if (modelo != null)
                    {
                        modelo.Nombre = nombreModelo;
                        context.SaveChanges();
                        return "Modelo modificado correctamente.";
                    }
                    return "Modelo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el modelo: " + ex.Message;
            }
        }

        public string Eliminar(int idModelo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var modelo = context.ModeloVehiculo.FirstOrDefault(m => m.IdModelo == idModelo);
                    if (modelo != null)
                    {
                        context.ModeloVehiculo.Remove(modelo);
                        context.SaveChanges();
                        return "Modelo eliminado correctamente.";
                    }
                    return "Modelo no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el modelo: " + ex.Message;
            }
        }
    }
}
