using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto18Ago
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche ferrari = new Coche();
            ferrari.Modelo = "Ferrari F1";
            ferrari.velocidad = 120;

            Coche mclaren = new Coche();
            mclaren.Modelo = "MC 2443";
            mclaren.velocidad = 140;

            PistaDeCarreras pista1= new PistaDeCarreras();
            pista1.nombre = "Hermanos Rodriguez";
            pista1.longitud = 4.303f; //KM

            pista1.Competir(ferrari, mclaren);

            //Esta linea espera a que presiones Enter para continuar
            Console.ReadLine(); 



        }
    }
}
