using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Bonita.ClasesAuxiliares
{
    public class Usuario
    {
        private string Name;
        //private bool Active;

        public Usuario(string nombre) 
        {
            Name = nombre;
        }

        public string Nombre { get => Name; }
        //public bool Habilitado { get => Active; }
    }
}
