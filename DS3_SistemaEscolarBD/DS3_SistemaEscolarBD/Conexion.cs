using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DS3_SistemaEscolarBD
{
    public class ConexionBD
    {
        public string txtConexion = "Server=DAMIAN_PC\\SQLEXPRESS; Database=DS3_Catalogos; Integrated Security=True; TrustServerCertificate=True";

        public DataTable ObtieneDatosBD(string txtConsulta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(txtConexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(txtConsulta, txtConexion);
                    ad.Fill(dt); // Llenamos el DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
            }
                
            return dt; // Regresamos el DataTable
        }

        public int InsertarDatosBD(string nombre_stp, string[] nombresParametros, object[] valoresParametros)
        {
            int renglonesfectados = 0;

            using (SqlConnection conexion = new SqlConnection(txtConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(nombre_stp, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < nombresParametros.Length; i++)
                    {
                        comando.Parameters.AddWithValue("@" + nombresParametros[i], valoresParametros[i]);
                    }

                    SqlParameter regresoParam = new SqlParameter("@Regreso", SqlDbType.Bit);
                    regresoParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(regresoParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100);
                    mensajeParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(mensajeParam);

                    comando.ExecuteNonQuery();
                    renglonesfectados = Convert.ToInt32(comando.Parameters["@Regreso"].Value);

                    if (renglonesfectados >= 1)
                    {
                        MessageBox.Show("Éxito al insertar el registro");
                    }
                    else
                    {
                        MessageBox.Show("Error desconocido al insertar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al insertar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return renglonesfectados;
        }

        public int EditarDatosBD(string nombre_stp, string[] nombresParametros, object[] valoresParametros)
        {
            int registrosEditados = 0;

            using (SqlConnection conexion = new SqlConnection(txtConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(nombre_stp, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < nombresParametros.Length; i++)
                    {
                        comando.Parameters.AddWithValue("@" + nombresParametros[i], valoresParametros[i]);
                    }

                    SqlParameter regresoParam = new SqlParameter("@Regreso", SqlDbType.Bit);
                    regresoParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(regresoParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100);
                    mensajeParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(mensajeParam);

                    comando.ExecuteNonQuery();
                    registrosEditados = Convert.ToInt32(comando.Parameters["@Regreso"].Value);

                    if (registrosEditados >= 1)
                    {
                        MessageBox.Show("Éxito al editar el registro");
                    }
                    else
                    {
                        MessageBox.Show("Error desconocido al editar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return registrosEditados;
        }

        public int EliminarDatosBD(string nombre_stp, string nombreParametro, object valorParametro)
        {
            int numeroRenglonesAfectados = 0;

            using (SqlConnection conexion = new SqlConnection(txtConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(nombre_stp, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@" + nombreParametro, valorParametro);

                    SqlParameter regresoParam = new SqlParameter("@Regreso", SqlDbType.Bit);
                    regresoParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(regresoParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100);
                    mensajeParam.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(mensajeParam);

                    comando.ExecuteNonQuery();
                    numeroRenglonesAfectados = Convert.ToInt32(comando.Parameters["@Regreso"].Value);

                    if (numeroRenglonesAfectados >= 1)
                    {
                        MessageBox.Show("Se eliminaron " + numeroRenglonesAfectados + " registros.");
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó nada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return numeroRenglonesAfectados;
        }
    }
}
