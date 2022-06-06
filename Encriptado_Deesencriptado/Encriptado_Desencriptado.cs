using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encriptado_Desencriptado
{
    public static class Encriptado_Desencriptado
    {
        /// <summary>
        /// Clase para el encriptado de las contraseñas
        /// </summary>
            private static string hash = "clave:0";

            /// <summary>
            /// Encripta el texto deseado
            /// </summary>
            /// <param name="cadena">Texto a encriptar</param>
            /// <returns>El texto ya encriptado</returns>
            public static string Encriptar(string cadena)
            {
                //Obtiene los bytes de la cadena
                byte[] data = UTF8Encoding.UTF8.GetBytes(cadena);
                //Utiliza libreria de encriptacion
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    //Obtiene los bytes con el hash definido por la clase
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripOes = new TripleDESCryptoServiceProvider()
                    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripOes.CreateEncryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return Convert.ToBase64String(result, 0, result.Length);
                    }
                }
            }

        /// <summary>
        /// Desencripta la cadena deseada
        /// </summary>
        /// <param name="cadena">Cadena a desencriptar</param>
        /// <returns>La cadena desencriptada</returns>
        public static string Desencriptar(string cadena)
        {
            //Obtiene los bytes de la cadena
            byte[] data = Convert.FromBase64String(cadena);
            //Utiliza libreria de encriptacion
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                //Obtiene los bytes con el hash definido por la clase
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripOes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripOes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result, 0, result.Length);
                }
            }
        }
    }
}
