using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class Actividades {
        public string nombreActividad {  get; set; }
        public sbyte id {  get; set; }
        public sbyte cupo { get; set; }
        public List<Socios>Inscriptos { get; set; } 

        public Actividades(string nombre) { 
            nombreActividad = nombre.ToLower();
            cupo = Convert.ToSByte(30);
            Inscriptos = new List<Socios>();
        }
    }
}
