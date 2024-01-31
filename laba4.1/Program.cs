
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    double S = 0;
    for (int i = 1; i <= 7; i++)
    {
        double P = 1;
        for (int j = 1; j <= 7; j++)
        {
            P *= Math.Cos(i + 2 * j);
        }
        S += S + P;
    }
    Console.WriteLine($"Сумма произведений= {S}");
