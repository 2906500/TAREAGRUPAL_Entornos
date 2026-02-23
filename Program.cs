using System;

namespace ProyectoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje pers = new Personaje();
            pers.Nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + pers.Nombre);
            pers.Atacar();
            pers.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guer = new Guerrero();
            guer.Nombre = "Guerrero Valiente";
            guer.Atacar();
            guer.AtaquePoderoso();
            guer.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker();
            bers.Nombre = "Destructor";
            bers.EntrarEnFuria();
            bers.EntrarEnFuria();
            bers.AtaqueFurioso();
            Console.WriteLine("\n" + bers.MostrarInfo());

            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.Nombre = "Merlín";
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigro = new Nigromante();
            nigro.Nombre = "Señor Oscuro";
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
