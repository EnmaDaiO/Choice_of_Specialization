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

System.Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

string[] array = CreatArray(size);
Console.WriteLine($"Массив строк количество элементов в котором равно {size} : [{String.Join("; ", array)}]");



/// <summary>
/// Метод проверки и создания массива : проверяет размер каждого элемента выбранного массива на соответствие заданному ограничению 
/// после чего выводит последовательность элементов прошедших проверку в виде нового массива.
/// </summary>
/// <param name="array"> массив элементы которого проверяются</param>
/// <param name="wordSize">Размер элемента необходимый для прохождения проверки.</param>
/// <returns></returns>
string[] FindWordCountLengthAndCreatArray(string[] array, int wordSize)
{
    string newArray = string.Empty;
    for(int i = 0; i < array.Length; i++ )
    {
        if(array[i].Length<= wordSize)
        {
            newArray = newArray + array[i]+ ";";
        }
        else
        {
            System.Console.WriteLine("В массиве нет элементов, размер которых меньше или равен 3");
            break;
        }
    }
    newArray = newArray.Trim();
    return newArray.Split(" ");
}
System.Console.WriteLine();

int wordSize = 3;
string[] newArrayCountLengthWord = FindWordCountLengthAndCreatArray(array,wordSize);
System.Console.WriteLine();

Console.WriteLine($"Массив строк количество элементов в котором равно {newArrayCountLengthWord.Length}, c размером элементов не больше {wordSize}: [{String.Join("; ", newArrayCountLengthWord)}]");