// Написать программу, которая из имеюущегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
Console.Write("Введите количество элементов массива:\t");
int elementCount = int.Parse(Console.ReadLine());
string[] myArray = new string[elementCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент №{i + 1}: ");
    myArray[i] = Console.ReadLine();
}
Console.Write("\nМассив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}
Console.WriteLine("\nМассив с элементами длиной меньше 3 символов: ");
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
