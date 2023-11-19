// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

int[] GenerateArray(int arrayLength)
    {
        int[] array = new int[arrayLength];
        Console.WriteLine("Введите числа через запятую: ");
        string input = Console.ReadLine();
        string[] arrayNumbers = input.Split(",");
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = Convert.ToInt32(arrayNumbers[i]);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();
    }

    void ReverseArray(int[] array, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            
            int temp = array[startIndex];
            array[startIndex] = array[endIndex];
            array[endIndex] = temp;
            ReverseArray(array, startIndex + 1, endIndex - 1);
        }
    }

    
    
    Console.Write("Введите длину массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = GenerateArray(n);

    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    Console.WriteLine("Массив в обратном порядке:");
    ReverseArray(array, 0, n - 1);
    PrintArray(array);               
        