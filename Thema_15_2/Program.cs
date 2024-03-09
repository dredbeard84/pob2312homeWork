// Тема 15 (2)

/*  1. Создайте пустой числовой массив размером в 10 ячеек.
    2. Заполните его случайными числами используя класс Random и цикл For.
    3. С помощью следующего цикла for выведите на экран все числа массива.
    4. Составьте цикл, проверяющий количество чётных чисел.
    5. Выведите на экран количество чётных чисел массива. */

// 1
int[] mas = new int[10];

// 2
Random random = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(11);

// 3
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
Console.WriteLine();

// 4
int count = 0;
for (int i = 0; i < mas.Length; i++) if (mas[i] > 0 && mas[i] % 2 == 0) count++;

// 5
Console.Write($"Количество чётных чисел в массиве: {count}");
Console.WriteLine();
