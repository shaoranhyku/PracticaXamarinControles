﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PracticaXamarinControles.resources
{
    class Leer
    {
        /// <summary>
        /// Permite leer un archivo de texto a partir de una ruta recibida.
        /// </summary>
        /// <param name="ruta">Ruta donde se encuentra el archivo</param>
        /// <returns>Lista de contactos creados a partir del archivo</returns>
        public static List<Contacto> LeerArchivo(String ruta)
        {
            
            List<Contacto> arrText = new List<Contacto>();
            String edad;
            String nombre;
            String dni;

            var assembly = typeof(Leer).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(ruta);

            StreamReader objReader = new StreamReader(stream);

            do
            {

                nombre = objReader.ReadLine();
                edad = objReader.ReadLine();
                dni = objReader.ReadLine();
                if (nombre != null && edad != null && dni != null)
                {
                    arrText.Add(new Contacto(nombre, edad, dni));
                }

            } while (nombre != null && edad != null && dni != null);

            return arrText;
        }
    }
}