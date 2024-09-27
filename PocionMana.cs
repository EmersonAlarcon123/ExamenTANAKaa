using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    internal class PocionMana : Item
    {
        public int CantidadRecuperar { get; set; }

        public PocionMana(int cantidadRecuperar)
            : base("Poción de Maná")
        {
            CantidadRecuperar = cantidadRecuperar;
        }

        public override void Efectuar(Personaje personaje)
        {
            if (personaje is Jugador jugador)
            {
                jugador.Mana += CantidadRecuperar;
                Console.WriteLine($"{jugador.Nombre} recuperó {CantidadRecuperar} de mana. Maná actual: {jugador.Mana}");
            }
        }
    }
}
