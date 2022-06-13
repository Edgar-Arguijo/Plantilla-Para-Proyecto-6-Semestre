using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA_ITSL.ClasesAuxiliares
{
    /// <summary>
    /// Clase que nos servira para pasar parametros y registar cambios en bitacora
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        private string Name;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        public Usuario(string nombre) 
        {
            Name = nombre;
        }

        /// <summary>
        /// Metodo de lectura para el nombre
        /// </summary>
        public string Nombre { get => Name; }
    }
}
