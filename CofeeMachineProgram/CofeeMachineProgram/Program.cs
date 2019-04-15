using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeMachineProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			int coin = 0;
		    int mycoin=0;
			Console.Write("Please throw a coin. \nYou can only throw (50, 100, 200, 500) coins \n");
			Console.Write("This is Coffee type and their prices \n1-coffe = 100  \n2-maccofe  = 200 \n3-strong coffe = 450 \n");
			Console.WriteLine("Please throw your coin or Enter 0 and  select Coffee");

			while (true)
			{
				try
				{
					coin = int.Parse(Console.ReadLine());
					switch (coin)
					{
						case 50:
							{
								mycoin += 50;
								Console.WriteLine("You have {0} coin", mycoin);
								break;
							}
						case 100:
							{
								mycoin += 100;
								Console.WriteLine("You have {0} coin", mycoin);
								break;
							}
						case 200:
							{
								mycoin += 200;
								Console.WriteLine("You have {0} coin", mycoin);
								break;
							}
						case 500:
							{
								mycoin += 500;
								Console.WriteLine("You have {0} coin", mycoin);
								break;
							}
						default:
							{
								Console.Write("Please throw a coin. \nYou can only throw (50, 100, 200, 500) coins \n");
								break;
							}
					}
				}
				catch (ArgumentNullException)
				{

					Console.WriteLine("Please enter coin");
				}
				catch (FormatException )
				{

					Console.WriteLine("Please enter 50,100,200 and 500 ");
				}				
				catch (Exception)
				{

					throw;
				}
				
			}

		}
	}
}
