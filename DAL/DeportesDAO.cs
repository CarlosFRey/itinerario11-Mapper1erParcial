using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeportesDAO
    {
        public List<Deporte> getDeportes()
        {
            List<Deporte> lstDeportes = new List<Deporte>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string query = "SELECT * FROM DEPORTE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstDeportes.Add(DeportesMapper.Map(reader));
                            }

                        }

                    }
                }
                return lstDeportes;
            }
            catch (Exception ex) { throw; }
        }
        public Deporte getDeportesById(int idDeporte)
        {
            try
            {
                Deporte deporte = null;
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string query = "SELECT ID_DEPORTE, DESCRIPCION FROM DEPORTE WHERE ID_DEPORTE = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idDeporte);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // CONSULTA: si hago el return acá, saldría de los using dejando la conexión abierta??
                                //return DeportesMapper.Map(reader);
                                deporte = DeportesMapper.Map(reader); 
                            }
                        }
                    }
                }
                return deporte; 
            }
            catch (Exception ex) { throw; }
        }
    }
}
