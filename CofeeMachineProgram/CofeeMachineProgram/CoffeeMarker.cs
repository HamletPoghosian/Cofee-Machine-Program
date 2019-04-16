using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeMachineProgram
{
    public enum CoffeeNumber
    {
        Americano = 1,
        Latte = 2,
        Cappuccino = 3,
        Espresso = 4,
        Macchiato = 5,
        Vienna = 6,
        Affogato = 7,
        Doppio = 8,
        Ristretto = 9,
        Maccoffee = 10
    }
    public class CoffeeMarker
    {
        public CoffeeNumber CoffeeType { get; set; }
        public CoffeeMarker(int coffenumber)
        {
            CoffeeType = (CoffeeNumber)coffenumber;
        }

    }
}
