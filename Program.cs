// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArrayFromString(string stringArray)
{
    string[] array = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return array;
}

string[] GetNewArray (string[] array)
{
    int count = 0;
    string[] temp = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            temp[count] = array[i];
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int j = 0; j < newArray.Length; j++)
    {
        newArray[j] = temp[j];
    }
    return newArray;
}

Console.Clear();
Console.WriteLine("Заполните массив через пробел: ");
string input = Console.ReadLine()!;
string[] array = GetArrayFromString(input);
Console.WriteLine(String.Join(", ", array));
string[] newArray = GetNewArray(array);
Console.WriteLine(String.Join(", ", newArray));
