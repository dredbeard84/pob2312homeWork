// Тема 6: Преобразования типов и способы

// дз 6-2
/* Написать программу конвертор, в котором будут использованы встроенные методы:
 *      GetType();
 *      ToString();
 *      Parse;
 * По 2 примера их работы. */

Console.Write("Введите число меньше 380: ");
double numDouble = double.Parse(Console.ReadLine());// Parse - 1
int numInt = (int)numDouble;
string str = numDouble.ToString();// ToString - 1
char sym = (char)numDouble;
Console.WriteLine("Целое число: " + numInt + " " + numInt.GetType());// GetType - 1
Console.WriteLine("Строка: " + str + " " + str.GetType());// GetType - 2
Console.WriteLine("Символ: " + sym + " " + sym.GetType());// GetType - 3
Console.WriteLine(int.Parse(sym.ToString()));// Parse - 2, ToString- 2
