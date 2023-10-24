//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
//массив [2.2 0.4 9.11 7.2 78.98] => 78.58
//массив [1.22 4.5 3.33] => 3.28
Console.WriteLine("Введите длину массива ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
for(int i = 0; i < num; i++)
{
    array[i] = new Random().NextDouble()*10;
    string result = string.Format("{0:f2}", array[i]);
    Console.Write(result + " ");
}
double min = array[0];
double max = array[0];
double sum = 0;
for(int i = 0; i < num; i++)
{
    
    if(array[i] <= min)
    {
        min = array[i];
    }
    if(array[i] >= max)
    {
        max = array[i];
    } 
} 
sum = max-min;
Console.WriteLine();
string result2 = string.Format("{0:f2}", sum);
Console.WriteLine("Разность равна: " + result2);