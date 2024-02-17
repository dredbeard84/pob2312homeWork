﻿// Тема 9 (1)

/*      Заданаие 1:
Произведите операцию логического умножения со следующими числами:
     8 & 3
    22 & 4
 */
{
    int num1 = 8;// 1000
    int num2 = 3;// 0011
    /*
     1000 = 8
     0011 = 3
     ↓↓↓↓
     0000 = 0
     */
    Console.WriteLine($"8 & 3 = {num1 & num2}");// 0000 = 0
}
{
    int num1 = 22;
    int num2 = 4;
    /*
     0001 0110 = 22
     0000 0100 = 4
     ↓↓↓↓ ↓↓↓↓
     0000 0100 = 4
     */
    Console.WriteLine($"22 & 4 = {num1 & num2}");// 0000 0100 = 4
}


/*      Задание 2:
Произведите операцию логического сложения со следующими числами:
    65 | 29
    44 | 12
 */

{
    int num1 = 65;
    int num2 = 29;
    /*
     0100 0001 = 65
     0001 1101 = 29
     ↓↓↓↓ ↓↓↓↓
     0101 1101 = 93
     */
    Console.WriteLine($"65 | 29 = {num1 | num2}");// 0101 1101 = 93
}
{
    int num1 = 44;
    int num2 = 12;
    /*
     0010 1100 = 44
     0000 1100 = 29
     ↓↓↓↓ ↓↓↓↓
     0010 1100 = 44
     */
    Console.WriteLine($"44 | 12 = {num1 | num2}");// 0010 1100 = 44
}


/*      Задание 3:
Произведите операцию логического исключения со следующими числами, разберитесь с возможностью шифрования чисел:
    249, (ключ) 8
 */

{
    int num1 = 249;
    int num2 = 8;
    /*
     1111 1001 = 249
     0000 1000 = 8
     ↓↓↓↓ ↓↓↓↓
     1111 0001 = 241
     */
    Console.WriteLine($"249 ^ 8 = {num1 ^ num2}");// 1111 0001 = 241
}
