# Cofee Machine Program
## Program that presents Coffee devices
![coffeemachin](https://sc02.alicdn.com/kf/HTB15Mtqo5CYBuNkHFCcq6AHtVXak/Coffee-Machine-Fruit-Powder-Mixer-Maker-Vending.jpg)
#### The device accepts only 50 100 200 and 500 cents 
#### If you throw another coin, the device will not accept it and will warn you about it. When you finish , you need to insert 0 and select the type of caffee.
![coffeemachi](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcShRBQVW3rtr_y_Ytgk0P_IYZYsNswOerAn9DkAEeGelgXkYcQI)
```csharp
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
```

#### There are 10 types of Caffee . Which are prepared from the following resources:
- Americano    50 (: 10 water, 10 sugar, 10 coffee)
- Latte        100 (: 10 water, 20 sugar, 10 coffee)
- Cappuccino   250 (: 10 water, 20 sugar, 20 coffee)
- Espresso     300 (: 20 water, 10 sugar, 20 coffee)
- Macchiato    450 (: 20 water, 20 sugar, 20 coffee)
- Vienna       550 (: 30 water, 10 sugar, 40 coffee)
- Affogato     700 (: 40 water, 40 sugar, 40 coffee)
- Doppio       800 (: 20 water, 50 sugar, 50 coffee)
- Ristretto    900 (: 50 water, 50 sugar, 30 coffee)
- Maccoffee   1000(: 50 water, 50 sugar, 50 coffee)

#### When you choose the type of Caffee, checks whether your money meets the price of caffeine and there are enough resources available on your device,
