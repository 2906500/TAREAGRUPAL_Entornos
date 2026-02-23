using System;

namespace ProyectoRPG
{
    public class Personaje
    {
        private string nombre;
        public int vida;
        public int nivel;

        public Personaje()
        {
            this.vida = 100;
            this.nivel = 1;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public void Atacar()
        {
            Console.WriteLine(Nombre + " realiza un ataque básico!");
        }

        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(Nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }

        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(Nombre + " ha subido al nivel " + nivel + "!");
        }
        
        public string MostrarInfo()
        {
            return "=== INFORMACIÓN DEL PERSONAJE ===" +
                   "\nNombre: " + Nombre +
                   "\nClase: " + this.GetType().Name +
                   "\nNivel: " + nivel +
                   "\nVida: " + vida;
        }
    }
}
