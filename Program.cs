using System.Xml.Linq;

namespace AppOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pen pen = new Pen();
            pen.Greetings();
            pen = new Pen("Красный", 1234);
            pen.Greetings();
            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
            animal.Info();
            Bus bus = new Bus();
            bus.PrintStatus();*/
            User user = new User();
            user.Age = 15;
            user.Login = "DaringBear";
            user.Mail = "domes_tik@mail.ru";
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Login);
            Console.WriteLine(user.Mail);
        }
        
    }
    class User
    {
        private int age;
        private string login, mail;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length < 3) { Console.WriteLine("Логин должен быть не менее 3-х символов длинной"); }
                else login = value;
            }
        }
        public string Mail
        {
            get { return mail; }
            set
            {
                if (!value.Contains('@')) { Console.WriteLine("В почте должен содержаться символ @"); }
                else mail = value;
            }
        }
    }
    class TrafficLight
    {
        private string color;
        private void ChangeColor(string newcolor)
        {
            if (color != newcolor) color = newcolor;
        }
        public string GetColor()
        {
            return color;
        }
    }
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }
    class Car
    {
        private double Fuel;

        private int Mileage;

        private string color;

        private TurnDirection turn;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }

        private void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        public string GetColor()
        {
            return color;
        }

        public void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }
    class Bus
    {
        public int? Load;
        
        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }
    class Company
    {
        public string Type;
        public string Name;
    }
    class Department
    {
        public Company Company;
        public City City;
    }
    class City
    {
        public string Name;
    }
    class Pen
    {
        public string color;
        public int cost;
        
        public void Greetings()
        {
            Console.WriteLine("Цвет: {0}, а его стоимость: {1}", color, cost);
        }
        
        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string PenColor, int PenCost)
        {
            color = PenColor;
            cost = PenCost;
        }

    }
    class Rectangle
    {
        public int a, b;
        public int Square(int a, int b)
        {
            return a * b;
        }
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int equality)
        {
            a = equality;
            b = equality;
        }
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }
    }
    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
}