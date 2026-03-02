using System;

namespace ProyectoRPG
{
    /// <summary>
    /// Representa al personaje Nigromante cuya mecanica principal esta basada en cosechar almas
    /// Hereda de <see cref="Mago"/>
    /// </summary>
    public class Nigromante : Mago
    {
        /// <summary>
        ///  Determina la candida de almas cosechadas
        /// </summary>
        public int almasCapturadas;
       /// <summary>
       /// Este personaje inicializa con estadisticas por defecto
       /// </summary>
        public Nigromante()
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            this.Mana = 120;
        }
        /// <summary>
        /// Inicializa el personaje Nigromante con un Nivel por defecto
        /// </summary>
        /// <param name="nivel"></param>
        public Nigromante(int nivel)
        {
            this.nivel = nivel;
        }
        /// <summary>
        /// Realiza la habilidad especial de nigromante el cual los castea gastando almas cosechadas
        /// </summary>
        public void InvocarNoMuerto()
        {
            if (Mana >= 40 && almasCapturadas >= 1)
            {
                Console.WriteLine(Nombre + " invoca un no-muerto usando un alma capturada!");
                Mana -= 40;
                almasCapturadas--;
                Console.WriteLine("Almas restantes: " + almasCapturadas);
            }
            else
            {
                Console.WriteLine("No hay suficiente mana o almas para invocar.");
            }
        }
        
        /// <summary>
        /// Ejecuta la accion pasiva del personaje el cual se basa de capturar almas y describir el total de almas cosechadas
        /// </summary>
        public void CapturarAlma()
        {
            almasCapturadas++;
            Console.WriteLine(Nombre + " ha capturado un alma. Total: " + almasCapturadas);
        }
        
        /// <summary>
        /// Ejecuta la habilidad especial del personaje de drenar vida del oponente
        /// </summary>
        public void DrenarVida()
        {
            if (Mana >= 25)
            {
                Console.WriteLine(Nombre + " drena la vida de su enemigo!");
                Mana -= 25;
                vida += 15;
                Console.WriteLine("Vida recuperada. Vida actual: " + vida);
            }
        }
    }
}
