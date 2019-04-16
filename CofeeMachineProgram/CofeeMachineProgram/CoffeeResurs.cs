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
            string ResursTxtfile = path + @"\Resurs.txt"; 

            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    
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
            return ResursTxtfile;
        }
        public void CreatFinishResurs(int wather,int sugar,int coffee)
        {

        }

        public void ResursPourMachin(string ResursTxtfile)
        {
          
            try
            {   
                using (StreamReader streamr = new StreamReader(ResursTxtfile))
                {
                    
                    string line = streamr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
