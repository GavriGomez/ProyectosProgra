/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System;  //Identacion 0, Inicio de asignacion de ubicacion

namespace ClasesYMetodosAnidados  //Identacion 0, Inicio de asignacion de nombre del espacio de trabajo
{//Identacion: 0, Inicio de bloque de namespace ClasesYMetodosAnidados
	class Program //Identacion: 1, Inicio de clase de namespace Program
	{
		static void Main(string[] args)  //Identacion:2, Inicio de bloque del Metodo de  Main
		{
			ClaseA objetoA = new ClaseA();//Identacion: 3,  Asignacion de objeto a una clase
			ClaseB objetoB = new ClaseB(); //Identacion: 3, Asignacion de objeto a una clase

			objetoA.Metodo1();            //Identacion:3,  Asignacion de objeto a metodo 
			objetoA.Metodo2();            //Identacion: 3,  Asignacion de objeto a metodo 

			objetoB.Metodo1();           //Identacion: 3,  Asignacion de objeto a metodo 
			objetoB.Metodo2();           //Identacion: 3,   Asignacion de objeto a metodo 
										 // Identacion: 3, Fin de Bloque de Metodo de Main
		}  //Identacion 2, Fin de bloque del Metodo Main
	}   //Identacion 1, Fin del bloque de clase de namespace Program

	class ClaseA  //Identaciòn: 1, Inicio de clase de ClaseA
	{  //Identacion 1
		public void Metodo1()  //Identacion: 2, Inicio de bloque de Mètodo de Metodo1
		{  //Identacion: 2
			for (int i = 0; i < 3; i++)       //Identaciòn: 3, Inicio de bloque del ciclo for 
			{          //Identacion 3
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);   //Identacion:4, Inicio de Interacciòn con la consola

				for (int j = 0; j < 2; j++)      //Identaciòn: 4, Inicio de continuaciòn del bloque de ciclo for
				{        //Identacion 3
					Console.WriteLine("Ciclo anidado - Iteración: " + j);  //Identaciòn:5, Continuacion de interaccion con la consola
				}  //Identacion: 4, Fin de continuacion del bloque del ciclo for
			}//Identacion: 3, Fin de bloque del ciclo for
		}//Identacion: 2, Fin de Mètodo de Mètodo1

		public void Metodo2()  //Identacion: 2, Inicio del bloque de Metodo de Metodo2 
		{   //Identacion 2
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)  //Identaciòn: 3, Inicio de bloque del ciclo if
			{
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA");                                  //Identacion: 4, Inicio de Interacion con la consola dentro del ciclo
			}                                                                                                 //Identacion: 3, Fin de bloque del ciclo if
			else                                                                                             //Identacion: 3, Inicio del bloque del ciclo else
			{ 
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");                //Identacion: 4, Continuacion de Interaccion en la consola
			}//Identacion: 3, Fin del bloque del ciclo else
		}//Identacion: 2, Fin del bloque del Metodo de Metodo2
	}//Identacion: 1, Fin de bloque de ClasesYMetodosAnidados
	 
	class ClaseB                               //Identacion: 1, Inicio de clase ClaseB
	{//Identacion 1
		public void Metodo1()       //Identacion: 2, Inicio del metodo de Metodo1
		{
			for (int i = 5; i > 0; i--) // Identacion: 3, Inicio del ciclo for
			{
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i); //Identaciòn 4, Inicio de interaccion con la consola

				for (int j = 0; j < i; j++)                 //Identacion: 4, Continuaciòn de ciclo for
				{ 
					Console.WriteLine("Ciclo anidado - Iteración: " + j);  //Identacion 5, Continuacion de interaccion con la consola
				}     // Identacion 4, Fin de continuacion de ciclo for
			}      //Identacion 3, Fin de ciclo for
		}  //Identacion 2, Fin del Metodo de Metodo1

		public void Metodo2()   //Identacion 2, Inicio del metodo Metodo2
		{ //Identacion 2
			int numero = 10;    //Identacion 3, Definicion de tipo de dato y asignacion de valor 

			if (numero % 2 == 0) //Identacion 3, Inicio de ciclo if
			{
				Console.WriteLine("El número es par en Método 2 de ClaseB"); //Identacion 4, Inicio de interaccion con la consola
			}
			else //Identacion 3, inicio de bloque de ciclo else
			{  //Identacion 3
				Console.WriteLine("El número es impar en Método 2 de ClaseB");  //Identacion 4, Inicio de interaccion con la consola
			}  //identacion 3, Fin de bloque de ciclo else
		}    //Identacion 2, Fin del metodo de Metodo2
	}   //Identacion 1, Fin de bloque de clase de ClaseB
}//Identacion: 0, Fin de bloque de namespace ClasesYMetodosAnidados