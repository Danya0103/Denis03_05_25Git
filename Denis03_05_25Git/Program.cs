class Program {
    static void Main(string[] args)
    {
        double balance = 100;
        Console.WriteLine($"{balance}");
        Console.WriteLine($"{AddMoney(ref balance, 200.0)}");
        Console.WriteLine($"{GiftMoney(ref balance, 50.0)}");
        Console.WriteLine($"{balance}");



    }

    static double AddMoney(ref double ba, double money)
    {
        ba += money;

        return ba;
    }

    static double GiftMoney(ref double ba, double money)
    {
        ba -= money;

        return ba;
    }
}
