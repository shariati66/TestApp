using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public abstract class Animal:IMove,IEat
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal Eat Food");
        }

        public abstract void MakeSound();

        public void Move()
        {
            Console.WriteLine("Move On Animal Class");
        }
    }
}
