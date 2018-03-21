using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            /*Se crea con este metodo la base de datos*/
            context.Database.EnsureCreated();

            //Buscar si existen registro en la tabla categoría
            if (context.Categoria.Any())
            {
                return;
            }

            //si la base de datos está vacía va a llenar con registros la base de datos
            var categorias = new Categoria[]
            {
                new Categoria{ Nombre = "Programación", Descripcion = "Curso de Programación", Estado = true},
                new Categoria{ Nombre = "Diseño Gráfico", Descripcion = "Curso de Diseño Gráfico", Estado = true}
            };

            //Se recorre el array con los nuevos datos para la Base de Datos y se inserta uno a uno los registros
            foreach (Categoria C in categorias)
            {
                context.Categoria.Add(C);
            }

            context.SaveChanges();
        }
    }
}
