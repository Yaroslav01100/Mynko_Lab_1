using System;

namespace Lab_1_task_2
{
public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToForeignCurrency(double amount, string currency)
    {
        switch (currency)
        {
            case "USD":
                return amount / usd;
            case "EUR":
                return amount / eur;
            case "PLN":
                return amount / pln;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }

    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency)
        {
            case "USD":
                return amount * usd;
            case "EUR":
                return amount * eur;
            case "PLN":
                return amount * pln;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Минко Ярослав");

        Console.Write("Введіть курс обміну USD до UAH: ");
        double usdRate = double.Parse(Console.ReadLine());

        Console.Write("Введіть курс обміну EUR до UAH: ");
        double eurRate = double.Parse(Console.ReadLine());

        Console.Write("Введіть курс обміну PLN до UAH: ");
        double plnRate = double.Parse(Console.ReadLine());

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.Write("Виберіть операцію (1 - гривня до іноземної валюти, 2 - іноземна валюта до гривні): ");
        int operation = int.Parse(Console.ReadLine());

        Console.Write("Введіть суму: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Введіть валюту (USD, EUR, PLN): ");
        string currency = Console.ReadLine().ToUpper();

        double result = 0;

        if (operation == 1)
        {
            result = converter.ConvertToForeignCurrency(amount, currency);
            Console.WriteLine($"{amount} UAH еквівалентно {result} {currency}");
        }
        else if (operation == 2)
        {
            result = converter.ConvertToUAH(amount, currency);
            Console.WriteLine($"{amount} {currency} еквівалентно {result} UAH");
        }
        else
        {
            Console.WriteLine("Неправильний вибір операції.");
        }
    }
}

}