using System;

namespace Cafeteria
{
    public interface IObserver
    { 
        public void Update (Subject s)  ;
    }
}