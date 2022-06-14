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
        /// <summary>
        /// Objeto de acceso a Consultas
        /// </summary>
        private Consultas obj = new Consultas();

        /// <summary>
        /// Metodo de acceso a Consultas ProbarConexion
        /// </summary>
        public void ProbarConexion() 
        {
            obj.ProbarConexion();
        }

        /// <summary>
        /// Metodo de acceso a AltaMateria
        /// </summary>
        /// <param name="codIng">Codigo de la ingenieria</param>
        /// <param name="codMateria">Codigo de la materia</param>
        /// <param name="desc">Descripcion de la materia</param>
        /// <param name="semestre">Semestre de la materia</param>
        /// <param name="usuario">Usuario que realiza el alta</param>
        /// <returns>Retorna si se realiza la consulta</returns>
        public bool AltaMateria(string codIng, string codMateria, string desc, int semestre, string usuario)
        {
            return obj.AltaMateria(codIng, codMateria, desc, semestre, usuario);
        }

        /// <summary>
        /// Metodo de acceso a AltaAula
        /// </summary>
        /// <param name="usuario">El usuario que la da de alta</param>
        /// <param name="codEdificio">El codigo del edificio</param>
        /// <param name="codAula">El codigo del aula</param>
        /// <param name="desc">La descripcion del aula</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaAula(string usuario, string codEdificio, string codAula, string desc)
        {
            return obj.AltaAula(usuario,codEdificio,codAula,desc);
        }

        /// <summary>
        /// Metodo de acceso a AltaIngenieria
        /// </summary>
        /// <param name="usuario">El usuario que la da de alta</param>
        /// <param name="cod">Codigo de la ingenieria</param>
        /// <param name="desc">La decripcion de la ingenieria</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaIngenieria(string usuario, string cod, string desc) 
        {
            return obj.AltaIngenieria(usuario,cod,desc);
        }

        /// <summary>
        /// Metodo de acceso a CopiaDeSeguridad
        /// </summary>
        /// <returns>Si se realizo la copia de seguridad</returns>
        public bool CopiaDeSeguridad() 
        { 
            return obj.CopiaDeSeguridad();
        }
        /*public bool ActualizarUsuario(string usuario, string contra, string rol, string newName, string newPass, string newRol)
        {
            return obj.ActualizarUsuario(usuario, contra, rol, newName, newPass, newRol);
        }*/

        /// <summary>
        /// Metodo de acceso a BuscarCodIngenieria
        /// </summary>
        /// <param name="codIngenieria">Codigo de la ingenieria</param>
        /// <returns>La descripcion de la ingenieria</returns>
        public string BuscarCodIngenieria(string codIngenieria)
        {
            return obj.BuscarCodIngenieria(codIngenieria);
        }

        /// <summary>
        /// Metodo de acceso a BuscarCodMateria
        /// </summary>
        /// <param name="codIng">Codigo de la ingenieria</param>
        /// <param name="descripcion">Descripcion de la materia</param>
        /// <returns>El codigo de la materia</returns>
        public string BuscarCodMateria(string codIng, string descripcion)
        {
            return obj.BuscarCodMateria(codIng, descripcion);
        }

        /// <summary>
        /// Metodo de acceso a Loggeo
        /// </summary>
        /// <param name="usuario">El nombre del usuario</param>
        /// <param name="contraseña">La contraseña del usuario</param>
        /// <returns>El tipo de usuario</returns>
        public string Loggeo(string usuario, string contraseña)
        {
            return obj.Loggeo(usuario, contraseña);
        }

        /// <summary>
        /// Metodo de acceso a AltaUsuario
        /// </summary>
        /// <param name="usuario">El usuario que se de dio de alta</param>
        /// <param name="contra">La contraseña de dicho usuario</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaUsuario(string usuario, string contra)
        {
            return obj.AltaUsuario(usuario, contra);
        }
    }
}
