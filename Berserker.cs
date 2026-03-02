using System;

namespace ProyectoRPG
{
    /// <summary>
    ///Clase Berserker que hereda de la clase Guerrero
    /// </summary>
    public class Berserker : Guerrero
    {
        public int furia;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Berserker()
        {
            this.furia = 0;
            this.arma = "Hacha de batalla";
            this.fuerza = 20;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nivel"></param>
		public Berserker(int nivel)
		{
			this.nivel = nivel;
		}
        /// <summary>
        /// Cambio de estado del personaje
        /// </summary>
        public void EntrarEnFuria()
        {
            furia += 30;
            Console.WriteLine(Nombre + " entra en estado de furia! Furia actual: " + furia);
        }
        /// <summary>
        /// Ataque furioso del Berserker
        /// </summary>
        public void AtaqueFurioso()
        {
            if (furia >= 50)
            {
                Console.WriteLine(Nombre + " desata un ataque furioso devastador!");
                Console.WriteLine("Daño masivo: " + (fuerza * 3 + furia));
                furia = 0;
            }
            else
            {
                Console.WriteLine("Furia insuficiente para realizar ataque furioso.");
            }
        }
        /// <summary>
        /// Muestra información del personaje
        /// </summary>
        /// <returns> Nombre, Clase, Nivel, Vida, Fuerza, Arma, Furia </returns>
        public string MostrarInfo()
        {
            return "=== INFORMACIÓN DEL PERSONAJE ===" +
                   "\nNombre: " + Nombre +
                   "\nClase: " + this.GetType().Name +
                   "\nNivel: " + nivel +
                   "\nVida: " + vida +
                   "\nFuerza: " + fuerza +
                   "\nArma: " + arma +
                   "\nFuria: " + furia;
        }
    }
}
