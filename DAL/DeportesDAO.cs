using Entity;
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
                                Deporte deporte = new Deporte();
                                deporte.IdDeporte = reader.GetInt32(0);
                                deporte.Descripcion = reader.GetString(1);
                                lstDeportes.Add(deporte);
                            }

                        }

                    }
                }
                return lstDeportes;
            }
            catch (Exception ex) { throw; }
        }
    }
}
