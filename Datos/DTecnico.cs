using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTecnico
    {
        public string Registrar(Tecnico tecnico)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Tecnico.Add(tecnico);
                    context.SaveChanges();
                }
                return "Técnico registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Tecnico tecnico)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var tecnicoExistente = context.Tecnico.FirstOrDefault(t => t.IdTecnico == tecnico.IdTecnico);
                    if (tecnicoExistente == null)
                    {
                        return "Técnico no encontrado.";
                    }

                    tecnicoExistente.Nombres = tecnico.Nombres;
                    tecnicoExistente.Apellidos = tecnico.Apellidos;
                    tecnicoExistente.Especialidad = tecnico.Especialidad;
                    tecnicoExistente.Disponible = tecnico.Disponible;

                    context.SaveChanges();
                }
                return "Técnico modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(Tecnico tecnico)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var tecnicoExistente = context.Tecnico.FirstOrDefault(t => t.IdTecnico == tecnico.IdTecnico);
                    if (tecnicoExistente == null)
                    {
                        return "Técnico no encontrado.";
                    }

                    context.Tecnico.Remove(tecnicoExistente);
                    context.SaveChanges();
                }
                return "Técnico eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Tecnico> ListarTecnicos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Tecnico.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Tecnico>();
            }
        }

        public Tecnico BuscarPorNombre(string nombre)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Tecnico
                        .FirstOrDefault(t => (t.Nombres + " " + t.Apellidos).ToLower().Contains(nombre.ToLower()));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void MarcarNoDisponible(Tecnico tecnico)
        {
            using (var context = new BDEFEntities()) 
            {
                var tecnicoDb = context.Tecnico.Find(tecnico.IdTecnico); // Buscamos al técnico en la base de datos
                if (tecnicoDb != null)
                {
                    tecnicoDb.Disponible = false; // Marcamos como no disponible
                    context.SaveChanges(); // Guardamos los cambios en la base de datos
                }
            }
        }
    }
}
