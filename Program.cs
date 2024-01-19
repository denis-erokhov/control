/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Clear();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

string[] originalArray = new string[size];

Console.WriteLine("Введите строки массива:");
for (int i = 0; i < size; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    originalArray[i] = Console.ReadLine();
}

string[] newArray = FilterArray(originalArray);

Console.WriteLine("\nНовый массив из строк, длина которых меньше либо равна 3 символам:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}


static string[] FilterArray(string[] inputArray)
{
int count = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];

int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArray[index] = inputArray[i];
        index++;
    }
}

return newArray;
}

