using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_ITSL.ClasesAuxiliares
{
    /// <summary>
    /// Clase para la definicio de controles en base a el tipo de usuario
    /// </summary>
    public class TipoUsuario
    {
        /// <summary>
        /// Enumerado que nos permite distinguir los niveles
        /// </summary>
        public enum NivelAutorizacion 
        { 
            Administrador,
            PersonalAdministrativo,
            Invitado,
            Docente
        }

        //Objeto privado interno para la autorizacion
        private NivelAutorizacion autorizacion;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="auth">Nivel de Autorizacion</param>
        public TipoUsuario(NivelAutorizacion auth) { 
            this.autorizacion = auth;
        }

        /// <summary>
        /// Metodo que obtiene el nivel de autorizacion
        /// </summary>
        /// <param name="autorizacion">El nivel de autorizacio</param>
        /// <returns>El tipo de autorizacion segun el enum</returns>
        public static NivelAutorizacion ObtenerNivel(string autorizacion) 
        {
            if (autorizacion == "" | autorizacion == null)
                MessageBox.Show("Credenciales incorrectas, por favor intentelo nuevamente");

            switch (autorizacion.ToLower())
            {
                case "administrador":
                    return NivelAutorizacion.Administrador;

                case "administrativo":
                    return NivelAutorizacion.PersonalAdministrativo;

                case "docente":
                    return NivelAutorizacion.Docente;

                default:
                    return NivelAutorizacion.Invitado;
            }
        }
    }
}