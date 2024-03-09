// Тема 15 (3)

/* Напишите программу, которая запрашивает у пользователя 10 целых чисел и сохраняет их в массиве.
   Затем программа сортирует массив по возрастанию и выводит отсортированный массив на экран.
   Далее программа запрашивает у пользователя число и находит его индекс в массиве.
   Если число не найдено, программа выводит сообщение об ошибке. */

int[] mas = new int[10];
Console.WriteLine("Введите 10 целых чисел:");
for (int i = 0; i < mas.Length; i++) mas[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
Console.WriteLine();
Array.Sort(mas);
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();
Console.Write("Введите число для поиска его индекса в массиве: ");
int n = int.Parse(Console.ReadLine());
if (Array.IndexOf(mas, n) == -1) Console.WriteLine("Ошибка: такого числа нет");
else Console.WriteLine($"Индекс числа {n}: {Array.IndexOf(mas, n)}");
