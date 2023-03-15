// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    int numArrayElem = InputCountElem("Enter the number of array elements: ");
    int[] myArray = FillArray(numArrayElem);
    int countElem = NumsGreaterThenZero(myArray);
    PrintArray(myArray);
    Console.WriteLine($" -> {countElem}");

}

int InputCountElem(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write(string.Join(", ", array));
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter the {i + 1}-th element of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int NumsGreaterThenZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;
}

Main();