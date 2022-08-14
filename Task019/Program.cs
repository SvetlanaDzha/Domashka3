// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if(number.Length != 5) 
{
    Console.WriteLine($"Число {number} не является пятизначным");
    return;
}

bool isPolindrom = true;
for(int i = 0, N = number.Length - 1; i < 5 && N > 0; i++, N--) 
{
    if(number[i] != number[N]) 
    {
        isPolindrom = false;
        break;
    }
}

Console.WriteLine($"{number} - {(isPolindrom ? "да" : "нет")}");
