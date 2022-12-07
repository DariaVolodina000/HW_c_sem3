// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

try
{
    int num1 = 0; int num2 = 0; int num4 = 0; int num5 = 0;

    Console.WriteLine("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 9999 && num < 100000)
    {

        num5 = (num % 10);
        num4 = (num % 100) / 10;
        num2 = (num / 1000 % 10);
        num1 = (num / 10000);

        if (num1 == num5 && num2 == num4) Console.WriteLine("Это полиндром!");
        else Console.WriteLine("Это не полиндром!");
    }
    else
    {
        Console.WriteLine("введите пятизначное число! ");
    }
}
catch
{
    Console.WriteLine("Введите число цифрами! ");
}






