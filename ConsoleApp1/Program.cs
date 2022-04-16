using System;

class MainClass
{
    public static void Main(string[] args)
    {
		Console.Write("What is your name? ");
		var name = Console.ReadLine();
		Console.WriteLine("Your name is: {0}", name);
		//-----------------------------
		Console.Write("What is your age? ");
		var age = checked((byte)int.Parse(Console.ReadLine()));
		Console.WriteLine("Your age is: {0}", age);
		//-----------------------------
		Console.WriteLine("Your name is {0} and age is {1}", name, age);
		//-----------------------------
		Console.Write("What is your birtheday? ");
		var day = Console.ReadLine();
		Console.WriteLine("Your birtheday is {0}", day);
	}
}
