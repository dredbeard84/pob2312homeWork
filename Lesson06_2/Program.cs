// Тема 6: Преобразования типов и способы

// дз 6-2
/* Написать программу конвертор, в котором будут использованы встроенные методы:
 *      GetType();
 *      ToString();
 *      Parse;
 * По 2 примера их работы. */

Console.Write("Введите число от 1 до 380: ");
double numDouble = double.Parse(Console.ReadLine());// Parse - 1
int numInt = (int)numDouble;
Console.WriteLine("Целое число из дробного: " + numInt + " " + numInt.GetType());// GetType - 1
string str = numDouble.ToString();// ToString - 1
Console.WriteLine("Строка из дробного числа: " + str + " " + str.GetType());// GetType - 2
int newNumInt = int.Parse(str);
Console.WriteLine("Целое число из строки: " + newNumInt + " " + newNumInt.GetType());// Parse - 2
string newStr = newNumInt.ToString();
Console.WriteLine("Строка из целого числа: " + newStr + " " + newStr.GetType());// ToString - 2
