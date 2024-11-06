using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeportesBLL
    {
        DeportesDAO deporteDAO = new DeportesDAO();
        public List<Deporte> getDeportes()
        {
            return deporteDAO.getDeportes();
        }
    }
}
