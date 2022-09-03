// Написать программу, которая из имеюущегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

string[] PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

Console.Write("Введите количество элементов массива:\t");
int elementCount = int.Parse(Console.ReadLine());
string[] myArray = new string[elementCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент №{i + 1}: ");
    myArray[i] = Console.ReadLine();
}
Console.Write("\nВведенный массив: ");
PrintArray(myArray);

Console.Write("\nНовый массив с элементами длиной меньше либо равный 3 символам: ");
int count = 0;
string[] newArray = new string[myArray.Length];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {
        newArray[i] = myArray[i];
        Console.Write(newArray[i] + " ");
        count++;
    }
}
if (count == 0)
    Console.WriteLine("Ошибка! Элементов длиной меньше 3 символов не обнаружено");
