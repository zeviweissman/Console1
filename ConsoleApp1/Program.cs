using ConsoleApp1;

IMyList<int> ints = new MyList<int>();

ints.Push(1);
ints.Pop(); 
ints.Unshift(1);
ints.Unshift(2);
ints.Shift();
ints.Push(6);
ints.Push(4);
ints.Push(6);
ints.Push(6);


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



//Func<int, int> Fibo1;
//    Fibo1 =
//    (num) => num <= 1
//    ? 1
//    : Fibo1(num - 1) + Fibo1(num - 2);

//Func<int, int> Fibo2 =
//    (num) => num <= 1
//    ? 1
//    : Fibo2(num - 1) + Fibo2(num - 2);




int Factorial(int num)
{
    return num == 1
        ? 1
        : num * Factorial(num - 1);

}





Console.WriteLine(TotalNumbers(1222));
