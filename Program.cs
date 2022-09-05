Console.Clear();
Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_2 * num_2 == num_1)
{   Console.WriteLine("Первое число является квадратом второго");
}
else 
    Console.WriteLine("Первое число не является квадратом второго");