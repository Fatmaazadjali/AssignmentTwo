using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

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
			options[0] = "1.Add a new product";
			options[1] = "2.Update product quantity";
			options[2] = "3.Display product list";
			options[3] = "4.Record sale";
			options[4] = "5.Generate product report";
			options[5] = "6.Generate sales report";
			options[6] = "7.Exit";
			Console.WriteLine("\nSelect an operation");


			//for (string option =  options[0]; option != null;)
			//{
			//	Console.WriteLine(option);
			//}

			Console.WriteLine($"1.{options[0]}" + $"\n{options[1]}" + $"\n{options[2]}" + $"\n{options[3]}" + $"\n {options[4]}"+ $"\n {options[5]}"+ $"\n {options[6]}");

			Console.ReadLine();
			string[] productInfo = new string[3];
			Console.WriteLine("Enter product name ");

			productInfo[0] = Console.ReadLine();
			Console.WriteLine("Enter product price:");
			productInfo[1] = Console.ReadLine();
			Console.WriteLine("Enter initial quantity:");
			productInfo[2] = Console.ReadLine();
			Console.WriteLine("Product added successfully!");
            Console.WriteLine("Select an operation" );
			Console.ReadLine();

			string UserCoise= options[3];
			if ( UserCoise == options[3])
			{
                Console.WriteLine("Enter product name:");
				productInfo[0] = Console.ReadLine();
                Console.WriteLine("Enter quantity sold:");
				productInfo[1] = Console.ReadLine();
                Console.WriteLine("Sale recorded successfully!");
            }
            Console.WriteLine("Select an operation");
            Console.ReadLine();
			string userchice = options[2];
			if (userchice == options[2])
			{
				Console.WriteLine($" Product List:{productInfo} ");

			}




			//int price = Convert.ToInt32(Console.ReadLine());

			//	int quantity = Convert.ToInt32(Console.ReadLine());


		}

			
		
	



		
		}
	}

	
