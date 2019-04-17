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
            int myCoin = 0;
            bool isThrow = true;
            int[] resursCoffeeMachin=new int[3];
            CoffeeResurs cofRes = new CoffeeResurs();
            string resursfFileValue=cofRes.CreatResurs();
            int[] resursForFile=  cofRes.ResursPourMachin(resursfFileValue);
            DBforMachin dbForMachin = new DBforMachin();
            dbForMachin.InsertDBResurs(resursForFile);

            resursCoffeeMachin= dbForMachin.SelectDBResurs();
            foreach (int res in resursCoffeeMachin)
            {
                if (res < 50)
                {
                    Console.WriteLine("You dont  buy Coffe");
                }
            }

            Console.Write("Please throw a coin. \nYou can only throw (50, 100, 200, 500) coins \nAnd  then Enter 0 and select Coffee type \n");
            while (isThrow)
            {
                Console.WriteLine("Please throw your coin");
                try
                {
                    coin = int.Parse(Console.ReadLine());
                    switch (coin)
                    {
                        case 0:
                            {

                                Console.WriteLine("You have {0} coin", myCoin);
                                isThrow = false;
                                break;
                            }
                        case 50:
                            {
                                myCoin += 50;
                                Console.WriteLine("You have {0} coin", myCoin);
                                break;
                            }
                        case 100:
                            {
                                myCoin += 100;
                                Console.WriteLine("You have {0} coin", myCoin);
                                break;
                            }
                        case 200:
                            {
                                myCoin += 200;
                                Console.WriteLine("You have {0} coin", myCoin);
                                break;
                            }
                        case 500:
                            {
                                myCoin += 500;
                                Console.WriteLine("You have {0} coin", myCoin);
                                break;
                            }
                        default:
                            {
                                Console.Write("Please throw a coin. \nYou can only throw (50, 100, 200, 500) coins Or Enter 0 and select Coffee Type \n");
                                break;
                            }
                    }
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine("Please enter coin or Enter 0 and select Coffee");
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter 50,100,200 and 500 or Enter 0 and select Coffee");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            Console.WriteLine("Please enter Coffee number ");
            Console.Write(@"This is Coffee type and their prices 
1.Americano    50 (: 10 water, 10 sugar, 10 coffee)
2.Latte        100 (: 10 water, 20 sugar, 10 coffee)
3.Cappuccino   250 (: 10 water, 20 sugar, 20 coffee)
4.Espresso     300 (: 20 water, 10 sugar, 20 coffee)
5.Macchiato    450 (: 20 water, 20 sugar, 20 coffee)
6.Vienna       550 (: 30 water, 10 sugar, 40 coffee)
7.Affogato     700 (: 40 water, 40 sugar, 40 coffee)
8.Doppio       800 (: 20 water, 50 sugar, 50 coffee)
9.Ristretto    900 (: 50 water, 50 sugar, 30 coffee)
10.Maccoffee   1000(: 50 water, 50 sugar, 50 coffee)");
            Console.WriteLine();
            bool selectCoffe = true;
            int coffeeType = 0;
            Console.WriteLine("Enter Coffee  number");
            while (selectCoffe)
            {
                try
                {
                    if (myCoin < 50)
                    {
                        selectCoffe = false;
                        Console.WriteLine("Your many end ");
                        break;
                    }
                    coffeeType = int.Parse(Console.ReadLine());
                    if (coffeeType >= 1 && coffeeType <= 10)
                    {
                        CoffeeMarker cofMarker = new CoffeeMarker(coffeeType);
                        Console.WriteLine(cofMarker.CoffeeType);
                    }
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine("1-10 number");
                }
                catch (FormatException)
                {

                    Console.WriteLine("1-10 number");
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }

}

