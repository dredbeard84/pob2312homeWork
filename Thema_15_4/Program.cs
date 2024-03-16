// Тема 15 (4)

/* Создать 4 массива.
   Заполнить их случайными числами.
   Конечным результатом должен быть, выведенный на консоль, массив, хранящий следующее:
   Произведение средних арифметических (1 и 2) и (3 и 4) массивов поиндексно. */

Random random = new Random();
int[] mas1 = new int[2];
int[] mas2 = new int[2];
int[] mas3 = new int[2];
int[] mas4 = new int[2];
double[] masSum1_2 = new double[2];
double[] masSum3_4 = new double[2];
double[] masTotal = new double[2];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10, 100);
    Console.Write($"{mas1[i]} ");// массив 1
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(10, 100);
    Console.Write($"{mas2[i]} ");// массив 2
}
Console.WriteLine();
for (int i = 0; i < masSum1_2.Length; i++)
{
    masSum1_2[i] = (mas1[i] + mas2[i]) / 2;
    Console.Write($"{masSum1_2[i]:F2} ");// среднее арифметическое массивов 1 и 2 поиндексно
}
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i] = random.Next(10, 100);
    Console.Write($"{mas3[i]} ");// массив 3
}
Console.WriteLine();
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = random.Next(10, 100);
    Console.Write($"{mas4[i]} ");// массив 4
}
Console.WriteLine();
for (int i = 0; i < masSum3_4.Length; i++)
{
    masSum3_4[i] = (mas3[i] + mas4[i]) / 2;
    Console.Write($"{masSum3_4[i]:F2} ");// среднее арифметическое массивов 3 и 4 поиндексно
}
Console.WriteLine();
for (int i = 0; i < masTotal.Length; i++)
{
    masTotal[i] = (masSum1_2[i] * masSum3_4[i]) / 2;
    Console.Write($"{masTotal[i]:F2} ");// произведение средних арифметических массивов
}
Console.WriteLine();
