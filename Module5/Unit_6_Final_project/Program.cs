using System;

namespace Unit_6_Final_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var DataUser1 = DataUser();
            Output(DataUser1.Item1, DataUser1.Item2, DataUser1.Item3, DataUser1.Item4, DataUser1.Item5, DataUser1.Item6, DataUser1.Item7, DataUser1.Item8);
        }
        static (string, string, int, bool, int, string[], int, string[]) DataUser()
        {
            (string Name, string Surname, int Age, bool AvalPet, int QuantPet, string[] Pet, int QuantFavColor, string[] FavColor) DataUser;
            //-----------------------------------
            Console.WriteLine("Введите свое имя:");
            DataUser.Name = Console.ReadLine();
            
            //-----------------------------------
            Console.WriteLine("Введите свою фамилию:");
            DataUser.Surname = Console.ReadLine();
            //-----------------------------------
            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите свой возраст:");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));
            DataUser.Age = intage;
            //-----------------------------------
            Console.WriteLine("Есть ли у Вас питомец (Да или Нет):");
            if (Console.ReadLine() == "Да")
            {
                DataUser.AvalPet = true;
                string QuantPet;
                int intQuantPet;
                do
                {
                    Console.WriteLine("Укажите количество питомцев:");
                    QuantPet = Console.ReadLine();
                } while (CheckNum(QuantPet, out intQuantPet));
                DataUser.QuantPet = intQuantPet;
                DataUser.Pet = Pet(DataUser.QuantPet);
            }
            else
            {
                DataUser.AvalPet = false;
                DataUser.QuantPet = 0;
                DataUser.Pet = Pet(DataUser.QuantPet);
            }
            //-----------------------------------
            string QuantFavColor;
            int intQuantFavColor;
            do
            {
                Console.WriteLine("Укажите кол-во любимых цветов:");
                QuantFavColor = Console.ReadLine();
            } while (CheckNum(QuantFavColor, out intQuantFavColor));
            DataUser.QuantFavColor = intQuantFavColor;
            DataUser.FavColor = FavColor(DataUser.QuantFavColor);
            //-----------------------------------
            return DataUser; //(DataUser.Name, DataUser.Surname, DataUser.Age, DataUser.AvalPet, DataUser.QuantPet, DataUser.Pet, DataUser.QuantFavColor, DataUser.FavColor);
        }
        static string[] Pet(int QP)
        {
            var Pet = new string[QP];
            for (int i = 0; i < Pet.Length; i++)
            {
                Console.WriteLine("Введите кличку питомца {0}:", i+1);
                Pet[i] = Console.ReadLine(); 
            }
           return Pet;
        }
        static string[] FavColor(int QFC)
        {
            var FavColor = new string[QFC];
            
            for (int i = 0; i < QFC; i++)
            {
                Console.WriteLine("Введите любимый цвет {0}:", i+1);
                FavColor[i] = Console.ReadLine();
            }
            return FavColor;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }
        static void Output(string Name, string Surname, int Age, bool AvalPet, int QuantPet, string[] Pet, int QuantFavColor, string[] FavColor)
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Возраст: {0} лет", Age);
            if (AvalPet == true)
            {
                Console.WriteLine("У Вас есть питомцы в количестве {0} штук", QuantPet);
                for (int i = 0; i < QuantPet; i++)
                {
                    Console.WriteLine("Кличка питомца {0}: {1}", i + 1, Pet[i]);
                }
            }
            else { Console.WriteLine("У Вас нет питомцев"); }
            Console.WriteLine("У Вас есть любимые цвета в количестве {0} штук", QuantFavColor);
            for (int i = 0; i < QuantFavColor; i++)
            {
                Console.WriteLine("Выш любимый цвет {0}: {1}", i + 1, FavColor[i]);
            }
        }
    }
}
