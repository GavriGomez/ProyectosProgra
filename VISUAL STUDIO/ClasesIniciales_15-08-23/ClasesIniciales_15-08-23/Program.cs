using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesIniciales_15_08_23
    //actividad 18-Ago-23 clases de ñlas especificaciones de un celular
{
    class Program
    {
        static void Main(string[] args)
        {// aqui abre el cuerpo del metodo main
         // punto de inicio o de entrada al programa
         // para declarar una variable hay que seguir la forma: tipo, nombre o identificador y valor de inicializaciòn


            //Linea de declaracion e instanciacion

            SmartphoneXiaomi9AT NetworkTechnology = new SmartphoneXiaomi9AT();
            //acà me quedè en  la tarea kjaskja









          DispositivoMovil miIphone = new DispositivoMovil(); // Representa la declaraciòn de un objeto
            //Modificar las caracteristicas del objeto
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resolucionAncho = 1080;
            miIphone.resolucionAlto = 1920;
            miIphone.color = new Color();
            //Definir un valor numerico a cada color
            miIphone.color.rojo = 100;
            miIphone.color.azul = 210;
            miIphone.color.verde = 20;

            DispositivoMovil tabletSamsung =
                new DispositivoMovil();
            tabletSamsung.ram = 8;
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.resolucionAncho = 1080;
            tabletSamsung.resolucionAlto = 1920;
            tabletSamsung.color = new Color();
            tabletSamsung.color.rojo = 155;
            tabletSamsung.color.azul = 242;
            tabletSamsung.color.verde = 97;

            DispositivoMovil telefonoXiaomi =
                new DispositivoMovil();
            telefonoXiaomi.almacenamiento = 6;
            telefonoXiaomi.ram = 6;
            telefonoXiaomi.resolucionAlto = 1000;
            telefonoXiaomi.resolucionAncho = 3000;

            telefonoXiaomi.color = new Color();
            telefonoXiaomi.color.rojo = 78;
            telefonoXiaomi.color.azul = 45;
            telefonoXiaomi.color.verde = 133;




        }
    }
}
