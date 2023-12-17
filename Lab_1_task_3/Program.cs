using System;

namespace Lab_1_task3
{
public class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public void SetExperience(int experience)
    {
        this.experience = experience;
    }

    public double CalculateSalary()
    {

        double baseSalary = 30000; 

        switch (position.ToLower())
        {
            case "менеджер":
                baseSalary += experience * 1000;
                break;
            case "розробник":
                baseSalary += experience * 1500;
                break;
            case "дизайнер":
                baseSalary += experience * 1200;
                break;

            default:
                Console.WriteLine("Непідтримувана посада");
                return 0;
        }

        double tax = baseSalary * 0.15;

        return baseSalary - tax;
    }

    public void PrintEmployeeInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {CalculateSalary()} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Минко Ярослав");

        Console.Write("Введіть прізвище співробітника: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть ім'я співробітника: ");
        string firstName = Console.ReadLine();

        Employee employee = new Employee(lastName, firstName);

        Console.Write("Введіть посаду співробітника: ");
        string position = Console.ReadLine();
        employee.SetPosition(position);

        Console.Write("Введіть стаж співробітника (у роках): ");
        int experience = int.Parse(Console.ReadLine());
        employee.SetExperience(experience);

        Console.WriteLine("Інформація про співробітника:");
        employee.PrintEmployeeInfo();
    }
}

}