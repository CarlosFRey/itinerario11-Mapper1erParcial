using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class DeportesMapper
    {
        public static Deporte Map(SqlDataReader reader)
        {
            Deporte deporte = new Deporte();
            deporte.IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"].ToString());
            deporte.Descripcion = reader["DESCRIPCION"].ToString();
            return deporte;
        }
    }
}
