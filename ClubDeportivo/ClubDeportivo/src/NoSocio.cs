using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class NoSocios {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public uint DNI { get; set; }

        public NoSocios(string nombre) {
            Nombre = nombre;
        }
    }
}