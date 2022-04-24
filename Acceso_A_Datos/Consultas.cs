using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_A_Datos
{
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
