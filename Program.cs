
using System.Text.RegularExpressions;
namespace App
{
    class Regular
    {

        static void Main(string[] args)
        {
            // task 1
            string phone = "380957081753";
            Regex regex = new Regex(@"^(\d{12})$");

            if (regex.Match(phone).Success)
            {
                Console.WriteLine("good phone");
            }
            else
            {
                Console.WriteLine("bad phone");
            }

            Console.WriteLine("--------------");
            // mobile phone 
            string phone1 = "380957081753";
            Regex regexMobilePhone = new Regex(@"^([+]?\d{12})$");

            if (regexMobilePhone.Match(phone1).Success)
            {
                Console.WriteLine("This good mobile phone");
            }
            else
            {
                Console.WriteLine("This bad mobile phone");
            }

            
            // email

            string myEmail = "svyatoslav@gmail.com";

            Regex regexEmail = new Regex(@"^([a-z A-Z 0-9_]+[@][a-z]+[.]+[a-z]+$)"); //

            if (regexEmail.Match(myEmail).Success)
            {
                Console.WriteLine("Good email");
            }
            else
            {
                Console.WriteLine("Bad email");
            }

            string fullName = "Svyatoslav Sergeyevich";
            Regex regexFullName = new Regex(@"^([A-Z][a-z]{1,29}[ ]+[A-Z][a-z]{1,29})$");
            

            if (regexFullName.Match(fullName).Success)
            {
                Console.WriteLine("Good fullname");
            }
            else
            {
                Console.WriteLine("Bad fullname");
            }

        }
    }
}