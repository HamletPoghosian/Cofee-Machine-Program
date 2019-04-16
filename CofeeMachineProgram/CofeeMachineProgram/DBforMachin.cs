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
        private string conectonString = @"Server=(LocalDB)\MSSQLLocalDB;Database=CoffeeResurs;Trusted_Connection=True;MultipleActiveResultSets=true;";
        public DBforMachin()
        {

        }
        public void InsertDBResurs(int[] resurs)
        {
            using (SqlConnection openCon = new SqlConnection(conectonString))
            {
                string saveResurs = "INSERT INTO [Table] (Coffee,Whater,Sugar) VALUES ('" + resurs[0] + "','" + resurs[1] + "','" + resurs[2] + "')";

                using (SqlCommand querySaveResurs = new SqlCommand(saveResurs))
                {
                    querySaveResurs.Connection = openCon;
                    openCon.Open();
                    querySaveResurs.ExecuteNonQuery();
                    openCon.Close();

                }
            }

        }
    }
}
