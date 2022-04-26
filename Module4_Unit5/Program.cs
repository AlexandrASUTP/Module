using System;

namespace Module4_Unit5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Lastname, string Login, int LoginLenght, bool HasPet, double Age, string[] color)  user;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите имя");
                user.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                user.Lastname = Console.ReadLine();
                Console.WriteLine("Введите логин");
                user.Login = Console.ReadLine();
                user.LoginLenght = user.Login.Length;
                Console.WriteLine("Длина логина {0}", user.LoginLenght);
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    user.HasPet = true;
                }
                else
                {
                    user.HasPet = false;
                }
                Console.WriteLine("Введите возраст пользователя");
                user.Age = double.Parse(Console.ReadLine());
                user.color = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < user.color.Length - 1; i++)
                {
                    user.color[i] = Console.ReadLine();
                }
            }

        }
    }
}
