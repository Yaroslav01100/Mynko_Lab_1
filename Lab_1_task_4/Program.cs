using System;

namespace Lab_1_task_4
{
    public class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine($"Логін: {login}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Вік: {age} років");
            Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Минко Ярослав");

            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);

            Console.WriteLine("Дані анкети успішно введено. Інформація про користувача:");
            user.PrintUserInfo();
        }
    }

}