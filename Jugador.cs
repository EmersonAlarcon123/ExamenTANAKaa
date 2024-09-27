using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    class Jugador : Personaje
    {
        public int Mana { get; set; }
        public List<Poder> Poderes { get; set; } = new List<Poder>();

        public Jugador(string nombre, int vida, int daño, int mana)
            : base(nombre, vida, daño)
        {
            Mana = mana;
        }

        // Método para usar un poder
        public void UsarPoder(Poder poder, Personaje objetivo)
        {
            if (Mana >= poder.CostoMana)
            {
                poder.Ejecutar(this, objetivo);
                Mana -= poder.CostoMana;
                Console.WriteLine($"{Nombre} usó el poder {poder.Nombre} en {objetivo.Nombre}. Mana restante: {Mana}");
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene suficiente mana para usar {poder.Nombre}");
            }
        }
    }
}
