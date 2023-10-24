//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
//массив [10 21 14 93 23] => 2
int[]array = new int[10];
int len_arr = array.Length;
int col = 0;
for(int i=0; i < len_arr; i++)
{
    array[i]= new Random().Next(1, 101);
    Console.Write(array[i] + " ");
    if(array[i] >= 20 && array[i] < 91)
    {
    col++;
    }
    Console.WriteLine("");
    if (array[i] < 20 && array[i] > 90)
    {
    Console.Write("количество элементов в массиве от 20 до 90 не найдено ");
    i++;
    }
}
Console.WriteLine("количество элементов в массиве от 20 до 90  " + col);  
