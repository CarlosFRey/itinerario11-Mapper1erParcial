using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;


namespace BLL
{
    public class TestDBBLL
    {
        PrimerParcialDAO testDAO = new PrimerParcialDAO();
        public string testDB(string cadenaBuscada)
        {
            return testDAO.testDB(cadenaBuscada);
        }
    }
}
