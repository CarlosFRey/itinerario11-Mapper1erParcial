using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrimerParcialDAO
    {
        public string testDB(string cadenaBuscada)
        {
            string resultado = "error en busqueda";
            try
            {
                using (SqlConnection conn = new SqlConnection(DBAccess.GetDBConnection()))
                {
                    conn.Open();
                    string query = "SELECT * FROM TESTDB";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //if (cadenaBuscada == reader.GetString(1))
                                {
                                    resultado = reader.GetString(1); //"busqueda exitosa";
                                }
                            }
                        }

                    }
                }
                return resultado;
            }
            catch (Exception ex) { throw; }
            
        }
    }
}
