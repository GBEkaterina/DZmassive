// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

static int SummaChisel(int num){
int result = 0;
while(num > 0)
{
    result += num % 10;
    num = num / 10;
}
    return result;
}


Console.WriteLine("Введите число  " );
int num = Convert.ToInt32(Console.ReadLine());
int result = SummaChisel(num);
Console.WriteLine(" Сумма цифр числа равна " + result);