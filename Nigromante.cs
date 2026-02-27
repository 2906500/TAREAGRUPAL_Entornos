using System;

namespace ProyectoRPG
{
    public class Nigromante : Mago
    {
        public int almasCapturadas;

        public Nigromante()
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            this.Mana = 120;
        }

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

        public void CapturarAlma()
        {
            almasCapturadas++;
            Console.WriteLine(Nombre + " ha capturado un alma. Total: " + almasCapturadas);
        }

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
