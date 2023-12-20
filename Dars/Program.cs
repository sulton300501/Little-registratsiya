using System;

namespace Dars
{
    public class Program
    {
        static void Main(string[] args)
        {
       
          
            Account account1 = new Account();

            account1.Name = "user";
            account1.Age = 30;
            account1.Login = "Test";
            account1.Password = "Asdfg1@5";

            account1.PrintAccountInformation("Asdfg1@5");

            

            

           


        }
    }
}