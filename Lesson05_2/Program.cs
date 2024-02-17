// Урок 5. Константы и литералы

// ДЗ 2

string firstProduct = "КОФЕ СТАНДАРТНЫЙ";
string secondProduct = "РУЛЕТ-СПРИНГ ТВ ИЗ КУ";
string result = "Итого:";

decimal firstPrice = 69.00m;
decimal secondPrice = 70.00m;

const decimal NDS18 = 18m / 118m;
const decimal NDS10 = 10m / 110m;

int firstQuantity = 1;
int secondQuantity = 1;

decimal firstResult = firstPrice * firstQuantity;
decimal secondResult = secondPrice * secondQuantity;
decimal nds18res = firstResult * NDS18;
decimal nds10res = secondResult * NDS10;
decimal resultPrice = firstPrice + secondPrice;

Console.Write("**********************************************\n\n");

Console.Write("№ Название\t\tЦена\tКол.\tСумма\n");

Console.Write($"1 {firstProduct}\t{firstPrice}\t{firstQuantity}\t{firstResult}\n");
Console.Write($"  НДС с рассчитанной\t\t\t{nds18res:F2}\n  ставкой\n  18%\n\n");

Console.Write($"2 {secondProduct}\t{secondPrice}\t{secondQuantity}\t{secondResult}\n");
Console.Write($"  НДС с рассчитанной\t\t\t{nds10res:F2}\n  ставкой\n  10%\n\n\n");

Console.Write("**********************************************\n");

Console.Write($"{result}\t\t\t\t\t{resultPrice}\n");
Console.Write($"Электронные средства\t\t\t{resultPrice}\n");
Console.Write($"НДС итога чека с\t\t\t{nds18res:F2}\nрассчитанной ставкой\n18%\n");
Console.Write($"НДС итога чека с\t\t\t{nds10res:F2}\nрассчитанной ставкой\n10%\n\n\n");

Console.Write("**********************************************\n");

Console.Write("ВИД НАЛОГООБЛАЖЕНИЯ: ОСН\n");
Console.Write("РЕГ. НОМЕР ККТ: 0000143873023483\n");
Console.Write("ЗАВОД №:\n");
Console.Write("ФН №: 8710000100265168\n");
Console.Write("ФД №: 6026\n");
Console.Write("ФПД: 3322278314\n");
