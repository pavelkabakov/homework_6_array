// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел - ");
int quantityNumbers = int.Parse(Console.ReadLine()); // задаем длинну массива
int[] array = new int[quantityNumbers];
 
ManualFillArray(array);
PrintArray (array);
int max = 0;
Console.WriteLine($"Число цифр в массиве больше {max} = {CalculateMax(array, max)}");

int[] ManualFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число №{i+1} - ");
        int quantityNumbers = int.Parse(Console.ReadLine());
        array[i]= quantityNumbers;
    }
return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив чисел [{string.Join(", ", array)}]");
}

int CalculateMax(int[] array, int max)
{
    int sumMax = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            sumMax+=1;
        }
    }

    return sumMax;
}