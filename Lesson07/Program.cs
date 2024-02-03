// Урок 7

//      Задание 1. Напишите программу, запрашивающую у пользователя радиус окружности и производящую просчёт площади круга, используя заранее заданную константу числа PI.

Console.Write("Введите радиус окружности: ");
double R = double.Parse(Console.ReadLine());
const double PI = 3.14;
double S = PI * R * R;
Console.WriteLine($"Площадь круга = {S:F2}");


//      Задание 2. Напишите программу, запрашивающую у пользователя данные о нём и выводящую его досье. Используйте для данного задания Интерполяцию.

Console.Write("Введите фамилию: ");
string surName = Console.ReadLine();
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите дату рождения: ");
string birthDate = Console.ReadLine();
Console.Write("Укажите адрес: ");
string adress = Console.ReadLine();
Console.Write("Укажите место работы: ");
string work = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine($"Пользователь:\nФамилия: {surName}\nИмя: {name}\nДата рождения: {birthDate}\nАдресс: {adress}\nМесто работы: {work}");


//      Задание 3. Дополнительно изучите структуру DateTime.

DateTime date1 = DateTime.Now;// текущая дата
DateTime date2 = DateTime.UtcNow;// всемирная дата
DateTime date3 = DateTime.Today;// сегодняшняя дата

//      вычетание из текщего экземпляра даты и времени определённого числа 

DateTime today = DateTime.Today;
Console.WriteLine(today);// текущий экземпляр даты и времени
Console.WriteLine(today.AddDays(1));// дней
Console.WriteLine(today.AddHours(2));// часов
Console.WriteLine(today.AddMicroseconds(3));// микросекунд
Console.WriteLine(today.AddMilliseconds(4));// миллисекунд
Console.WriteLine(today.AddMinutes(5));// минут
Console.WriteLine(today.AddMonths(6));// месяцев
Console.WriteLine(today.AddSeconds(7));// секунд
Console.WriteLine(today.AddTicks(8));// тактов
Console.WriteLine(today.AddYears(9));// лет
