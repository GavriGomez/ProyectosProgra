using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesIniciales_15_08_23
{
    class Program
    {
        public static object LonelyDay { get; private set; }
        public static object PokerFace { get; private set; }
        public static object PrettySavage { get; private set; }
        public static object LlamadoDeEmergencia { get; private set; }
        public static object Toxicity { get; private set; }
        public static object Paparazzi { get; private set; }
        public static object TheALbum { get; private set; }
        public static object DaddyYankeeMundial { get; private set; }
        public static object SystemOfADown { get; private set; }
        public static object LadyGaga { get; private set; }
        public static object BlackPink { get; private set; }
        public static object DaddyYankee { get; private set; }

        static void Main(string[] args)
        {// aqui abre el cuerpo del metodo main
         // punto de inicio o de entrada al programa
         // para declarar una variable hay que seguir la forma: tipo, nombre o identificador y valor de inicializaciòn
         //tipo         nombre        inicializacion
            cancion NuevaPlaylist = new cancion();
            NuevaPlaylist.Rock = LonelyDay;
            NuevaPlaylist.Pop = PokerFace;
            NuevaPlaylist.Kpop = PrettySavage;
            NuevaPlaylist.Reggaeton = LlamadoDeEmergencia;

            NuevaPlaylist = new Album();
            NuevaPlaylist.Rock = Toxicity;
            NuevaPlaylist.Pop = Paparazzi;
            NuevaPlaylist.Kpop = TheALbum;
            NuevaPlaylist.Reggaeton = DaddyYankeeMundial;

            NuevaPlaylist = new Artista();
            NuevaPlaylist.Rock = SystemOfADown;
            NuevaPlaylist.Pop = LadyGaga;
            NuevaPlaylist.Kpop = BlackPink;
            NuevaPlaylist.Reggaeton = DaddyYankee;

            // Representa la declaraciòn de un objeto
            //Modificar las caracteristicas del objeto




        }
    }
}
