﻿// Тема 15 (1)

/* Создайте строковый массив, размеров в 10 ячеек.
   Заполните его словами в следующем порядке:
    “освоении”,
    “остальное”,
    “по плечу”,
    “сложный”,
    “но если”,
    “программирования”,
    “многие бросают”,
    “остальное будет”,
    “освоить их,”,
    “этап в”,
    “на этом этапе,”,
    “Массивы -”
   Соберите в новом массиве полноценную фразу. */

string[] mas = { "освоении", "остальное", "по плечу", "сложный", "но если", "программирования", "многие бросают", "остальное будет", "освоить их,", "этап в", "на этом этапе,", "Массивы -" };
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
Console.WriteLine();
Console.Write($"{mas[11]} {mas[3]} {mas[9]} {mas[0]} {mas[5]} {mas[6]} {mas[1]} {mas[10]} {mas[4]} {mas[8]} {mas[7]} {mas[2]} ");
Console.WriteLine();
