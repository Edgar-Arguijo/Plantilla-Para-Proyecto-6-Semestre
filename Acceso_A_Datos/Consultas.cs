using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acceso_A_Datos
{
    /// <summary>
    /// Clase que realiza consultas con la base de datos
    /// </summary>
    public class Consultas : SQLConection
    {
        /// <summary>
        /// Clase para probar la conexion
        /// </summary>
        public void ProbarConexion() {

            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //Abre la conexion
                    conexion.Open();
                    //Console Log
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

        /// <summary>
        /// Realiza una busqueda con el codigo Intenieria
        /// </summary>
        /// <param name="codIngenieria">Codigo de la ingenieria</param>
        /// <returns>La descripcion de la ingenieria</returns>
        public string BuscarCodIngenieria(string codIngenieria)
        {
            //Utilizando la conexion
            using (SqlConnection conexion = getConnection())
            {
                //Abrimos la conexion
                conexion.Open();
                //Utilizando el comando de SQL
                using (SqlCommand cmd = new SqlCommand("Select Cod_Ing From Ingenierias Where Descripcion = @descripcion", conexion))
                {
                    try
                    {
                        //Definimos al conexion [Redundantemente]
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        //Pase de parametros
                        cmd.Parameters.AddWithValue("@descripcion", codIngenieria);
                        return Convert.ToString(cmd.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        //En caso de salir mal
                        return null;
                    }
                }
            }
        }

        #region Altas

        /// <summary>
        /// Da de alta un usuario
        /// </summary>
        /// <param name="usuario">El usuario que se de dio de alta</param>
        /// <param name="contra">La contraseña de dicho usuario</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaUsuario(string usuario, string contra)
        {
            using (SqlConnection conexion = getConnection())
            {
                //Se abre la conexion
                conexion.Open();
                //Utilizando el comando de SQL
                using (SqlCommand cmd = new SqlCommand("AltaUsuario", conexion))
                {
                    try
                    {
                        //Definimos el tipo de comando
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Pasamos los parametros del procedimiento almacenado
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", Encriptado_Desencriptado.Encriptado_Desencriptado.Encriptar(contra));
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        //Ejecutamos
                        return (cmd.ExecuteNonQuery()>0);
                    }
                    catch (Exception ex)
                    {
                        //En caso de salir mal
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Da de alta una ingenieria
        /// </summary>
        /// <param name="usuario">El usuario que la da de alta</param>
        /// <param name="cod">Codigo de la ingenieria</param>
        /// <param name="desc">La decripcion de la ingenieria</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaIngenieria(string usuario, string cod, string desc) 
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //Abrimos la conexion
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AltaIngenieria", conexion)) 
                    {
                        //Defininmos el tipo de comando
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Pasamos los parametros
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@codIngenieria", cod);
                        cmd.Parameters.AddWithValue("@Nombre", desc);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        //Parametro de salida
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        //Ejecutamos
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
                //En caso de salir mañ
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Procedimiento que da de alta un Aula
        /// </summary>
        /// <param name="usuario">El usuario que la da de alta</param>
        /// <param name="codEdificio">El codigo del edificio</param>
        /// <param name="codAula">El codigo del aula</param>
        /// <param name="desc">La descripcion del aula</param>
        /// <returns>Si se realizo correctamente</returns>
        public bool AltaAula(string usuario, string codEdificio, string codAula, string desc)
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //Se abree la conexion
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AltaAulas", conexion))
                    {
                        //Se define el tipo de comando
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Pase de parametros
                        cmd.Parameters.AddWithValue("@codAula", codAula);
                        cmd.Parameters.AddWithValue("@codEficio", codEdificio);
                        cmd.Parameters.AddWithValue("@descripcion", desc);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        //Parametro de salida
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        //Ejecutamos el Query
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
                //En caso de salir mal hacemos un Log
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Realiza un alta de materia
        /// </summary>
        /// <param name="codIng">Codigo de la ingenieria</param>
        /// <param name="codMateria">Codigo de la materia</param>
        /// <param name="desc">Descripcion de la materia</param>
        /// <param name="semestre">Semestre de la materia</param>
        /// <param name="usuario">Usuario que realiza el alta</param>
        /// <returns>Retorna si se realiza la consulta</returns>
        public bool AltaMateria(string codIng, string codMateria, string desc, int semestre, string usuario)
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //Se abre la conexion
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AltaMateria", conexion))
                    {
                        //Defininmos el tipo de procedimiento
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se definen los parametros
                        cmd.Parameters.AddWithValue("@Cod_Ingenieria", codIng);
                        cmd.Parameters.AddWithValue("@Cod_Materia", codMateria);
                        cmd.Parameters.AddWithValue("@Descripcion", desc);
                        cmd.Parameters.AddWithValue("@semestre", semestre);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        //Parametro de salida
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
                //En caso de salir mal
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Realiza una copia de seguridad
        /// </summary>
        /// <returns>Si se realizo la copia de seguridad</returns>
        public bool CopiaDeSeguridad()
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //Abre la conexion
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("CopiaDeSeguridad", conexion))
                    {
                        //Se define el tipo de procedimiento
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@flag", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        //Se ejecuta el Query
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
                //En caso de salir mal
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Realiza el loggeo
        /// </summary>
        /// <param name="usuario">El nombre del usuario</param>
        /// <param name="contraseña">La contraseña del usuario</param>
        /// <returns>El tipo de usuario</returns>
        public string Loggeo(string usuario, string contraseña)
        {
            using (SqlConnection conexion = getConnection())
            {
                //Abre la conexion
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Loggeo", conexion))
                {
                    try
                    {
                        //Se define el tipo de procedimiento
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        //Se definene los parametros
                        cmd.Parameters.AddWithValue("@usuario", usuario); 
                        cmd.Parameters.AddWithValue("@contraseña", Encriptado_Desencriptado.Encriptado_Desencriptado.Encriptar(contraseña));
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        //Parametro de salida del nivel
                        cmd.Parameters.Add("@level", SqlDbType.VarChar, int.MaxValue).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output;
                        
                        //Ejecutamos el procedimiento
                        cmd.ExecuteNonQuery();

                        if (cmd.Parameters["@mensaje"].Value.ToString() == "NOUSER")
                        {
                            MessageBox.Show("El usuario no se encuentra registrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return "error";
                        }

                        if (cmd.Parameters["@mensaje"].Value.ToString() == "BADPASSWORD")
                        {
                            MessageBox.Show("La contraseña proporcionada es incorrecta", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return "error";
                        }

                        return cmd.Parameters["@level"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        //En caso de salir mal
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// Busca el codigo de la materia
        /// </summary>
        /// <param name="codIng">Codigo de la ingenieria</param>
        /// <param name="descripcion">Descripcion de la materia</param>
        /// <returns>El codigo de la materia</returns>
        public string BuscarCodMateria(string codIng, string descripcion)
        {
            using (SqlConnection conexion = getConnection())
            {
                //Se abre la conexion
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select Cod_Materia From View_MateriasIngenieria Where Cod_Ing = @codIng and Descripcion = @descripcion", conexion))
                {
                    try
                    {
                        //Establecemos la conexion [Redundantemente]
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        //Definimos los parametros
                        cmd.Parameters.AddWithValue("@codIng", codIng);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        return Convert.ToString(cmd.ExecuteScalar());
                    }
                    catch (Exception e)
                    {
                        //En caso de salir mal
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }
            }
        }
    }
}
