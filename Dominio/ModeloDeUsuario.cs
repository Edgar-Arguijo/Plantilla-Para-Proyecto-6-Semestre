using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_A_Datos;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloDeUsuario
    {
        private Consultas obj = new Consultas();

        public void ProbarConexion() {
            obj.ProbarConexion();
        }

        public bool CopiaDeSeguridad() 
        { 
            return obj.CopiaDeSeguridad();
        }
        public string BuscarCodIngenieria(string text)
        {
            return obj.BuscarCodIngenieria(text);
        }

        public string BuscarCodMateria(string codIng, string text)
        {
            return obj.BuscarCodMateria(codIng, text);
        }

        public string Loggeo(string usuario, string contraseña)
        {
            return obj.Loggeo(usuario, contraseña);
        }

        public bool AltaUsuario(string usuario, string contra)
        {
            return obj.AltaUsuario(usuario, contra);
        }
    }
}
