using System;

namespace MementoPattern
{
    internal class Originator
    {
        private Juego estadoJuego;

        public Juego EstadoJuego { get => estadoJuego; set => estadoJuego = value; }

        public Memento guardar()
        {
            return new Memento(estadoJuego);
        }

       
        internal void restaurar(Memento m)
        {
            estadoJuego = m.JuegoEstado;
        }

      
    }
}