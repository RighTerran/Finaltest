
Console.Write("Введите количество элементов массива:\t");
int elementCount = int.Parse(Console.ReadLine());
string[] myArray = new string[elementCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент №{i + 1}: ");
    myArray[i] = Console.ReadLine();
}
Console.Write("\nМассив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}
Console.WriteLine("\nМассив с элементами длиной меньше 3 символов: ");
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {
        Console.Write(myArray[i] + " ");
        count++;
    }
}
if (count == 0)
    Console.WriteLine("Ошибка");