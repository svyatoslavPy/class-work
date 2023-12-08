namespace App;

public class City
{
    public string nameCity = string.Empty;
    public string nameRegion = string.Empty;
    public string nameCountry = string.Empty;
    public string countPeopleInCity = string.Empty;
    public int postalCode = 0;
    public int cityPhoneCode = 0;


    public City (
        string city, 
        string region, 
        string country, 
        string count,
        int code,
        int phoneCode
        )
    {
        this.nameCity = city;
        this.nameRegion = region;
        this.nameCountry = country;
        this.countPeopleInCity = count;
        this.postalCode = code;
        this.cityPhoneCode = phoneCode;
    }


    public void showInfo()
    {
        Console.WriteLine("Information: ");
        Console.WriteLine($"City: {nameCity}");
        Console.WriteLine($"Region: {nameRegion}");
        Console.WriteLine($"Country: {nameCountry}");
        Console.WriteLine($"Count: {countPeopleInCity}");
        Console.WriteLine($"Postal code: {postalCode}");
        Console.WriteLine($"City phone code: {cityPhoneCode}");
    }
}