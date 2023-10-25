// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] Generatarray(){
    int[] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] array){
   for(int i = 0; i < array.Length; i++)
   {
    Console.Write(array[i] + " ");
   }
   Console.WriteLine(" ");
}

int[] new_array = Generatarray();
PrintArray(new_array);
int[] array2 = new_array;
Console.Write("[{0}]", string.Join(", ", array2));