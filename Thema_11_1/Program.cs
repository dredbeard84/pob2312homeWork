// Тема 11 (1)

/* Заданаие: Напишите программу, которая принимает на вход 10 целых чисел и выводит на экран:
	● сумму всех чисел;
	● количество чисел, больших 10;
	● количество чисел, меньших 10;
	● среднее арифметическое всех чисел;
	● максимальное и минимальное значения в списке.

Для решения второго пункта задачи используйте тернарный оператор. */

double sum = 0;
int i = 0;
int more10 = 0;
int less10 = 0;
int min;
int max;

Console.Write("Введите 1-е число: ");
int num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
min = num;
max = num;

Console.Write("Введите 2-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 3-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 4-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 5-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 6-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 7-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 8-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 9-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 10-е число: ");
num = int.Parse(Console.ReadLine());
sum += num;
i++;
more10 = (num > 10) ? ++more10 : more10;
if (num < 10) less10++;
else less10 = less10;
if (num < min) min = num;
if (num > max) max = num;

double avg = sum / i;

Console.WriteLine($"Сумма чисел: {sum}");
Console.WriteLine($"Среднее арифметическое: {avg}");
Console.WriteLine($"Чисел больше 10: {more10}");
Console.WriteLine($"Чисел меньше 10: {less10}");
Console.WriteLine($"Минимальное значение в списке: {min}");
Console.WriteLine($"Максимальное значение в списке: {max}");
