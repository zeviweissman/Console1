using ConsoleApp1;

IMyList<Func<string, string>> myList = new MyList<Func<string, string>>();

Func<string, string> AddHello =
    (str) => $"{str} hello!";

Func<string, string> DuplicateString =
    (str) => $"{str} {str}";
Func<string, string> ToCapital =
    (str) => str.ToUpper() ;

Func<string, string> AddStringLength =
    (str) => $"{str}; Total string length {str.Length}";

myList.Push(AddHello);
myList.Push(DuplicateString);
myList.Push(ToCapital);
myList.Push(AddStringLength);


int TotalNumbers(int num)
{
    return num / 10 == 0
        ? 1 
        : TotalNumbers(num / 10) + 1;
}


int Fibo(int num) =>
        num <= 2
        ? 1
        : Fibo(num - 1) + Fibo(num - 2);



Func<int, int> fibo1 = null;
    fibo1 =
    (num) => num <= 1
    ? 1
    : fibo1(num - 1) + fibo1(num - 2);



//Func<int, int> fibo2 =
//    (num) => num <= 1
//    ? 1
//    : fibo2(num - 1) + fibo2(num - 2);



int Factorial(int num)
{
    return num == 1
        ? 1
        : num * Factorial(num - 1);

}

Predicate<int> isEven =
    (num) => num % 2 == 0;


Console.WriteLine(myList.Reduce("Zevi", (start, nextFunc) =>  nextFunc(start)));
