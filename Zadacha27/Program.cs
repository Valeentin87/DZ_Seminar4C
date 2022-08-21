// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр в числе {num} равна {SumOfDigits(num)}");

int SumOfDigits(int number)
{
int sum = 0;
while (number!=0)
{
    if (number>0 && number<10)
    {
        sum = sum + number;
        number = 0;
    }
    else
    {
        sum = sum + number%10;
        number = number/10;
    }
    
}
    return sum;
}

