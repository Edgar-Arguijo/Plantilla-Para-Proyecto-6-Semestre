using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//nada
namespace Acceso_A_Datos
{
    public class Consultas : SQLConection
    {
        internal class Encriptado_Desencriptado
        {
            private static string hash = "clave:0";

            public static string Encriptar(string cadena)
            {

                byte[] data = UTF8Encoding.UTF8.GetBytes(cadena);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
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

            public static string Desencriptar(string cadena)
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
                        return UTF8Encoding.UTF8.GetString(result, 0, result.Length);
                    }
                }
            }
        }

        public void ProbarConexion() {


            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();
                    Console.WriteLine("Conexion Realizada con Exito");
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Porfavor consulte al administrador", "Error con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        public string BuscarCodIngenieria(string text)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select Cod_Ing From Ingenierias Where Descripcion = @descripcion", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@descripcion", text);
                        return Convert.ToString(cmd.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return null;
        }

        public bool AltaUsuario(string usuario, string contra)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("AltaUsuario", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", Encriptado_Desencriptado.Encriptar(contra));
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        return (cmd.ExecuteNonQuery()>0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool AltaIngenieria(string usuario, string cod, string desc) 
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AltaIngenieria", conexion)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@codIngenieria", cod);
                        cmd.Parameters.AddWithValue("@Nombre", desc);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        if (cmd.Parameters["@flag"].Value.ToString() == "0")
                            return false;

                        if (cmd.Parameters["@flag"].Value.ToString() == "1")
                            return true;

                        //

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AltaMateria(string codIng, string codMateria, string desc, int semestre, string usuario)
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AltaMateria", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Cod_Ingenieria", codIng);
                        cmd.Parameters.AddWithValue("@Cod_Materia", codMateria);
                        cmd.Parameters.AddWithValue("@Descripcion", desc);
                        cmd.Parameters.AddWithValue("@semestre", semestre);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        if (cmd.Parameters["@flag"].Value.ToString() == "0")
                            return false;

                        if (cmd.Parameters["@flag"].Value.ToString() == "1")
                            return true;

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CopiaDeSeguridad()
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("CopiaDeSeguridad", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        Console.WriteLine($"El resultado es: {cmd.Parameters["@flag"].Value.ToString()}");

                        if (cmd.Parameters["@flag"].Value.ToString()=="0")
                            return false;

                        if (cmd.Parameters["@flag"].Value.ToString() == "1")
                            return true;

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string Loggeo(string usuario, string contraseña)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Loggeo", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", Encriptado_Desencriptado.Encriptar(contraseña));
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.Parameters.Add("@level", SqlDbType.VarChar, Int32.MaxValue).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        return cmd.Parameters["@level"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
        }

        public string BuscarCodMateria(string codIng, string descripcion)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select Cod_Materia From View_MateriasIngenieria Where Cod_Ing = @codIng and Descripcion = @descripcion", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@codIng", codIng);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        return Convert.ToString(cmd.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            return null;
        }
    }
}
