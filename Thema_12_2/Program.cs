// Тема 12 (2)

/*  Пользователю на выбор дается 5 ароматов духов:
    ● Chanel
    ● Dior
    ● Tom Ford
    ● Gucci
    ● Yves Saint Laurent
    В зависимости от его выбора выводить ему краткую информацию об аромате.*/

Console.WriteLine("Выберите один из ароматов духов:\n" +
    "1. Chanel\n" +
    "2. Dior\n" +
    "3. Tom Ford\n" +
    "4. Gucci\n" +
    "5. Yves Saint Laurent\n");
Console.Write("");
byte n = byte.Parse(Console.ReadLine());
switch (n)
{
    case 1: Console.Write("Тра-ля-ля, тоси-боси, какая-то информация о Chanel."); break;
    case 2: Console.Write("Тра-ля-ля, тоси-боси, какая-то информация о Dior."); break;
    case 3: Console.Write("Тра-ля-ля, тоси-боси, какая-то информация о Tom Ford."); break;
    case 4: Console.Write("Тра-ля-ля, тоси-боси, какая-то информация о Gucci."); break;
    case 5: Console.Write("Тра-ля-ля, тоси-боси, какая-то информация о Yves Saint Laurent."); break;
    default: Console.WriteLine("К сожалению, такого аромата нет в списке."); break;
}
Console.WriteLine();
