using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeMachineProgram
{
    public class DBforMachin
    {
        // private string conectonString = @"Server=(LocalDB)\MSSQLLocalDB;Database=CoffeeResurs;Trusted_Connection=True;MultipleActiveResultSets=true;";
        private string conectonString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\InnoUser10\Source\Repos\Coffee.Machine.Program\CofeeMachineProgram\CofeeMachineProgram\CoffeeResurs.mdf;Integrated Security=True;Connect Timeout=30";
        public DBforMachin()
        {

        }
        public void InsertDBResurs(int[] resurs)
        {
            if (resurs != null)

            {
                try
                {
                    using (SqlConnection openCon = new SqlConnection(conectonString))
                    {
                        string saveResurs = "INSERT INTO [Table] VALUES (@Id,@Coffee,@Whater,@Sugar)";

                        using (SqlCommand querySaveResurs = new SqlCommand(saveResurs, openCon))
                        {
                            openCon.Open();
                            querySaveResurs.Parameters.Add(new SqlParameter("Id", 1));
                            querySaveResurs.Parameters.Add(new SqlParameter("Coffee", resurs[0]));
                            querySaveResurs.Parameters.Add(new SqlParameter("Whater", resurs[1]));
                            querySaveResurs.Parameters.Add(new SqlParameter("Sugar", resurs[2]));
                            querySaveResurs.ExecuteNonQuery();
                            openCon.Close();

                        }
                    }
                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("Not Resurs");
                }
                catch (InvalidCastException)
                {

                    Console.WriteLine("Not Resurs");
                }
                catch (InvalidOperationException)
                {

                    Console.WriteLine("Not Resurs");
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine("Not Resurs");
                }
                catch (SqlException)
                {

                    Console.WriteLine("Not Resurs");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                Console.WriteLine("Dont Working Coffee Machine");
            }


        }

        public int[] SelectDBResurs()
        {
            int[] resurs = new int[3];
            using (SqlConnection connection = new SqlConnection(conectonString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT  Coffee,Whater,Sugar FROM [Table]", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                        reader.Read();
                        resurs[0] = int.Parse(reader[0].ToString());
                        resurs[1] = int.Parse(reader[1].ToString());
                        resurs[2] = int.Parse(reader[2].ToString());               
                    
                }
            }
            return resurs;
            
        }
    }
}


