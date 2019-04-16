using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CofeeMachineProgram
{
    public class CoffeeResurs
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

                    string resurs = "2000,1000,3000";

                    File.WriteAllText(ResursTxtfile, resurs);
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
        public void CreatFinishResurs(int[] resurs)
        {
           
            
            
        }

        public void ResursPourMachin(string ResursTxtfile)
        {
            int [] resurs=new int [3] ;
            string resultString = string.Empty;
            int temp = 0;
            try
            {
                using (StreamReader streamr = new StreamReader(ResursTxtfile))
                {

                    string line = streamr.ReadToEnd();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i]>='0'&& line[i]<='9')
                        {
                            resultString += line[i];
                        }
                        if (line[i] == ','||i==line.Length-1)
                        {
                            resurs[temp] = int.Parse(resultString);
                            temp++;
                            resultString = string.Empty;
                        }
                            //resultString += Regex.Match(line, @"\d+").Value;
                    }

                    
                    Console.WriteLine(resurs);
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
