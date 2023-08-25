using System;

namespace NuevoProyecto18Ago
{
   public class Coche
    {
        //Declaraciòn de atributos

        //Visibilidad--- tipo de variable---identificador
        //Public           float           gasolina
        public string Modelo;
        public Color color;
        public float velocidad;
        public float gasolina;

        //Declaraciòn de mètodos

        //visibilidad-- ---tipo-----   identificador-----paràmetros() opcionales
        //no tiene ;
           
        public void Arrancar()                                                                                    //no tiene paràmetros entonces no se agrega nada
        {
            if (gasolina > 0)                                                                                     //El coche sì tiene gas
        {

            gasolina = gasolina - 0.1f;                                                                           //al atributo gasolina le asigno lo que ya tiene gasolina menos el 0.1 flotante
            Console.WriteLine(" Arrancando " + Modelo + ", le queda " + gasolina + "l de gas. ");
                 

        }
        else //No tiene gas
        {
                Console.WriteLine(Modelo + "no tiene gas. No se puede arrancar. :C ");
        }
}

        public void PonerGasolina(float cantidad)
         {
            gasolina = gasolina + cantidad;
       Console.WriteLine( "Se puso gas a " + Modelo + ". Ahora tiene " + gasolina + " L ");
        

    }
        
        public void Acelerar(float cantidad)
        {
            velocidad = velocidad + cantidad;
            Console.WriteLine(" Se aumentò la velocidad de " + Modelo + ". Ahora tiene " + velocidad + " de Velocidad ");

            if (gasolina > 0)
            {
                gasolina = gasolina - cantidad * 1/10f;
            }
                else
            {
                gasolina = 0;
                Console.WriteLine( Modelo + " Se quedò sin gasolina ");

            }
        }

        public void Frenar(float cantidad)
        {
            velocidad = velocidad - cantidad;
            Console.WriteLine(Modelo + " Se detuvo antes "  + ". Ahora Tiene " + velocidad + " de velocidad ");
            
        }

    }  //Acaba el mètodo
}






