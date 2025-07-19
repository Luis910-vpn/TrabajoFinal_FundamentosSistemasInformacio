using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRepuesto
    {
        private DRepuesto dRepuesto = new DRepuesto();

        public bool Registrar(Repuesto repuesto)
        {
            // Cambié la devolución de un string a un bool.
            // Si la operación es exitosa, devuelve true. Si no, devuelve false.
            string mensaje = dRepuesto.Registrar(repuesto);

            return mensaje == "Repuesto registrado correctamente.";
        }

        public string Modificar(Repuesto repuesto)
        {
            return dRepuesto.Modificar(repuesto);
        }

        public string Eliminar(Repuesto repuesto)
        {
            return dRepuesto.Eliminar(repuesto);
        }

        public List<Repuesto> Listar()
        {
            return dRepuesto.Listar();
        }

        public Repuesto BuscarPorNombre(string nombre)
        {
            return dRepuesto.BuscarPorNombre(nombre);
        }

        public void DescontarStock(Repuesto repuesto, int cantidad)
        {
            dRepuesto.DescontarStock(repuesto, cantidad);
        }

        public bool EsStockBajo(Repuesto repuesto)
        {
            return dRepuesto.EsStockBajo(repuesto);
        }
    }
}
