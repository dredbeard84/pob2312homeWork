// Урок 4. Переменные и типы данных

// ДЗ 1

int moscow = 13015126;
Console.WriteLine($"В Москве {moscow} жителей");

int sPetersburg = 5598486;
Console.WriteLine($"В Санкт-Петербурге {sPetersburg} жителей");

int subtraction = Math.Abs(sPetersburg - moscow);
Console.WriteLine($"В Москве на {subtraction} жителей больше, чем в СПб");

int thousands = subtraction / 1000;
Console.WriteLine($"В Москве на {thousands} тысяч жителей больше, чем в СПб");


// ДЗ 2

decimal year = 260548.56895m;
Console.WriteLine($"Работник заработал за год {year} руб.");

decimal month = year / 12;
Console.WriteLine($"За месяц он заработал {month:F2} руб.");

decimal ndflMonth = month - (month * 0.13m);
Console.WriteLine($"А с вычетом НДФЛ {ndflMonth:F2} руб.");
