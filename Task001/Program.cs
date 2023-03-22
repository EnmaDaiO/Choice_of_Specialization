// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры 
// ["hello", "2", "world",":-)"] -> ["2",":-)"]  \ В каждом элементе массива должно быть не более
//  3 символов



/// <summary>
/// Метод создания массива строк, элементы которого задаются через консоль
/// </summary>
/// <param name="size"> параметр отвечающий за размер массива\выделение памяти для массива</param>
/// <returns></returns>
string[] CreatArray(int size) 
{
    string[] result = new string[size];
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine($"Задайте {i+1}-ый элемент массива");
        result[i] = Convert.ToString(Console.ReadLine());;
    }
    return result; 
}

int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreatArray(size);
Console.WriteLine($"Массив из {size} строк: [{String.Join("; ", array)}]");