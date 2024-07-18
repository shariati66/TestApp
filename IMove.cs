using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public interface IMove
    {
        void Move();
    }
    public interface ISwim : IMove
    {
        void Swim();
    }
    public interface IFly:IMove
    {
        void Fly();
    }
}
