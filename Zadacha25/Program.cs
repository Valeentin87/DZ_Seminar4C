// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите натуральную степень B, в которую надо возвести число А");
int B = Convert.ToInt32(Console.ReadLine());
int result = degree(A,B);
Console.WriteLine($"{A} в степени {B} равно {result}");
int degree(int number, int degreenumber)
{
    int composition = number;
    for(int i = 1; i < degreenumber; i++)
    {
        composition = composition*number;
    }
    return composition;
}
int clear = 67;