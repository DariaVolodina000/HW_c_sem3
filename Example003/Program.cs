// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kub(int kub, int index)
{
    kub = (index * index * index);
    Console.Write($"{kub}, ");
}

try
{
Console.WriteLine("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int k = 1;

while (count <= num)
{
    Kub(k, count);
    count++;
    k++;
}
}
catch 
{
    Console.WriteLine("Введите число цифрами ");
}

