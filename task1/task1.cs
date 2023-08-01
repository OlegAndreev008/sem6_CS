// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел вы хотите ввести: ");
int count = Convert.ToInt32(Console.ReadLine());
int SearchPlus(int count) //метод принимает и возвращает число
{
    int plus = 0; 
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число номер {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            plus += 1; //считает колво полож. значений
        }
    }
    Console.Write($"Количество положительно введенных значений равно {plus}");
    return plus;
}
SearchPlus(count);
// int[] Create(int count)   создание массива из колва элементов, которое задаст польз.
// {
//     int[] newArray = new int[count]; 
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"Введите число номер {i + 1}: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         newArray[i] = number;
//     }
//     return newArray;
// }

// void Print(int[] array)      вывод массива на экран
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] newMass = Create(count);
// Print(newMass);