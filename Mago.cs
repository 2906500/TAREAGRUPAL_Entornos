using System;

namespace ProyectoRPG
{
    /// <summary>
    ///  clase se encarga de gestionar la clase del mago que viene heredada de personaje
    /// </summary>
    public class Mago : Personaje
    {
        /// <summary>
        /// Este atributo se encarga del control del mana esta encapsulado
        /// </summary>
        private int mana;
        /// <summary>
        /// Propiedad para obtener o establecer el mana
        /// </summary>
        public int Mana
        {
            get => mana;
            set => mana = value;
        }
        
        /// <summary>
        /// Almacena el nombre del hechizo
        /// </summary>
        public string hechizo;
        /// <summary>
        /// Constructor de mago que se inicializa con valores por defecto
        /// </summary>
        public Mago()
        {
            
            this.Mana = 100;
            this.hechizo = "Bola de fuego";
        }
        /// <summary>
        /// Constructor que inicializa al mago con un nombre especifico llamndo al constructor base
        /// </summary>
        /// <param name="nombre"></param>
        public Mago(string nombre):base(nombre)
        {
            //this.nombre = nombre;
            this.Mana = 100;
            this.hechizo = "bola de fuego";
        }
        
        /// <summary>
        /// Realiza el lanzamiento de un hechizo si se dispone de mana suficiente
        /// </summary>
        public void LanzarHechizo()
        {
            if (Mana >= 20)
            {
                Console.WriteLine(Nombre + " lanza " + hechizo + "!");
                Mana -= 20;
                Console.WriteLine("Mana restante: " + Mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }
        /// <summary>
        /// Incrementa los puntos de mana del mago mediante meditacion, con limite de 100
        /// </summary>
        public void Meditar()
        {
            Mana += 30;
            if (Mana > 100) Mana = 100;
            Console.WriteLine(Nombre + " medita y recupera mana. Mana actual: " + Mana);
        }
    }
}
