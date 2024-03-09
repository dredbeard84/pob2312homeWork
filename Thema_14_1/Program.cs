//for (int i = 48; i <= 57; i++) Console.Write((char)i + " ");// 0 1 2 3 4 5 6 7 8 9
//Console.WriteLine();
//for (int i = 58; i <= 64; i++) Console.Write((char)i + " ");// : ; < = > ? @
//Console.WriteLine();
//for (int i = 65; i <= 90; i++) Console.Write((char)i + " ");// A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
//Console.WriteLine();
//for (int i = 91; i <= 96; i++) Console.Write((char)i + " ");// [ \ ] ^ _ `
//Console.WriteLine();
//for (int i = 97; i <= 122; i++) Console.Write((char)i + " ");// a b c d e f g h i j k l m n o p q r s t u v w x y z
//Console.WriteLine();


// 14-1
Console.Write("Введите длину пароля: ");
int passLength = int.Parse(Console.ReadLine());
Random random = new Random();
for (int i = 0; i < passLength; i++)
{
    int pass = random.Next(48, 123);
    if (pass >= 58 && pass <= 64 && pass >= 91 && pass <= 96) Console.Write("");
    Console.Write((char)pass);
}
Console.WriteLine();


//Console.Write("ВВедите Х: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите Y: ");
//double y = double.Parse(Console.ReadLine());
//if (x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5)
//     Console.WriteLine("Попал");
//else Console.WriteLine("Не попал");
