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

        public void ProbarConexion() 
        {
            obj.ProbarConexion();
        }

        public bool AltaMateria(string codIng, string codMateria, string desc, int semestre, string usuario)
        {
            return obj.AltaMateria(codIng, codMateria, desc, semestre, usuario);
        }

        public bool AltaAula(string usuario, string codEdificio, string codAula, string desc)
        {
            return obj.AltaAula(usuario,codEdificio,codAula,desc);
        }

        public bool AltaIngenieria(string usuario, string cod, string desc) 
        {
            return obj.AltaIngenieria(usuario,cod,desc);
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
