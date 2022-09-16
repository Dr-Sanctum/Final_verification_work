/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] Function(string[] mass)
{
    int countResult = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            countResult++;
        }
    }
    string[] resultArray = new string[countResult];
    for (int i = 0, x = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            resultArray[x] = mass[i];
            x++;
        }
    }
    return resultArray;
}

void VievStringArray(string[] mass)
{
    Console.WriteLine("Итоговый массив: ");
    if (mass.Length == 0)
    {
        Console.Write($"[{string.Empty}]");
    }
    else
    {
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write($"\"{mass[i]}\"");
        }
    }
}


    Console.Write("Введите количество строк в массиве ");
    int size = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите последовательно строки массива ");

    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку №{i}");
        array[i] = Console.ReadLine();
    }

    VievStringArray(Function(array));