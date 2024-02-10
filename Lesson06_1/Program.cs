// Тема 6: Преобразования типов и способы

/* Задание 1:
 * Есть исходный тип данных: string, хранящий число 28. 
 * Конвертируйте его в следующие типы данных, последовательно:
 * сначала в byte,
 * затем из пердыдущего в nint,
 * затем из пердыдущего в int,
 * затем из пердыдущего в long,
 * затем из пердыдущего в double.
 */

string str = "28";
byte numByte = byte.Parse(str);
nint numNInt = numByte;
int numInt = (int)numNInt;
long numLong = numInt;
double numDouble = numLong;
Console.WriteLine(numByte);
Console.WriteLine(numNInt);
Console.WriteLine(numInt);
Console.WriteLine(numLong);
Console.WriteLine(numDouble);
