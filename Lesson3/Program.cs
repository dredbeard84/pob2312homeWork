// Тема 3
// Урок 1. Алгоритмические основы программирования
// Урок 2. Работа со строками


// ДЗ: "Добиться успеха легко, познать смысл - вот проблема"

string firstWord = "Добиться успеха легко,";
string secondWord = "познать смысл - вот проблема";

// Конкатенация
string result = firstWord + " " + secondWord;
Console.WriteLine(result);

// Интерполяция
Console.WriteLine($"{firstWord} {secondWord}");

// Concat()
string union = firstWord + " " + secondWord;
string sentence = string.Concat(union, "!!!");
Console.WriteLine(sentence);

// Substring()
string cutSentence = sentence.Substring(2);
Console.WriteLine(cutSentence);

// Insert
string thirdWord = firstWord.Insert(22, secondWord);
Console.WriteLine(thirdWord);
