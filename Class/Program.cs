namespace Class
{
    class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string[] districts;

        public void SetCityName(string name)
        {
            cityName = name;
        }

        public void SetCountryName(string name)
        {
            countryName = name;
        }

        public void SetPopulation(int pop)
        {
            population = pop;
        }

        public void SetPhoneCode(string code)
        {
            phoneCode = code;
        }

        public void SetDistricts(string[] dist)
        {
            districts = dist;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public int GetPopulation()
        {
            return population;
        }

        public string GetPhoneCode()
        {
            return phoneCode;
        }

        public string[] GetDistricts()
        {
            return districts;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"City: {cityName}");
            Console.WriteLine($"Country: {countryName}");
            Console.WriteLine($"Population: {population}");
            Console.WriteLine($"Phone Code: {phoneCode}");
            Console.WriteLine("Districts:");
            foreach (var district in districts)
            {
                Console.WriteLine($"- {district}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("City Example:");
            City city = new City();
            city.SetCityName("New York");
            city.SetCountryName("USA");
            city.SetPopulation(8400000);
            city.SetPhoneCode("+1-212");
            city.SetDistricts(new string[] { "Manhattan", "Brooklyn", "Queens" });
            city.DisplayInfo();
        }
    }
}
