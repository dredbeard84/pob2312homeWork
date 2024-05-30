// Тема 8 (4)

/* Задание: 
    Доработать магазин, доделать, если не успели.
    Если успели - провести апгрейд, добавить перчатки, шапки, рубашки.
*/

Console.Write("Введите количество монет: ");
decimal money = decimal.Parse(Console.ReadLine()!);
decimal butter = 150.0m;
decimal bread = 50.0m;
decimal tea = 40.0m;
decimal gloves = 200.0m;
decimal hats = 150.0m;
decimal shirts = 250.0m;
Console.WriteLine($"{"Хлеб",-8}{bread,8}\n" +
                  $"{"Масло",-8}{butter,8}\n" +
                  $"{"Чай",-8}{tea,8}\n" +
                  $"{"Перчатки",-8}{gloves,8}\n" +
                  $"{"Шапки",-8}{hats,8}\n" +
                  $"{"Рубашки",-8}{shirts,8}\n");
Console.Write("Введите количество хлеба: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество масла: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество чая: ");
int n3 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество пар перчаток: ");
int n4 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество шапок: ");
int n5 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество рубашек: ");
int n6 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"{"Хлеб",-8}{bread,8}{n1,4}{bread * n1,8}");
Console.WriteLine($"{"Масло",-8}{butter,8}{n2,4}{butter * n2,8}");
Console.WriteLine($"{"Чай",-8}{tea,8}{n3,4}{tea * n3,8}");
Console.WriteLine($"{"Перчатки",-8}{gloves,8}{n4,4}{gloves * n4,8}");
Console.WriteLine($"{"Шапки",-8}{hats,8}{n5,4}{hats * n5,8}");
Console.WriteLine($"{"Рубашки",-8}{shirts,8}{n6,4}{shirts * n6,8}");
Console.WriteLine($"{"Итого",-8}{bread * n1 + butter * n2 + tea * n3 + gloves * n4 + hats * n5 + shirts * n6,20}");
Console.WriteLine($"{"Остаток",-8}{money - (bread * n1 + butter * n2 + tea * n3 + gloves * n4 + hats * n5 + shirts * n6),20}");
