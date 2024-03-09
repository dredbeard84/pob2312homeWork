// Тема 15 (3)

/*  Напишите программу, которая запрашивает у пользователя 10 целых чисел и сохраняет их в массиве.
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


//// Index / BinarySearch (поиск в массиве)
//Console.WriteLine(Array.IndexOf(mas3, 2));// поиск первого вхождения элемента "2" с начала массива
//Console.WriteLine(Array.LastIndexOf(mas3, 2));// поиск с конца
//Console.WriteLine(Array.LastIndexOf(mas3, 5));// 5 в массиве не существует, результат: -1 (= false)
//Console.WriteLine(Array.BinarySearch(mas3, 7));// 
//Console.WriteLine();
