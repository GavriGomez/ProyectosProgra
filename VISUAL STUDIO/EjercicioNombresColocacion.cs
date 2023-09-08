/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;  //Declaracion de atributo Edad dentro de clase Elefante
        public float Peso;  //Declaracion de atributo "peso" dentro de clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)   
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir()  //Declaraciòn de mètodo de nombre Rugir dentro de clase Elefante
        {
            int distanciaEscuchante = 100;  //variable local de nombre distanciaEscuchante dentro de mètodo Rugir
            Console.WriteLine($"{Nombre} está rugiendo."); //No comment
        }

        public void Dormir(int horas)// Declaraciòn de mètodo Dormir dentro de clase Elefante  
                                     //Declaracion de paràmetro horas dentro del metodo Dormir
        {
            if(horas > 10)  //Bloque condicional If dentro de mètodo Dormir
            {
                float energiaGanada = 15;  //Variable local de nombre energiaGanada dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");  //No comment
        }
    }

    class Zapatero      //Declaracion de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre;  //Declaracion de atributo Nombre dentro de clase Zapatero 
        public string Especialidad; //Declaracion de atributo Especialidad dentro de clase Zapatero
        public int AñosExperiencia;  //Declaracion de atributo AñosExperiencia dentro de clase Zapatero

        public void RepararZapatos(string tipo, int cantidad)    //Declaraciòn del metodo RepararZapatos dentro de la clase zapatero
                                                                // Declaracion del paràmetro tipo dentro del mètodo RepararZapatos
                                                                //Declaracion del paràmetro cantidad dentro del metodo RepararZapatos
        {
            int precio = 50;    //Variable local de nombre precio dentro del mètodo RepararZapatos
            if (tipo == "tenis")   //Bloque condicional if dentro del mètodo RepararZapatos
            {
                precio = 100;  //Uso de la variable local precio dentro del bloque condicional if 
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}"); //No comment
        }

        public void CrearZapato(string estilo, string material)  //Declaracion del mètodo CrearZapatos dentro de la clase zapatero
        {
            for(int i = 0; i < 100; i++)         //Ciclo for dentro del mètodo CrearZapatos
            {
                if(estilo == "industrial")    //Bloque condicional if dentro del ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");// no comment
                }
                else             //Bloque condicional else dentro del ciclo for
                {
                    Console.WriteLine("Golpeando normal");  //No comment

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");  //No comment
        }

        public void MedirPie(int numeroPie)  //Declaracion de un Mètodo de nombre MedirPie dentro de la clase zapatero
                                            //Declaracion del paràmetro numeroPie dentro del mètodo MedirPie
        {
            string cliente;         //Variable local de nombre cliente dentro del mètodo MedirPie
            if (numeroPie > 20)     //Bloque condicional if dentro del mètodo MedirPie
            {
                cliente = "Adulto";  //Uso de la Variable local cliente dentro del bloque condicional if
            }
            else        //Bloque condicional else
            {
                cliente = "Niño";   //Uso de la variable local cliente dentro del bloque condicional else
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");  //No comment
        } 
    }

    class Television        //Declaracion de clase Television dentro de namespace Ejemplos
    {
        public string Marca;  //Declaracion del atributo Marca dentro de la clase Television
        public int Pulgadas;  //Declaracion del atributo Pulgadas dentro de la clase Television
        public bool Encendida;//Declaracion del atributo Encendida dentro de la clase Television

        public void Encender()  //DEclaracion del mètodo Encender dentro de la clase Television
        {
            Encendida = true;    //Uso de la variable true dentro del metodo Encender
            float consumoLuz = 0.05f;   // Variable local de nombre consumoLuz dentro del metodo Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");  //no comment
        }

        public void CambiarCanal(int canal)  //Declaracion del metodo CambiarCanal dentro de la clase Television 
                                              //Declaracion del parametro canal dentro del Metodo CambiarCanal
        {                      
            for(int i = 1; i < canal; i++)   //Ciclo for dentro del metodo CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");  //No comment
            }            
        }

        public void AjustarVolumen(int nivel)  //Declaracion del metodo AjustarVolumen dentro de la clase Television
                                               //Declaracion del parametro nivel dentro del mètodo AjustarVolumen
        {
            if (nivel > 100)    //Bloque condicional if dentro del metodo AjustarVolumen
            {
                nivel = 0;     //Uso del condicional if dentro del metodo AjustarVolumen
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra  //Declaracion de clase Guitarra dentro del namespace de nombre Ejemplos
    {
        public string Marca;  //Declaracion del atributo Marca dentro de la clase Guitarra
        public string Tipo;  //Declaracion del atributo Tipo dentro de la clase Guitarra
        public int Cuerdas;  //Declaracion del atributo Cuerdas dentro de la clase Guitarra

        public void TocarCuerda(int numeroCuerda)  //DEclaracion del mètodo TocarCuerda dentro de la clase Guitarra
                                                   //Declaracion del parametro numeroCuerda dentro del metodo TocarCuerda
        {
            if(numeroCuerda == 6)  //Bloque condicional if dentro del metodo TocarCuerda
            {
                string nota = "Mi";  //Variable local nota dentro del bloque condicional if
            }
            else if (numeroCuerda == 5)  //Bloque condicional ifdentro del metodo TocarCuerda
            {
                string nota = "La";   //Variable local nota dentro del bloque condicional if
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");  //No comment
        }

        public void AfinarGuitarra(bool afinada)  //DEclaracion del mètodo AfinarGuitarra dentro de la clase Guitarra
                                                 //Declaracion del parametro afinada dentro del metodo AfinarGuitarra
        { 
            if (afinada)    //Bloque condicional if dentro del metodo AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");  //No comment
            }
            else    //Bloque condicional else dentro del metodo AfinarGuitarra
            {
                for(int i = 0; i < 5; i++)  //Ciclo for dentro del bloque condicional if
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");  //No comment
                }                
            }
        }

        public void CambiarTipo(string nuevoTipo)  //Declaracion de metodo CambiarTipo dentro de la clase Guitarra
                                                   //Declaracion de paràmetro dentro del mètodo CambiarTipo
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
