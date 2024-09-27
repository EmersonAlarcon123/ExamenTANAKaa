using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    class PocionVida : Item
    {
        public int CantidadRecuperar { get; set; }

        public PocionVida(int cantidadRecuperar)
            : base("Poción de Vida")
        {
            CantidadRecuperar = cantidadRecuperar;
        }

        public override void Efectuar(Personaje personaje)
        {
            personaje.Vida += CantidadRecuperar;
            Console.WriteLine($"{personaje.Nombre} recuperó {CantidadRecuperar} de vida. Vida actual: {personaje.Vida}");
        }
    }
}
