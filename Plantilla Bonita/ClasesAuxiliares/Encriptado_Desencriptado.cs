using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Bonita.ClasesAuxiliares
{
    internal class Encriptado_Desencriptado
    {
        private static string hash = "clave:0";

        static string Encriptar(string cadena) {
            
            byte[] data = UTF8Encoding.UTF8.GetBytes(cadena);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripOes = new TripleDESCryptoServiceProvider() 
                { Key=keys,Mode = CipherMode.ECB,Padding=PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripOes.CreateEncryptor();
                    byte[] result= transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result,0,result.Length);
                }
            }
        }

        static string Desencriptar(string cadena) 
        {
            byte[] data = Convert.FromBase64String(cadena);


            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripOes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripOes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result,0,result.Length);
                }
            }
        }
    }
}
