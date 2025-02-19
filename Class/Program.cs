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

    class Employee
    {
        private string fullName;
        private DateTime birthDate;
        private string phoneNumber;
        private string workEmail;
        private string position;
        private string jobDescription;

        public void SetFullName(string name)
        {
            fullName = name;
        }

        public void SetBirthDate(DateTime date)
        {
            birthDate = date;
        }

        public void SetPhoneNumber(string phone)
        {
            phoneNumber = phone;
        }

        public void SetWorkEmail(string email)
        {
            workEmail = email;
        }

        public void SetPosition(string pos)
        {
            position = pos;
        }

        public void SetJobDescription(string description)
        {
            jobDescription = description;
        }
        public string GetFullName()
        {
            return fullName;
        }

        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public string GetWorkEmail()
        {
            return workEmail;
        }

        public string GetPosition()
        {
            return position;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Work Email: {workEmail}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Job Description: {jobDescription}");
        }
    }

    class Airplane
    {
        private string name;
        private string manufacturer;
        private int yearOfManufacture;
        private string type;
        public Airplane()
        {
            name = "Unknown";
            manufacturer = "Unknown";
            yearOfManufacture = 0;
            type = "Unknown";
        }

        public Airplane(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            yearOfManufacture = 0;
            type = "Unknown";
        }

        public Airplane(string name, string manufacturer, int year, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = year;
            this.type = type;
        }
        public void SetData(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
        }

        public void SetData(string name, string manufacturer, int year)
        {
            SetData(name, manufacturer);
            this.yearOfManufacture = year;
        }

        public void SetData(string name, string manufacturer, int year, string type)
        {
            SetData(name, manufacturer, year);
            this.type = type;
        }

        public string GetName()
        {
            return name;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public int GetYearOfManufacture()
        {
            return yearOfManufacture;
        }

        public string GetType()
        {
            return type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Aircraft Name: {name}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Year of Manufacture: {yearOfManufacture}");
            Console.WriteLine($"Type: {type}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("City Example:");
            //City city = new City();
            //city.SetCityName("New York");
            //city.SetCountryName("USA");
            //city.SetPopulation(8400000);
            //city.SetPhoneCode("+1-212");
            //city.SetDistricts(new string[] { "Manhattan", "Brooklyn", "Queens" });
            //city.DisplayInfo();

            //Console.WriteLine("Employee Example:");
            //Employee employee = new Employee();
            //employee.SetFullName("John Smith");
            //employee.SetBirthDate(new DateTime(1990, 5, 15));
            //employee.SetPhoneNumber("+1-555-0123");
            //employee.SetWorkEmail("john.smith@company.com");
            //employee.SetPosition("Software Developer");
            //employee.SetJobDescription("Developing and maintaining software applications");
            //employee.DisplayInfo();

            Console.WriteLine("Airplane Examples:");
            Airplane airplane1 = new Airplane();
            Airplane airplane2 = new Airplane("Boeing 747", "Boeing");
            Airplane airplane3 = new Airplane("Airbus A380", "Airbus", 2020, "Commercial");

            Console.WriteLine("Airplane 1 (Default Constructor):");
            airplane1.DisplayInfo();

            Console.WriteLine("\nAirplane 2 (Partial Constructor):");
            airplane2.DisplayInfo();

            Console.WriteLine("\nAirplane 3 (Full Constructor):");
            airplane3.DisplayInfo();

            Console.WriteLine("\nAirplane 1 (After SetData):");
            airplane1.SetData("Cessna 172", "Cessna", 2022, "Private");
            airplane1.DisplayInfo();
        }
    }
}
