using System;
using ProyectoRPG;
namespace CIFPCarlosIII.ED.UT04.Grupo2;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje personaje = new Personaje();
            personaje.Nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + personaje.Nombre);
            personaje.Atacar();
            personaje.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guerrero = new Guerrero();
            guerrero.Nombre = "Guerrero Valiente";
            guerrero.Atacar();
            guerrero.AtaquePoderoso();
            guerrero.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker(5);
            bers.Nombre = "Guts";
            bers.SubirNivel();
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
            Nigromante nigro = new Nigromante(4);
            nigro.Nombre = "Señor Oscuro";
            nigro.SubirNivel();
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }

