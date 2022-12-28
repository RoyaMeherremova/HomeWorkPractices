using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    internal class AccountController
    {
        public void Login()
        {

            Console.WriteLine("Add email:");
            string email = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();

            int roleId = 1;

            AccountService accountService = new AccountService();

            var result = accountService.Login(email, password, roleId);
            Console.WriteLine(result);
 


        }
    }
}
