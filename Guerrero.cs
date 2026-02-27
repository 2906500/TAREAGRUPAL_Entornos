using System;

namespace ProyectoRPG
{   
    /// <summary>
    /// Representa una clase especializada de personaje enfocada en el combate físico.
    /// Hereda de <see cref="Personaje"/>.
    /// </summary>
    public class Guerrero : Personaje
    {
        /// <summary>
        /// Determina la potencia de los ataques físicos del guerrero.
        /// </summary>
        public int fuerza;
        
        /// <summary>
        /// El nombre del arma equipada actualmente.
        /// </summary>
        public string arma;
        /// <summary>
        /// Inicializa un nuevo Guerrero con valores por defecto (Fuerza: 15, Arma: Espada).
        /// </summary>
        public Guerrero()
        {
            this.fuerza = 15;
            this.arma = "Espada";
        }
        /// <summary>
        /// Inicializa un nuevo Guerrero con un nombre específico, heredando la base de <see cref="Personaje"/>.
        /// </summary>
        /// <param name="nombre">El nombre asignado al guerrero.</param>
        public Guerrero(string nombre):base(nombre)
        {
            //this.nombre = nombre;
            this.fuerza = 15;
            this.arma = "Espada";
        }
        /// <summary>
        /// Realiza una habilidad especial que duplica el daño basado en la fuerza.
        /// </summary>
        public void AtaquePoderoso()
        {
            Console.WriteLine(Nombre + " usa su " + arma + " para realizar un ataque poderoso!");
            Console.WriteLine("Daño infligido: " + (fuerza * 2));
        }
        /// <summary>
        /// Ejecuta una acción defensiva para mitigar el daño entrante.
        /// </summary>
        public void DefenderseConEscudo()
        {
            Console.WriteLine(Nombre + " se defiende con su escudo, reduciendo el daño recibido.");
        }
    }
}
