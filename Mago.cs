using System;

namespace ProyectoRPG
{
    public class Mago : Personaje
    {
        //public int mana;
        public int Mana
        {
            get;
            set;
        }
        

        public string hechizo;

        public Mago()
        {
            
            this.Mana = 100;
            this.hechizo = "Bola de fuego";
        }

        public Mago(string nombre):base(nombre)
        {
            //this.nombre = nombre;
            this.Mana = 100;
            this.hechizo = "bola de fuego";
        }

        public void LanzarHechizo()
        {
            if (Mana >= 20)
            {
                Console.WriteLine(nombre + " lanza " + hechizo + "!");
                Mana -= 20;
                Console.WriteLine("Mana restante: " + Mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }

        public void Meditar()
        {
            Mana += 30;
            if (Mana > 100) Mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + Mana);
        }
    }
}
