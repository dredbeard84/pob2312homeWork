// Тема 10 (1)

// Заданаие: Написать программу, которая запрашивает у пользователя значение радиуса окружности и выводит на экран её длину и площадь, вычисленные с помощью методов класса Math.

Console.Write("Введите радиус окружности: ");
double R = double.Parse(Console.ReadLine());
double L = 2 * Math.PI * R;
Console.WriteLine($"Длина окружности = {L:F2}");
double S = Math.PI * R * R;
Console.WriteLine($"Площадь круга = {S:F2}");
