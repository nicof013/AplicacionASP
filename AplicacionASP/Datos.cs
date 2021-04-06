using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AplicacionASP
{
    public class Datos
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBLocal"].ConnectionString);

        public static bool IniciarSesion(string mail, string clave)
        {
            bool resp;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_usuario_login", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return resp;
        }

        public static bool RegistrarUsuario(string nombre, string apellido, string mail, string clave)
        {
            bool resp;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_usuario_registro", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;

                connection.Open();
                resp = cmd.ExecuteNonQuery() == 1 ? true : false;

                return resp;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool ExisteMail(string mail)
        {
            bool rpta;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_usuario_existe_mail", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    rpta = true;
                }
                else
                {
                    rpta = false;
                }

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool InsertarMensajeContacto(string nombre, string mail, string mensaje)
        {
            bool rpta;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_contacto_mensajes_insertar", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Value = mensaje;
                connection.Open();

                rpta = cmd.ExecuteNonQuery() == 1 ? true : false;

                return rpta;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable ListarUsuarios()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_usuario_listar", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(reader);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable ListarMensajes(string mail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_contacto_mensajes_listar", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(reader);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable ListarUsuarioLogueado(string mail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_usuario_logueado", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(reader);

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool RegistrarLogUsuario(string mail)
        {
            bool resp;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_log_usuarios_registro", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;

                connection.Open();
                resp = cmd.ExecuteNonQuery() == 1 ? true : false;

                return resp;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}