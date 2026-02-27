using System;

namespace ProyectoRPG
{
    /// <summary>
    /// Representa la entidad base para los personajes del juego RPG.
    /// </summary>
    public class Personaje
    {   
        
        private string nombre;
        public int vida;
        public int nivel;
        
        /// <summary>
        /// Inicializa una nueva instancia de <see cref="Personaje"/> con valores predeterminados.
        /// </summary>
        public Personaje()
        {
            this.vida = 100;
            this.nivel = 1;
        }
        /// <summary>
        /// Inicializa un personaje asignándole un nombre específico.
        /// </summary>
        /// <param name="nombre">El nombre que recibirá el personaje.</param>
        public Personaje(string nombre)
        {
            this.nombre = nombre;
            this.vida = 100;
            this.nivel = 1;
        }
        /// <summary>
        /// Obtiene o establece el nombre del personaje.
        /// </summary>
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        /// <summary>
        /// Ejecuta la acción de ataque básico y lo muestra en consola.
        /// </summary>
        public void Atacar()
        {
            Console.WriteLine(Nombre + " realiza un ataque básico!");
        }
        /// <summary>
        /// Reduce la vida del personaje según el daño recibido.
        /// </summary>
        /// <param name="danio">Cantidad de puntos de vida a restar.</param>
        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(Nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }
        /// <summary>
        /// Incrementa el nivel del personaje y aumenta su vida máxima.
        /// </summary>
        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(Nombre + " ha subido al nivel " + nivel + "!");
        }
        /// <summary>
        /// Genera una cadena de texto con el estado actual del personaje.
        /// </summary>
        /// <returns>Un resumen detallado con Nombre, Clase, Nivel y Vida.</returns>
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
