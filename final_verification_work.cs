//! Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//! длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//! либо задать на старте Выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//! лучше обойтись исключительно массивами.
//!     Примеры:
//!     ["hello", "2", "world", ":-)"] => ["2", ":-)"] 
//!     ["1234", "1567", "-2", "computer science"] > ["-2"] 
//!     ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите массив строк через пробел");
string[] array = Console.ReadLine().Split();
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);


//? Более грубый вариант
// Console.WriteLine("Введите массив строк через пробел, напрмер ( hello 2 world :-) ): ");
// string[] arrayEnter = Console.ReadLine().Split();
// string[] arrayExit = new string[arrayEnter.Length];

// void SecondArray(string[] arrayEnter, string[] arrayExit)
// {
//     int count = 0;
//     for (int i = 0; i < arrayEnter.Length; i++)
//     {
//         if (arrayEnter[i].Length <= 3)
//         {
//             arrayExit[count] = arrayEnter[i];
//             count++;
//         }
//     }
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// SecondArray(arrayEnter, arrayExit);
// PrintArray(arrayExit);