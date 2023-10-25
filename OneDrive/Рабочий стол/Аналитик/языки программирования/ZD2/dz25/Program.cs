// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// statik void EntNumbs(int a){
//  for(int i  = 0; i < length; i++)
// {
//    Console.WriteLine("Введите число A  " );
// }
   
void NumbStep(int num1, int num2){
  double result = 0;
  for(int i  = 0; i < 1; i++)
{ 
  if(num1 != 0 && num2 != 0)
 { result = Math.Pow(num1, num2);
  Console.WriteLine("Значение числа А в степени В равно  " + result);
  // double result1 = Convert.ToDouble(result);
  // Console.Write(result + " ");
 }

if(num1 == 0)
{
  Console.WriteLine("Внесите число А отличное от нуля ");
}
if(num2 == 0)
{
  Console.WriteLine("Внесите число В отличное от нуля ");
}
}
}
//  Console.Writeline("Значение числа А в степени В "+result);
Console.WriteLine("Введите число A  " );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B  " );
int num2 = Convert.ToInt32(Console.ReadLine());
NumbStep(num1, num2);



// double result = Math.Pow(num1, num2);
// Console.WriteLine("Значение числа А в степени В " + result);    