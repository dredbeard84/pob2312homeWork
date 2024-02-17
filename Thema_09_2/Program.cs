﻿// Тема 9 (2)

/*      Заданаие 1:
Произведите операцию инверсии со следующими числами, используя тип данных long:
    264895468854
    256
 */
{
    long num = 264895468854;// 0011 1101 1010 1101 0000 0000 0001 0101 0011 0110
    /*
     0011 1101 1010 1101 0000 0000 0001 0101 0011 0110 =  264 895 468 854
     ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓ ↓↓↓↓
     1100 0010 0101 0010 1111 1111 1110 1010 1100 1001 = -264 895 468 855
     */
    Console.WriteLine($"~264 895 468 854 = {~num}");
}
{
long num = 256;// 0001 0000 0000
    /*
     0001 0000 0000 =  256
     ↓↓↓↓ ↓↓↓↓ ↓↓↓↓
     1110 1111 1111 = -257
     */
    Console.WriteLine($"~256 = {~num}");
}


/*      Задание 2:
Произведите операцию сдвига вправо и влево со следующими числами:
    256;
    32856;
 */

{
    int num = 256;
    /*
     256 << 1 = 512     0010 0000 0000
     256                0001 0000 0000
     256 >> 1 = 128     0000 1000 0000
     */
    Console.WriteLine($"256 << 1 = {num << 1}");
    Console.WriteLine($"256 >> 1 = {num >> 1}");
}
{
    int num = 32856;
    /*
     32 856 << 1 = 65 712	0001 0000 0000 1011 0000
     32 856			        0000 1000 0000 0101 1000
     32 856 >> 1 = 16 428	0000 0100 0000 0010 1100
     */
    Console.WriteLine($"32 856 << 1 = {num << 1}");
    Console.WriteLine($"32 856 >> 1 = {num >> 1}");
}


/*      Задание 3:
Произведите операцию присваивания со следующими числами:
    289,
    144,
    36274;
С изменением на 2487;
 */
{
    int num1 = 289;
    Console.WriteLine($"Присваивание 2487 к 289 после сложения :{num1 += 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после вычитания :{num1 -= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после умножения :{num1 *= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после деления :{num1 /= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после деления с остатком :{num1 %= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после логического умножения :{num1 &= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после логического сложения :{num1 |= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после исключающего или :{num1 ^= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после сдвига влево :{num1 <<= 2487}");
    Console.WriteLine($"Присваивание 2487 к 289 после сдвига вправо :{num1 >>= 2487}");
}
{
    int num1 = 144;
    Console.WriteLine($"Присваивание 2487 к 144 после сложения :{num1 += 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после вычитания :{num1 -= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после умножения :{num1 *= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после деления :{num1 /= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после деления с остатком :{num1 %= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после логического умножения :{num1 &= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после логического сложения :{num1 |= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после исключающего или :{num1 ^= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после сдвига влево :{num1 <<= 2487}");
    Console.WriteLine($"Присваивание 2487 к 144 после сдвига вправо :{num1 >>= 2487}");
}
{
    int num1 = 36274;
    Console.WriteLine($"Присваивание 2487 к 36274 после сложения :{num1 += 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после вычитания :{num1 -= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после умножения :{num1 *= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после деления :{num1 /= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после деления с остатком :{num1 %= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после логического умножения :{num1 &= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после логического сложения :{num1 |= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после исключающего или :{num1 ^= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после сдвига влево :{num1 <<= 2487}");
    Console.WriteLine($"Присваивание 2487 к 36274 после сдвига вправо :{num1 >>= 2487}");
}
