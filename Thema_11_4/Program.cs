﻿// Тема 11 (4)

/* Заданаие: Напишите программу, которая запрашивает у пользователя его возраст и выводит сообщение о том, можно ли ему участвовать в выборах президента.
    Кандидаты в президенты солнечного города:
    ● Незнайка
    ● Лунтик
    ● Карлсон
    ● Дядя Фёдор
После ввода возраста, задать пользователю вопрос, за кого он будет болеть, если проиграет или не будет допущен к участию в выборах.
В зависимости от выбора пользователя вывести на экран культовую фразу персонажа.

Например:
Незнайка: “ А у тебя в животе арбуз вырастет!!! ”.

Если возраст меньше 18 лет, то выводится сообщение "Вы слишком молоды для участия в выборах".
Если возраст от 18 до 35 лет включительно, то выводится сообщение "Вы можете участвовать в выборах в качестве депутата".
Если возраст от 36 до 65 лет включительно, то выводится сообщение "Вы можете участвовать в выборах в качестве кандидата в президенты".
Если возраст больше 65 лет, то выводится сообщение "Ваш возраст слишком велик для участия в выборах". 
 */

//Console.Write("Укажите Ваш возраст: ");
//int age = int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");

//if (age < 18 || age > 65) Console.WriteLine("За кого Вы будете болеть?:\n" +
//    "1. Незнайка\n" +
//    "2. Лунтик\n" +
//    "3. Карлсон\n" +
//    "4. Дядя Фёдор");
//else if (age >= 18 && age <= 65) Console.WriteLine("За кого Вы будете болеть, если проиграете?:\n" +
//    "1. Незнайка\n" +
//    "2. Лунтик\n" +
//    "3. Карлсон\n" +
//    "4. Дядя Фёдор");
//byte answer = byte.Parse(Console.ReadLine());

//if (answer == 1) Console.WriteLine("А у тебя в животе арбуз вырастет!!!");
//else if (answer == 2) Console.WriteLine("Ну что, пойдëм играть?");
//else if (answer == 3) Console.WriteLine("Я — умный, красивый, в меру упитанный мужчина, ну в полном расцвете сил.");
//else if (answer == 4) Console.WriteLine("Я ничей. Я сам по себе мальчик. Свой собственный.");
//else Console.WriteLine("ОШИБКА!");


//  Дополнительные задания на 10ку:

/* Задание 1: Напишите программу, которая генерирует случайный месяц (например, январь, февраль или март) и запрашивает у пользователя угадать, сколько дней в этом месяце.
Если пользователь угадывает правильно, программа выводит сообщение о победе.
Если нет, программа выводит сообщение о том, сколько дней было в месяце. 
 */

//Random random = new Random();
//int x = random.Next(1, 13);
//int d;
//if (x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12) d = 31;
//else if (x == 4 || x == 6 || x == 9 || x == 11) d = 30;
//else d = 28;
//Console.Write("Угадайте количество дней в месяце: ");
//int a = int.Parse(Console.ReadLine());
//if (a == d) Console.WriteLine("Победа!");
//else if (x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12) Console.WriteLine($"В месяце был {d} день");
//else Console.WriteLine($"В месяце было {d} дней");


/* Задание 2: Напишите программу, которая генерирует случайное число от 1 до 12 (например, соответствующее месяцу) и выводит на экран название этого месяца. 
 */

Random random = new Random();
int m = random.Next(1, 13);
if (m == 1) Console.WriteLine("Январь");
else if (m == 2) Console.WriteLine("Февраль");
else if (m == 3) Console.WriteLine("Март");
else if (m == 4) Console.WriteLine("Апрель");
else if (m == 5) Console.WriteLine("Май");
else if (m == 6) Console.WriteLine("Июнь");
else if (m == 7) Console.WriteLine("Июль");
else if (m == 8) Console.WriteLine("Август");
else if (m == 9) Console.WriteLine("Сентябрь");
else if (m == 10) Console.WriteLine("Октябрь");
else if (m == 11) Console.WriteLine("Ноябрь");
else if (m == 12) Console.WriteLine("Декабрь");
