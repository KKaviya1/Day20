using System;

namespace MySharedLibrary
{
    public class DataValidation
    {
        public bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

    }
}
