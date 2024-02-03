// Урок 5. Константы и литералы

// ДЗ 1

//Console.Write("Введите количество миллиметров: ");
//double mm = double.Parse(Console.ReadLine());
//const double SM = 0.1;
//const double M = 0.001;
//const double KM = 0.000001;
//const double ML = 0.000000621371192;
//const double YAR = 0.001094;
//Console.WriteLine($"\t = {mm * SM:F2} см");
//Console.WriteLine($"\t = {mm * M:F6} м");
//Console.WriteLine($"\t = {mm * KM:F6} км");
//Console.WriteLine($"\t = {mm * ML:F6} миль");
//Console.WriteLine($"\t = {mm * YAR:F6} ярдов");


// ДЗ 2

string firstProduct = "КОФЕ СТАНДАРТНЫЙ";
string secondProduct = "РУЛЕТ-СПРИНГ ТВ ИЗ\n  КУ";
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

Console.Write($"1 {firstProduct}\t{firstPrice}\t{firstQuantity}.00\t{firstResult}\n");// .00 - норм?
Console.Write($"  НДС с рассчитанной\t\t\t{nds18res:F2}\n  ставкой\n  18%\n\n");

Console.Write($"2 {secondProduct}\t\t\t{secondPrice}\t{secondQuantity}.00\t{secondResult}\n");
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
