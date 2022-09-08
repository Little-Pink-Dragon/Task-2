int a = 1;
bool not = true;
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + n);
while (a <= n)
{
    if (a % 2 != 1)
    {
        Console.Write(a + ", ");
        not = false;
    }
    a = a + 1;
}

    if (not)
    {
    Console.WriteLine("Нет чётных чисел!");
    }
