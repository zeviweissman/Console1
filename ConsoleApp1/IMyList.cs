using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMyList<T>
    {
        int Count { get; }
        void Push (T value);
        T? Pop ();
        void Unshift(T value);
        T? Shift();
        T Get(int index);
        string MyJoin(string seprator="");
        R Reduce<R>(R intialValue, Func<R,T,R> reducer, int indexCounter=0);
    }
}
