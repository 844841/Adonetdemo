using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adonetdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SuprajaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string insertquery = "insert into Department(Did,Dname) values("+"'104'"+","+"'IT')";
                try
                {

                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    cmd.ExecuteNonQuery();

                    SqlDataReader datared = cmd.ExecuteReader();


                    while (datared.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                            datared[0], datared[1], datared[2],datared[3]);
                    }
                    datared.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
        }
    }
}
