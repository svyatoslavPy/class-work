namespace App;

public class Country
{
    public string nameCountry = string.Empty;
    public string nameContinent = string.Empty;
    public string countPeopleInCountry = string.Empty;
    public int phoneCodeCounty = 0;
    public string nameCapitalCity = string.Empty;
    public string[] cityName = Array.Empty<string>();

    public Country(
        string country, 
        string continent, 
        string count, 
        int phoneCode,
        string capitalCity,
        string[] cityNames
        )
    {
        this.nameCountry = country;
        this.nameContinent = continent;
        this.countPeopleInCountry = count;
        this.phoneCodeCounty = phoneCode;
        this.nameCapitalCity = capitalCity;
        this.cityName = cityNames;

    }

    public void showInfo()
    {
        Console.WriteLine("Information: ");
        Console.WriteLine($"Country: {nameCountry}");
        Console.WriteLine($"Continent: {nameContinent}");
        Console.WriteLine($"Count people: {countPeopleInCountry}");
        Console.WriteLine($"Phone code: {phoneCodeCounty}");
        Console.WriteLine($"Capital city: {nameCapitalCity}");

        if (this.cityName.Length > 0)
        {
            Console.WriteLine($"Citys: ");
        }

        foreach (var citys in cityName)
        {
            Console.WriteLine(citys);
        }
    }
}