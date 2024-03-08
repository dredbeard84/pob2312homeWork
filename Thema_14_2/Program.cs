// Тема 14 (2)

/* Задание 1. Напишите программу, случайным образом генерирующую температуры от 1 до 100.
			  В случае превышения, устройство останавливает работу с выводом значения критической температуры на экран.
		      Алгоритм работы:
				● Создать экземпляр класса Random. (Random rnd = new Random();)
				● Инициализировать переменную temperature значением 0.
				● Запустить цикл, начиная с i = 1.
				● В теле цикла:
					a. Сгенерировать случайное число в диапазоне от 1 до 100 и сохранить его в переменную temperature.
					b. Вывести на экран текущую температуру.
					c. Проверить, превышает ли текущая температура критическую (больше 90).
					d. Если текущая температура превышает критическую, вывести сообщение об остановке устройства и прервать цикл. */

//Random random = new Random();
//double temperature = 0;
//for (int i = 1; ; i++)
//{
//    temperature = random.NextDouble() * 100;
//    Console.WriteLine($"Текущая температура: {temperature:F2}");
//    if (temperature > 90)
//    {
//        Console.Write("(критическая температура)");
//        break;
//    }
//}
//Console.WriteLine();


// Задание 2. Освоить перебор вложенными циклами, переписать код из второго файла и описать алгоритм работы (что за чем идёт).

Console.Write("Укажите количество квадратов: ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите сторону квадрата: ");
int weigth = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < quantity; i++)
{
    for (int j = 0; j < weigth; j++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
    Console.WriteLine();
    for (int k = 0; k < weigth - 2; k++)
    {
        Console.Write("*");
        for (int l = 0; l < weigth + weigth - 2; l++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    for (int m = 0; m < weigth; m++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
    Console.WriteLine();
}
