using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BEZAOPayDAL;


namespace BEZAOPay
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["BEZAOConnect"].ConnectionString;

            var db = new BEZAODAL(connectionString);

            //var users = db.GetAllUsers();

            //foreach (var user in users)
            //{
            //    Console.WriteLine($"Id: {user.Id}\nName: {user.Name}\nEmail: {user.Email}");
            //}


            //Console.WriteLine(db.LookUpNameById(74));

            db.CreateUser("Akunana", "akunana@domain.com");

            int id = db.GetUserId("Akunana");

            if (id != 0)
                db.CreateAccount(id, 2342143, 344909234.99);
            else
            {
                Console.WriteLine("Invalid Name, Please try again");
            }
            
        }
    }
}
