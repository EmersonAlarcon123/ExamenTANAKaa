using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    class EnemigoMelee : Personaje
    {
        public EnemigoMelee(string nombre, int vida, int daño) : base(nombre, vida, daño) { }
    }

    class EnemigoRango : Personaje
    {
        public EnemigoRango(string nombre, int vida, int daño) : base(nombre, vida, daño) { }
    }
}
