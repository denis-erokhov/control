/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


Console.Clear();

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите любые {n} строк(-и) через Enter:");
string[] strArray = new string[n];

    for (int i = 0; i < strArray.Length; i++)
    {
        strArray[i] = Console.ReadLine()!;
    }
    Console.WriteLine($"Начальный массив: [{string.Join(" ", strArray)} ]");

    System.Console.Write("Конечный массив: [");

    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            Console.Write($"{strArray[i]} ");
        }
    }
    System.Console.WriteLine("]");
