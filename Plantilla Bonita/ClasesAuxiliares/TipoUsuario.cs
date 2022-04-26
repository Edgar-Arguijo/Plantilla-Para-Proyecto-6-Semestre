using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Bonita.ClasesAuxiliares
{
    public class TipoUsuario
    {
        public enum NivelAutorizacion 
        { 
            Administrador,
            PersonalAdministrativo,
            Invitado,
            Docente
        }

        private NivelAutorizacion autorizacion;
        public NivelAutorizacion Autorizacion => autorizacion;

        public TipoUsuario(NivelAutorizacion auth) { 
            this.autorizacion = auth;
        }

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