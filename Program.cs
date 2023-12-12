
using System.Text.RegularExpressions;
namespace App
{
    class Regular
    {

        static void Main(string[] args)
        {
            Console.WriteLine("OOP");

            string[] cityNames = { "Odessa", "Kharkov" };
                   
            var city = new City("Одесса", "Одесская область", "Ukraine",  "1 010 537", 65037, 048);
            city.showInfo();
            Console.WriteLine("--------------");
            var country = new Country("Украина", "Европа", "43,79 млн", 380, "Kyiv", cityNames);
            country.showInfo();
        }
    }
}