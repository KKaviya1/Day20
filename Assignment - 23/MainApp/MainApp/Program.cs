using System;
using MySharedLibrary;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userManagement = new UserManagementModule();
           
            Console.Write("Enter an email address:\n \t ");
            string email = Console.ReadLine();

            if (userManagement.IsValidEmail(email))
            {
                Console.WriteLine("Email is valid!!");
            }
            else
            {
                Console.WriteLine("Invalid email!!");
            }

            Console.ReadKey();
        }
    }
    public class UserManagementModule
    {
        private DataValidation validator;

        public UserManagementModule()
        {
            validator = new DataValidation();
        }

        public bool IsValidEmail(string email)
        {
            return validator.IsValidEmail(email);
        }
    }

}
