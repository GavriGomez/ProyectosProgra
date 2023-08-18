using System;

namespace NuevoProyecto18Ago
{
    public class PistaDeCarreras
    {
        public float longitud;
        public string nombre;


        public void Competir(Coche coche1, Coche coche2) //Mètodos de la clase
        {//Bloque que abrimos en llave que abre y la que cierra. Al ejecutar el metodo deben estar dentro del bloque

            Console.WriteLine("Iniciando competencia entre" + coche1.Modelo + "contra" + coche2.Modelo); //Concatenaciòn de objetos

            if (coche1.velocidad > coche2.velocidad)
            {
                Console.WriteLine("Ganò" + coche1.Modelo);
            }
           else if (coche1.velocidad <coche2.velocidad)
            {
                Console.WriteLine("Ganò" + coche2.Modelo);
            }
            else
            {
                Console.WriteLine("Hubo un empate");
            }
}
    }
}