using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeMachineProgram
{
   public  class CoffeeResurs
    {
        public CoffeeResurs()
        {

        }
        public string CreatResurs()
        {
            string newFile = "CoffeeResurs";

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), newFile);

            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    string ResursTxtfile = path + @"\Resurs.txt";
                    string resurs = "Coffee 1000 ,Whater 1000 ,Sugar 1000";
                   
                    File.WriteAllText(ResursTxtfile,resurs );
                    return ResursTxtfile;
                }
                catch (IOException ie)
                {
                    Console.WriteLine("IO Error: " + ie.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("General Error: " + e.Message);
                    throw;
                }

            }
            return " ";
        }
        public void CreatResurs(int wather,int sugar,int coffee)
        {

        }

        public void ResursPourMachin(string ResursTxtfile)
        {
            string[] lines = File.ReadAllLines(ResursTxtfile);
            foreach (var item in lines)
            {
                
            }
        }
    }
}
