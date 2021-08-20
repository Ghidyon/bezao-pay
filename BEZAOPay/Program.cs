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

            var users = db.GetAllUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id}\nName: {user.Name}\nEmail: {user.Email}");
            }

            db.CreateUserAndPopulateAccount("Buju", "buju@domain.com", 234214334, 3449092.99);

        }
    }
}
