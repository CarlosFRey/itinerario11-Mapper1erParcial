using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Partido
    {
        public Deporte deportePartido;
        public int IdPartido { get; set; }
        
        //Se elimina la clave foranea y se agrega el objeto Deporte 
        //public int IdDeporte { get; set; }

        public string EquipoLocal {  get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaPartido { get; set; }
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }
        public string DescripcionDeporte
        {
            get { return deportePartido != null ? deportePartido.Descripcion : "Sin Deporte"; }
        }
        public Deporte DeportePartido { get => deportePartido; set => deportePartido = value; }

    }
}
