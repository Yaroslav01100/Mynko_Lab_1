using System;

namespace Lab_1
{
    class Address
    { 
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

    class Program
    {
        static void Main()
        
        {
            Address address = new Address();

            Console.WriteLine("Минко Ярослав");

            address.Index = "55321";
            address.Country = "Україна";
            address.City = "Київ";
            address.Street = "Вулиця Героїв";
            address.House = "22";
            address.Apartment = "43";

            Console.WriteLine("Iндекс: " + address.Index);
            Console.WriteLine("Країна: " + address.Country);
            Console.WriteLine("Мiсто: " + address.City);
            Console.WriteLine("Вулиця: " + address.Street);
            Console.WriteLine("Будинок: " + address.House);
            Console.WriteLine("Квартира: " + address.Apartment);
        }
    }

}