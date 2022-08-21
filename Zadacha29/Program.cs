// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("введите количество членов массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ArrayPrint(N));
for(int j=0; j< ArrayPrint(N).Length;j++)
{
    Console.Write($"{ArrayPrint(N)[j]} , ");
}
double [] ArrayPrint(int number)
{
    double [] newArray = new double[number];
    Random random = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        double newArr = Convert.ToDouble(random.Next(-100,100));
        newArray[i] = newArr;
    }
    return newArray;
}
