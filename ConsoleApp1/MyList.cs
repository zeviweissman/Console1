using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyList<T> : IMyList<T>
    {
        static Exception IndexOutOfRangeException = new("Index Out Of Range");
        public int Count => _list.Length;

        T[] _list = [];

        public T Get(int index)
        {
            try
            {
                return _list[index];
            }
            catch
            {
                throw IndexOutOfRangeException;
            }
        }

        public T? Pop()
        {
            try
            {
                T returnValue = _list[_list.Length - 1];
                _list = _list[0..(_list.Length - 1)];
                return returnValue;
            }
            catch
            {
                throw new Exception("Cann'ot pop from an empty list");
            }

        }

        public void Push(T value)
        {
            _list = [.. _list, value];
        }

        public T? Shift()
        {
            try
            {
                T returnValue = _list[0];
                _list = _list[1..];
                return returnValue;
            }
            catch
            {
                throw new Exception("Cann'ot shift an empty list");
            }
        }

        public void Unshift(T value)
        {
            _list = [value, .. _list];
        }

        public override string ToString()
            =>  $"[{MyJoin(", ")}]";


        

        public R Reduce<R>(R initialValue, Func<R, T, R> reducer, int index = 0) =>
         index >= _list.Length
        ? initialValue
        : Reduce(reducer(initialValue, _list[index]), reducer, index + 1);
        
       



        public string MyJoin(string sperator="")
        => Reduce(string.Empty, (start, next)
                => start == string.Empty 
            ? $"{next.ToString()}"
            : $"{start}{sperator}{next.ToString()}"
        );
        

        
    }
}
