// Урок 5. Константы и литералы

// ДЗ 1

Console.Write("Введите количество миллиметров: ");
double mm = double.Parse(Console.ReadLine());
const double SM = 0.1;
const double M = 0.001;
const double KM = 0.000001;
const double ML = 0.000000621371192;
const double YAR = 0.001094;
Console.WriteLine($"\t = {mm * SM:F2} см");
Console.WriteLine($"\t = {mm * M:F6} м");
Console.WriteLine($"\t = {mm * KM:F6} км");
Console.WriteLine($"\t = {mm * ML:F6} миль");
Console.WriteLine($"\t = {mm * YAR:F6} ярдов");
