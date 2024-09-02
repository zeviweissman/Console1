using ConsoleApp1;
using System;


Func<string, string> AddHello =
    (str) => $"{str} hello!";

Func<string, string> DuplicateString =
    (str) => $"{str} {str}";
Func<string, string> ToCapital =
    (str) => str.ToUpper() ;

Func<string, string> AddStringLength =
    (str) => $"{str}; Total string length {str.Length}";




static R Pipe<R>(R init, params Func<R, R>[] fns) =>
    fns.Aggregate(init, (init, fn) => fn(init));


Console.WriteLine(Pipe("Zevi", AddHello, DuplicateString, ToCapital, AddStringLength));