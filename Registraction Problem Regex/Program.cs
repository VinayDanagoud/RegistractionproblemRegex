﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To USER Registration Program. ");
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName();
            userRegistration.LastName();
            userRegistration.Email();
            userRegistration.MobileNumber();
            userRegistration.Password();
        }
    }
}