using System;

namespace Module4_Unit4
{
    class Program
    {
        static void Main(string[] args)
        {
			(string name, int age, string day) anketa;
		
			//-----------------------------
			Console.Write("What is your name? ");
			anketa.name = Console.ReadLine();
			Console.WriteLine("Your name is: {0}", anketa.name);
			//-----------------------------
			Console.Write("What is your age? ");
			anketa.age = int.Parse(Console.ReadLine());
			Console.WriteLine("Your age is: {0}", anketa.age);
			//-----------------------------
			Console.WriteLine("Your name is {0} and age is {1}", anketa.name, anketa.age);
			//-----------------------------
			Console.Write("What is your birtheday? ");
			anketa.day = Console.ReadLine();
			Console.WriteLine("Your birtheday is {0}", anketa.day);
			Console.ReadKey();
		}
    }
}
