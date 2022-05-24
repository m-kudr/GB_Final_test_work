// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

int maxNumSymbols = 3;
string[] inArray = { "hello", "2", "world", ":-)" };
//string[] inArray = {"1234", "1567", "-2", "computer science"};
//string[] inArray = {"Russia", "Denmark", "Kazan"};
int lenOutArray = 0;
foreach (var item in inArray)
{
    if (item.Length <= maxNumSymbols)
    {
        lenOutArray++;
    }
}
string[] outArray = new string[lenOutArray];

PrintArray(inArray);

int k = 0;
for (int i = 0; i < inArray.Length; i++)
{
    if (inArray[i].Length <= maxNumSymbols)
    {
        outArray[k++] = inArray[i];
    }
}

PrintArray(outArray);

void PrintArray(string[] Array)
{
    Console.Write("[");
    int arrayLength = Array.Length;
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"\"{Array[i]}\"");
        if (i < arrayLength - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}