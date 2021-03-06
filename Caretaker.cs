using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();
        public void addMemento(Memento m)
        {
            mementos.Add(m);
        }

         public  Memento getMemento(int idx)
        {
            return mementos[idx];
        }
    }
}