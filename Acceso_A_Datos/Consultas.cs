using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_A_Datos
{
    //Hola
    public class Consultas : SQLConection
    {
        public void ProbarConexion() {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                Console.WriteLine("Conexion Realizada con Exito");
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
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);
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

            throw new NotImplementedException();
        }
    }
}
