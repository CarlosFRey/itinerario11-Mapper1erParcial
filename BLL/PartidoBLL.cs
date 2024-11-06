using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class PartidoBLL
    {
        PartidosDAO partidosDAO = new PartidosDAO();

        public List<Partido> getpartidos()
        {
            try
            {
                return partidosDAO.getPartidos();
            }
            catch (Exception ex) { throw; }
        }

        public void GuardarPartido(Partido nuevoPartido)
        {
            using (var trx = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(nuevoPartido.EquipoLocal)) { throw new Exception("El equipo local no puede ser Nulo"); }
                    if (string.IsNullOrEmpty(nuevoPartido.EquipoVisitante)) { throw new Exception("El equipo visitante no puede ser Nulo"); }
                    if (nuevoPartido.EquipoVisitante.Length <= 5 || nuevoPartido.EquipoLocal.Length <=5) { throw new Exception("La cantidad de caracteres en equipos local y visitante debe ser mayor a 5"); }
                    if (nuevoPartido.FechaPartido < DateTime.Now.Date) { throw new Exception("La fecha de partido no puede ser anterior a hoy"); }
                    if (nuevoPartido.MarcadorLocal != 0 || nuevoPartido.MarcadorVisitante != 0) { throw new Exception("No puede haber valores diferentes a 0 en los marcadores cuando se crea un partido"); }
                    // La fecha acctual del sistema la pongo directamente de la Base de datos cuando la cree: 	FECHA_REGISTRO DATETIME DEFAULT GETDATE(),
                    // Tiene sentido ya que el ID tambien viene de ahí.
                    partidosDAO.GuardarPartido(nuevoPartido);
                }
                catch (Exception ex) { throw; }
                trx.Complete();
            }

        }

        public void EliminarPartido(int partidoByeBye)
        {
            using (var trx = new TransactionScope())
            {

                try
                {
                    if (partidosDAO.ExistePartido(partidoByeBye) == false) { throw new Exception("No se encontró el partido en la Base de Datos"); }
                    partidosDAO.EliminarPartido(partidoByeBye);
                } catch (Exception ex) { throw; }
                trx.Complete();
            }

        }

        public void ActualizarDatosPartido(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            using (var trx = new TransactionScope())
            {

                try
                {
                    if(marcadorLocal < 0|| marcadorVisitante < 0 ) { throw new Exception("Los marcadores no pueden ser negativos"); }
                    if(idPartido < 0) { throw new Exception("El id de partido es incorrecto"); }
                    if (partidosDAO.ObtenerFecha(idPartido).Date != DateTime.Now.Date) { throw new Exception("Solo se pueden modificar los partidos que se jueguen en la fecha de hoy"); }
                    partidosDAO.ActualizarDatosPartido(idPartido, marcadorLocal, marcadorVisitante);
                }
                catch (Exception ex) { throw; }
                trx.Complete();
            }
            
        }

        public List<Partido> ObtenerResultados(int IdPartido)
        {
            try
            {
                //if (IdPartido < 0) { throw new Exception("Error en la obtención de resultados por IdPartido en BLL"); }
                if(partidosDAO.ExistePartido(IdPartido) == false) { throw new Exception("No se encontró el partido en la Base de Datos"); }
                return partidosDAO.ObtenerResultados(IdPartido);
            }
            catch (Exception ex) { throw; }
        }

        public void GuardarColaPartidos(List<Partido> lstPartidos)
        {
            using (var trx = new TransactionScope())
            {
                try
                {
                    foreach (var nuevoPartido in lstPartidos)
                    {
                        if (string.IsNullOrEmpty(nuevoPartido.EquipoLocal)) { throw new Exception("El equipo local no puede ser Nulo"); }
                        if (string.IsNullOrEmpty(nuevoPartido.EquipoVisitante)) { throw new Exception("El equipo visitante no puede ser Nulo"); }
                        if (nuevoPartido.EquipoVisitante.Length <= 5 || nuevoPartido.EquipoLocal.Length <= 5) { throw new Exception("La cantidad de caracteres en equipos local y visitante debe ser mayor a 5 (adiós Boquita, no calificaste)"); }
                        if (nuevoPartido.FechaPartido < DateTime.Now.Date) { throw new Exception("La fecha de partido no puede ser anterior a hoy"); }
                        if (nuevoPartido.MarcadorLocal != 0 || nuevoPartido.MarcadorVisitante != 0) { throw new Exception("No puede haber valores diferentes a 0 en los marcadores cuando se crea un partido"); }
                        // La fecha acctual del sistema la pongo directamente de la Base de datos cuando la cree: 	FECHA_REGISTRO DATETIME DEFAULT GETDATE(),
                        // Tiene sentido ya que el ID tambien viene de ahí.
                        partidosDAO.GuardarPartido(nuevoPartido);
                    }
                }
                catch (Exception ex) { throw; }
                trx.Complete();
            }
        }

    }
}
