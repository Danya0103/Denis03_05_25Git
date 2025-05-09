/*
class Program {

    static void Main(string[] args) {

        double balance = 100;
        double deposit = 0;

        Console.WriteLine($"Поточний баланс: {balance}");
        Console.WriteLine($"Депозит: {deposit} (5% річних)");

        balance = Money(ref balance, 200.0);
        Console.WriteLine($"Після поповнення: {balance}");

        balance = AddMoney(ref balance, 50.0);
        Console.WriteLine($"Після зняття: {balance}");

        balance = DepositMoneyGive(ref balance, ref deposit, 150.0);
        Console.WriteLine($"Баланс після внесення на депозит: {balance}");
        Console.WriteLine($"Депозит: {deposit}");

        balance = DepositMoneyGet(ref balance, ref deposit);
        Console.WriteLine($"Баланс після зняття депозиту: {balance}");
        Console.WriteLine($"Депозит: {deposit}");

    }

    static double Money(ref double ba, double money) {

        ba += money;
        return ba;

    }

    static double AddMoney(ref double ba, double money) {

        ba -= money;
        return ba;

    }


// ось тут повинні не так рахувати Депозит, 
double Credit(double balance, double deposit, double percent, int term) {
    // 1000, 1000, 5%, 10 
    // balance 1000  +  (1000*0.05*10)
    
    static double DepositMoneyGive(ref double balance, ref double deposit, double money) {

        balance -= money;
        deposit += money;
        return balance;

    }


// і тоді треба буде змінити і кредитну механіку
    static double DepositMoneyGet(ref double balance, ref double deposit) {

        double withInterest = deposit * 1.05;
        balance += withInterest;
        deposit = 0;
        return balance;

    }
}
*/

/*
class Program {

    static void Main(string[] args) {

        double balance = 100;
        double credit = 0;

        Console.WriteLine($"Поточний баланс: {balance}");
        Console.WriteLine($"Кредит: {credit} (7% річних)");

        balance = Money(ref balance, 200.0);
        Console.WriteLine($"Після поповнення: {balance}");

        balance = AddMoney(ref balance, 50.0);
        Console.WriteLine($"Після зняття: {balance}");

        balance = CreditMoneyGive(ref balance, ref credit, 250.0);
        Console.WriteLine($"Баланс після взяття кредиту: {balance}");
        Console.WriteLine($"Кредит: {credit}");

        balance = CreditMoneyGet(ref balance, ref credit);
        Console.WriteLine($"Баланс після повертання кредиту: {balance}");
        Console.WriteLine($"Борг по кредиту: {credit}");

    }
