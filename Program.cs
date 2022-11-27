
string[] GetArrayFromString(string stringArray)
{
    string[] array = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return array;
}

Console.Clear();
Console.WriteLine("Заполните массив через пробел: ");
string input = Console.ReadLine()!;
string[] array = GetArrayFromString(input);
Console.WriteLine(String.Join(", ", array));
