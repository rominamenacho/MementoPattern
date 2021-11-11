using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
  public class Memento
    {
        private Juego juegoEstado;
        public Memento(Juego estado)
        {
            this.juegoEstado = estado;
        }

        public Juego JuegoEstado { get => juegoEstado; }
    }
}
