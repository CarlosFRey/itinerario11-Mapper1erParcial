using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBAccess
    {
        public static string GetDBConnection()
        {
            return ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString;
        }
    }
}
