// Тема 16 (2)

// "Управление лампочкой"

char[,] mas =
{
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', 'X', ' ', ' ', 'X', ' ' },
    { 'X', ' ', ' ', ' ', ' ', 'X' },
    { ' ', 'X', 'X', 'X', 'X', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', ' ', 'X', 'X', ' ', ' ' },
    { ' ', 'X', 'X', 'X', 'X', ' ' },
};
Console.Clear();
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Включить лампочку?");
string answer1 = Console.ReadLine();
string yes = "да";
Console.Clear();
if (answer1 == yes)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[1, 2] = 'X';
            mas[1, 3] = 'X';
            mas[2, 1] = 'X';
            mas[2, 2] = 'X';
            mas[2, 3] = 'X';
            mas[2, 4] = 'X';
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Выключить лампочку?");
string answer2 = Console.ReadLine();
Console.Clear();
if (answer2 == yes)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[1, 2] = ' ';
            mas[1, 3] = ' ';
            mas[2, 1] = ' ';
            mas[2, 2] = ' ';
            mas[2, 3] = ' ';
            mas[2, 4] = ' ';
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}
