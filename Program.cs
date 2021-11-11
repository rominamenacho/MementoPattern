using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreJuego = "Crash Bandicoot";
            Juego juego = new Juego();
              juego.Nombre = nombreJuego;
              juego.setCheckPoint(1);

            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.setCheckPoint(2);
            originator.EstadoJuego=juego;// aca guardo el estado en ese punto
            caretaker.addMemento(originator.guardar());//estado posicion 0

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.setCheckPoint(3);
            originator.EstadoJuego = juego;
            //aca para confirmar un punto en el tiempo, para ser recuperado luego
            caretaker.addMemento(originator.guardar());//estado posicion 1

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.setCheckPoint(4);
            originator.EstadoJuego = juego;
            caretaker.addMemento(originator.guardar());

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.setCheckPoint(5);
            originator.EstadoJuego = juego;
            originator.restaurar(caretaker.getMemento(0));

            juego = originator.EstadoJuego;

            Console.WriteLine("$ juego {0} estado {1}", juego.Nombre, juego.Checkpoint);
            Console.ReadKey();
        }
    }
}
