using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Shark : Animal, ISwim
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound of Shark.");
        }
        public void Swim()
        {
            Console.WriteLine("Shark Swim in Ocean");
        }
        public override void Eat()
        {
            Console.WriteLine("Shark Eat Fish");
        }
        public void Types()
        {
            Console.WriteLine("Test Method");
        }
    }
}
