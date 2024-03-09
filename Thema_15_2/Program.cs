// Тема 15 (2)

/*  1. Создайте пустой числовой массив размером в 10 ячеек.
    2. Заполните его случайными числами используя класс Random и цикл For.
    3. С помощью следующего цикла for выведите на экран все числа массива.
    4. Составьте цикл, проверяющий количество чётных чисел.
    5. Выведите на экран количество чётных чисел массива. */

int[] mas = new int[10];                                                            // 1
Random random = new Random();                                                       // 2
for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(11);
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");                   // 3
Console.WriteLine();
int count = 0;                                                                      // 4
for (int i = 0; i < mas.Length; i++) if (mas[i] > 0 && mas[i] % 2 == 0) count++;
Console.Write($"Количество чётных чисел в массиве: {count}");                       // 5
Console.WriteLine();
