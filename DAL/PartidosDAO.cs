using System;
using Mapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PartidosDAO
    {
        DeportesDAO DeportesDAO = new DeportesDAO();
        public List<Partido> getPartidos()
        {
            try
            {
                List<Partido> lstPartidos = new List<Partido>();
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PARTIDO", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Deporte deporte = DeportesDAO.getDeportesById(Convert.ToInt32(reader["ID_DEPORTE"].ToString()));
                                Partido nuevoPartido = PartidosMapper.Map(reader, deporte);
                                lstPartidos.Add(nuevoPartido);
                            }
                        }
                    }
                }
                return lstPartidos;
            }
            catch (Exception ex) { throw; }
        }

        public void GuardarPartido(Partido nuevoPartido)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string cadenaGuardado = "INSERT INTO PARTIDO (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE) VALUES (@IdDeporte, @EquipoLocal, @EquipoVisitante, @FechaPartido, @MarcadorLocal, @MarcadorVisitante)";
                    using (SqlCommand cmd = new SqlCommand(cadenaGuardado, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdDeporte", nuevoPartido.DeportePartido.IdDeporte);
                        cmd.Parameters.AddWithValue("@EquipoLocal", nuevoPartido.EquipoLocal);
                        cmd.Parameters.AddWithValue("@EquipoVisitante", nuevoPartido.EquipoVisitante);
                        cmd.Parameters.AddWithValue("@FechaPartido", nuevoPartido.FechaPartido);
                        cmd.Parameters.AddWithValue("@MarcadorLocal", nuevoPartido.MarcadorLocal);
                        cmd.Parameters.AddWithValue("@MarcadorVisitante", nuevoPartido.MarcadorVisitante);
                        cmd.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex) { throw; }
        }

        public void EliminarPartido(int byePartido)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string cadenaByeBye = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand cmd = new SqlCommand(cadenaByeBye, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", byePartido);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

        public void ActualizarDatosPartido(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string cadenaUpdate = "UPDATE PARTIDO SET MARCADOR_LOCAL = @MarcadorLocal, MARCADOR_VISITANTE = @MarcadorVisitante WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand cmd = new SqlCommand(cadenaUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@MarcadorLocal", marcadorLocal);
                        cmd.Parameters.AddWithValue("@MarcadorVisitante", marcadorVisitante);
                        cmd.Parameters.AddWithValue("@IdPartido", idPartido);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw; }
        }

        public DateTime ObtenerFecha (int IdPartido)
        {
            try
            {
                DateTime resultado = DateTime.Now;
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PARTIDO", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == IdPartido) { resultado = reader.GetDateTime(5); }
                            }
                        }
                    }
                }
                return resultado;
            }
            catch (Exception ex) { throw; }
        }

        public List<Partido> ObtenerResultados(int IdPartido)
        {
            List<Partido> resultados = new List<Partido>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PARTIDO", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Partido nuevoPartido = new Partido();

                                nuevoPartido.IdPartido = reader.GetInt32(0);
                                nuevoPartido.DeportePartido.IdDeporte = reader.GetInt32(1);
                                nuevoPartido.EquipoLocal = reader.GetString(2);
                                nuevoPartido.EquipoVisitante = reader.GetString(3);
                                nuevoPartido.FechaRegistro = reader.GetDateTime(4);
                                nuevoPartido.FechaPartido = reader.GetDateTime(5);
                                nuevoPartido.MarcadorLocal = reader.GetInt32(6);
                                nuevoPartido.MarcadorVisitante = reader.GetInt32(7);
                                
                                resultados.Add(nuevoPartido);
                            }
                        }
                    }
                }
                return resultados;
            }
            catch (Exception ex) { throw; }
        }

        public bool ExistePartido(int IdPartido)
        {
            try
            {
                bool existePartido = false;
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PARTIDO", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == IdPartido) { existePartido = true; }
                            }
                        }
                    }
                }
                return existePartido;
            }
            catch (Exception ex) { throw; }
        }
    }

}
