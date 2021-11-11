using System;

namespace MementoPattern
{
   public class Juego
    {
        private string nombre;
        private int checkpoint;

        public Juego()
        {
        }

        public string Nombre { get;  set; }
        public int Checkpoint { get; set; }

        public void setCheckPoint(int v)
        {
            Checkpoint = v;
        }

        public override string ToString()
        {
            return "Juego [nombre=" + Nombre + " checkpoint=" + checkpoint + "]";
        }
    }
}