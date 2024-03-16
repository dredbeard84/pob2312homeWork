// Тема: 14 (1)

/* Нужно разработать программу, которая будет генерировать пароли заданной длины для пользователей.
   Требования к программе:
   Пользователь должен иметь возможность указать длину пароля при запуске программы.
   Пароль должен состоять из букв латинского алфавита (в верхнем и нижнем регистре) и цифр.
   Для реализации генерации пароля требуется использовать цикл for.
   Программа должна создавать случайный набор символов, выбирая из списка допустимых символов на каждой итерации цикла. */

Console.Write("Введите длину пароля: ");
int passLength = int.Parse(Console.ReadLine());
string symbols = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
Random random = new Random();
string pass = "";
for (int i = 0; i < passLength; i++) pass += symbols[random.Next(symbols.Length)];
Console.WriteLine(pass);
