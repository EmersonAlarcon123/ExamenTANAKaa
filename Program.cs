using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un jugador
            Jugador jugador = new Jugador("Tanaka", 100, 15, 50);

            // Crear una lista de poderes para el jugador
            Poder bolaDeFuego = new Poder("Bola de Fuego", 30, 20);
            Poder rayo = new Poder("Rayo", 40, 25);
            jugador.Poderes.Add(bolaDeFuego);
            jugador.Poderes.Add(rayo);

            // Crear enemigos
            EnemigoMelee enemigoMelee = new EnemigoMelee("Goblin", 80, 10);
            EnemigoRango enemigoRango = new EnemigoRango("Archer", 60, 12);

            // Crear ítems
            PocionVida pocionVida = new PocionVida(20);
            PocionMana pocionMana = new PocionMana(15);
            jugador.Inventario.Add(pocionVida);
            jugador.Inventario.Add(pocionMana);

            // Simular batalla
            Console.WriteLine("--- COMIENZA LA BATALLA ---");

            jugador.Atacar(enemigoMelee);
            jugador.UsarPoder(bolaDeFuego, enemigoMelee);

            enemigoRango.Atacar(jugador);
            jugador.UsarItem(pocionVida);

            jugador.UsarPoder(rayo, enemigoRango);
            jugador.UsarItem(pocionMana);

            Console.WriteLine("--- FIN DE LA BATALLA ---");
        }
    }
}

