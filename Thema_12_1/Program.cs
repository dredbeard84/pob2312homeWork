// Тема 12 (1)

/*  Калькулятор: 
    пользователь может выбрать операцию (сложение, вычитание, умножение, деление),
    ввести два числа и
    получить результат.*/

Console.Write("Введите 1-е число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите операцию: ");
char oper = char.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
double b = double.Parse(Console.ReadLine());
switch (oper)
{
    case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
    case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
    case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
    case '/': Console.WriteLine($"{a} / {b} = {(a / b):F2}"); break;
    default: Console.WriteLine("Такой операции нет"); break;
}
