using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Eagle : Animal,IFly
    {
        public void Fly()
        {
            Console.WriteLine("Eagle fly on the sky.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Sound of Eagle");
        }
        public new void Eat()
        {
            Console.WriteLine("Eagle Eat Meat");
        }
    }
}
