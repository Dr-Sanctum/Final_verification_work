/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

void Function(string[] mass)
{
    int countResult = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            countResult++;
        }
    }

    if (countResult == 0)
    {
        Console.WriteLine("Итоговый массив пуст: ");
        Console.WriteLine($"[{string.Empty}]");
    }
    else
    {
        string[] resultArray = new string[countResult];
        for (int i = 0, x = 0; i < mass.Length; i++)
        {
            if (mass[i].Length <= 3)
            {
                resultArray[x] = mass[i];
                x++;
            }
        }
        Console.WriteLine("Итоговый массив: ");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write($"\"{resultArray[i]}\"");
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

Function(array);