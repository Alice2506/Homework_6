// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// 1. создать массив с числами, введенными с клавиатуры
// 2. вывести его на экран
// 3. посчитать их
// 4. посчитать, сколько среди них больше 0

Console.WriteLine("Введите количество чисел массива: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}        
PrintArray(array);
Console.WriteLine();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = int.Parse(Console.ReadLine());
    }
}  
FillArray(array);
PrintArray(array);
Console.WriteLine();

int sumOfPositiveIndexes = 0;
int index = 0;
while (array[index] > 0)
{
    sumOfPositiveIndexes++;
    index++;
}
Console.WriteLine("Количество положительных чисел, введенных пользователем: " + sumOfPositiveIndexes);

