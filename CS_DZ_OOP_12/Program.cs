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
                Console.WriteLine("Для того что бы подойти к вольеру введите 1");
                Console.WriteLine("Для выхода введите 2");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        _aviarys.ShowAnimals();
                        break;
                    case "2":
                        isWork = false;
                        break;
                }
            }
        }
    }

    class Aviarys
    {
        private List<Animal> _aviarys = new List<Animal>() { new Animal("Собаки", "Мальчики", "Лают", 6), new Animal("Тигрицы", "Девочки", "Рычат", 3),
                                        new Animal("Обезьяны", "Мальчики", "Кричат", 10), new Animal("Змеи", "Девочки", "Сидят тихо", 30) };
        
        public void ShowAnimals()
        {
            Console.Clear();
            Console.WriteLine("В зоопарке сейчас " + _aviarys.Count + " вольера");
            Console.Write("Введите номер вальера к которому нужно подойти: ");
            if(int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0 && userInput <= _aviarys.Count)
            {
                Console.WriteLine("В этом вальере у нас - " + _aviarys[userInput - 1].Name + " это " + _aviarys[userInput - 1].Genger + " их " + _aviarys[userInput - 1].Count + " и они " + _aviarys[userInput - 1].Voice);
            }
            else
            {
                Console.WriteLine("Ввод не корректный");
            }
            Console.ReadKey();
        }

        private void ShowInfo(Animal animals)
        {
            Console.Clear();
            
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
