using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars
{
  public class Account
    {
        private string _name;
        private string _password;
        private string _login;
        private int _age;


        public string Login
        {
             private get
            {
                Console.WriteLine();
                return _login;
            }
            set
            {
                if (value.Length > 3)
                {
                    _login = value;
                }
                else
                {
                    Console.WriteLine("Login uzunligi 3 tadan uzun bolsin...");

                }
                
            }
        }

        

        public string Password
        {
            private get
            {
                return _password;
            }
            set
            {
                if (value.Length > 7 && value.Any(char.IsDigit) &&
                    value.Any(char.IsUpper) &&
                    value.Any(char.IsLower) &&
                    value.Any(char.IsPunctuation))

                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password is not valid....");
                }
            }
        }

        public string Name
        {
             private get
            {
                return _name;
            }
            set
            {
                if (value.All(char.IsLetter))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name is not valid...");
                }
            }
        }

        public int Age
        {
           private get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Something is error...");
                }



            }

           


        }

        public void PrintAccountInformation(string password)
        {
            if (Password == password)
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
                Console.WriteLine(Login);
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("ishlamadi0");
            }
        }


    }




}

