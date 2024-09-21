using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTANAKA
{
    internal class Personaje
    {
        
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Daño { get; set; }
        public List<Item> Inventario { get; set; } = new List<Item>();

        public Personaje(string nombre, int vida, int daño)
        {
            Nombre = nombre;
            Vida = vida;
            Daño = daño;
        }

       
        public virtual void Atacar(Personaje objetivo)
        {
            objetivo.Vida -= Daño;
            Console.WriteLine($"{Nombre} atacó a {objetivo.Nombre} e hizo {Daño} de daño. Vida restante de {objetivo.Nombre}: {objetivo.Vida}");
        }

     
        public void UsarItem(Item item)
        {
            item.Efectuar(this);
            Inventario.Remove(item);
            Console.WriteLine($"{Nombre} usó el item {item.Nombre}");
        }
    }
}

