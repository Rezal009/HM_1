// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a; // Предполагаем, что первое число максимальное

if (b > max)
{
    max = b; // Если второе число больше, обновляем максимальное значение
}

if (c > max)
{
    max = c; // Если третье число больше, обновляем максимальное значение
}

Console.WriteLine("Максимальное число: " + max);
