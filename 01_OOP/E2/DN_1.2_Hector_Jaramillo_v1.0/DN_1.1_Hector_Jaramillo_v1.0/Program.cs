using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace DN_1._1_Hector_Jaramillo_v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DN_1.2_Hector_Jaramillo_v1.0"; // For better presentation
            int remaining = 1;
            while (remaining < 11)
            {
                Console.WriteLine("Intentos realizados: " + remaining);
                Console.WriteLine("Escriba el vehiculo para reproducir su sonido!");

                string type = Console.ReadLine().ToLower();

                Auto auto = null;

                switch (type)
                {
                    case "automovil":
                        auto = new Automovil();
                        break;

                    case "camion":
                        auto = new Camion();
                        break;

                    case "tren":
                        auto = new Tren();
                        break;

                    default:
                        Console.WriteLine("EL vehiculo no ha sido encontrado!");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }

                if (auto != null)
                {
                    auto.SoundVehicle();
                    remaining++; // The count only incremet if the sound is playing
                    Console.Clear(); // For better presentation
                }
            }
        }
    }
}
