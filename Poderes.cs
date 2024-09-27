using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    internal class Poder
    {
            public string Nombre { get; set; }
            public int Daño { get; set; }
            public int CostoMana { get; set; }

            public Poder(string nombre, int daño, int costoMana)
            {
                Nombre = nombre;
                Daño = daño;
                CostoMana = costoMana;
            }

            public void Ejecutar(Jugador jugador, Personaje objetivo)
            {
                objetivo.Vida -= Daño;
                Console.WriteLine($"{jugador.Nombre} infligió {Daño} de daño a {objetivo.Nombre} usando {Nombre}. Vida restante de {objetivo.Nombre}: {objetivo.Vida}");
            }
        

    }
}
