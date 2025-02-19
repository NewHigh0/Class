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

            Console.WriteLine("Employee Example:");
            Employee employee = new Employee();
            employee.SetFullName("John Smith");
            employee.SetBirthDate(new DateTime(1990, 5, 15));
            employee.SetPhoneNumber("+1-555-0123");
            employee.SetWorkEmail("john.smith@company.com");
            employee.SetPosition("Software Developer");
            employee.SetJobDescription("Developing and maintaining software applications");
            employee.DisplayInfo();
        }
    }
}
