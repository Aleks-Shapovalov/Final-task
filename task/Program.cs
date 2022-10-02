// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] arrString1 = new string[] { "Hello", "2", "world", ":-)" };
string[] arrString2 = new string[arrString1.Length];
int MaxLength = 3;

void SecondArray(string[] arrString1, string[] arrString2)
{
    int count = 0;
    for (int i = 0; i < arrString1.Length; i++)
    {
        if (arrString1[i].Length <= MaxLength)
        {
            arrString2[count] = arrString1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrString1, arrString2);
Console.WriteLine("Заданный массив:");
PrintArray(arrString1);
Console.WriteLine("Искомыe элементы массива:");
PrintArray(arrString2);