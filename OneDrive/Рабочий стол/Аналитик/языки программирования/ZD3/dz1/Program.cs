// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.
void NumberLine(int a, int b)
{
      
      if(a<=0 || b<=0)
        {
            Console.WriteLine("Проверьте числа! Введите натуральные числа M и N!");
        }
        else if (a == b)
        {
            Console.Write($"{a} ");
        }
        else if (a < b)
        {
            Console.Write($"{a} ");
            NumberLine(a + 1, b);
        }
        else if (a > b)
        {
            Console.Write($"{a} ");
            NumberLine(a - 1, b);
        }
        
}

Console.WriteLine("Введите число M  " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N  " );
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1}, {num2}");
Console.WriteLine($"Натуральные числа в промежутке от {num1} до {num2}:");
NumberLine(num1, num2);




