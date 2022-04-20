using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_OOP_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Console.WriteLine("Добро пожаловать в зоопарк!");
            Console.ReadKey();
            zoo.Work();
        }
    }

    class Zoo
    {
        private Aviarys _aviarys = new Aviarys();

        public void Work()
        {
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine("Для того что бы подойти к вольеру и посмотреть введите номер от 1 до 4");
                Console.WriteLine("Для выхода введите 5");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        _aviarys.ShowAnimals(Convert.ToInt32(userInput));
                        break;
                    case "2":
                        _aviarys.ShowAnimals(Convert.ToInt32(userInput));
                        break;
                    case "3":
                        _aviarys.ShowAnimals(Convert.ToInt32(userInput));
                        break;
                    case "4":
                        _aviarys.ShowAnimals(Convert.ToInt32(userInput));
                        break;
                    case "5":
                        isWork = false;
                        break;
                }
            }
        }
    }

    class Aviarys
    {
        private Animal _dogs = new Animal ("Собаки", "Мальчики", "Лают", 6);
        private Animal _tigers = new Animal("Тигрицы", "Девочки", "Рычат", 3) ;
        private Animal _monkeys = new Animal("Обезьяны", "Мальчики", "Кричат", 10) ;
        private Animal _snakes = new Animal("Змеи", "Девочки", "Сидят тихо", 30);

        public void ShowAnimals(int userInput)
        {
            if(userInput == 1)
            {
                ShowInfo(_dogs);
            }
            else if(userInput == 2)
            {
                ShowInfo(_tigers);
            }
            else if(userInput == 3)
            {
                ShowInfo(_monkeys);
            }
            else if(userInput == 4)
            {
                ShowInfo(_snakes);
            }
        }

        private void ShowInfo(Animal animals)
        {
            Console.Clear();
            Console.WriteLine("В этом вальере у нас - " + animals.Name + " это " + animals.Genger + " их " + animals.Count + " и они " + animals.Voice);
            Console.ReadKey();
        }
    }

    class Animal
    {
        public string Name { get; private set; }

        public string Voice { get; private set; }

        public string Genger { get; private set; }

        public int Count { get; private set; }

        public Animal(string name, string gender, string voice, int count)
        {
            Name = name;
            Genger = gender;
            Voice = voice;
            Count = count;
        }
    }
}
