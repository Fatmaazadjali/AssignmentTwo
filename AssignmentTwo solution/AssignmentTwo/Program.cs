using System.ComponentModel;

namespace AssignmentTwo
{
	 class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to the Inventory Management System!");
			Console.WriteLine("Please enter your username:");
			Console.ReadLine();
			Console.WriteLine("Please enter your password:");
			Console.ReadLine();
			string UserName = "admin";
			string Password = "adminpass";
			if (UserName == "admin" && Password == "adminpass")
			{
				Console.WriteLine(" Authentication successful!");
			} else
			{
				Console.WriteLine("Incorrect username or password!");
			}
			string[] options = new string[7];
			options[0] = "Add a new product";
			options[1] = "Update product quantity";
			options[2] = "Display product list";
			options[3] = "Record sale";
			options[4] = "Generate product report";
			options[5] = "Generate sales report";
			options[6] = "Exit";
			Console.WriteLine("Select an operation");

			//for (string option =  options[0]; option != null;)
			//{
			//	Console.WriteLine(option);
			//}

			Console.WriteLine($"{options[0]}" + $"{options[1]}" + $"{options[2]}" + $"{options[3]}" + $"{options[4]}"+ $"{options[5]}"+ $"{options[6]}");






		}
	}
}