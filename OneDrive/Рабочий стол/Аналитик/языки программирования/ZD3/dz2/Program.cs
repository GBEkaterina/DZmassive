//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

long Akermfunc(long a, long b)
{
    if(a==0) return (b+1);
    
    else if(b==0) return Akermfunc(a-1, 1);
    
    else return Akermfunc(a-1, Akermfunc(a, b-1));
    
    
}

Console.WriteLine("Введите число M  " );
long num1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число N  " );
long num2 = Convert.ToInt64(Console.ReadLine());
long AkkermanFunc = Akermfunc(num1, num2);
Console.WriteLine($"Результат вычесления функции Аккермана = {AkkermanFunc}");
