//3.1 Средний уровень #15 
try
{
    Console.Write("Введите k:");
    double k = double.Parse(Console.ReadLine());
    double S = 0;
    for (int n = 1; n <= k; n++)
    {
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        S += (Math.Pow(-1, 2 * n) * Math.Pow((Math.Pow(n, 2) - 9), 2)) / 3 * factorial;
    }
    Console.WriteLine($"S={S:F2}");
}
catch { Console.WriteLine("Ошибка"); }