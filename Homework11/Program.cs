
using MyNamespace;

City Dnepro = new("Dnepro","Dnepropetrovska oblast","Ukraine", 966400,"54001",123);
City Kiyv = new("Kiyv", "Kiyvska oblast", "Ukraine", 2884000, "01001", 44);

Country Ukraine = new("Ukraine", "Europe", 38000000, 123, Kiyv);
Ukraine.AddCity(Dnepro);

Ukraine.printCities();

namespace MyNamespace
{
	public class City
    {
        private string _name;
        private string _region;
        private string _country;
        private string _index;
        private int _phoneCode;

        private int _people;

		public City(string Name,string Region,string Country,int People,string index,int PhoneCode)
		{
			_name = Name;
			_region = Region;
			_country = Country;
			_people = People;
			_index = index;
            _phoneCode = PhoneCode;
		}

		public string getName() => _name;
        public string getRegion() => _region;
        public string getCountry() => _country;
        public int getPeopleCount() => _people;
        public int getPhoneCode() => _phoneCode;
        public string getIndex() => _index;
    }

    public class Country
    {
        private string _name;
        private string _continent;

        private int _people;
        private int _phoneCode;

        private City _capital;
        private List<City> _cities;

        public Country(string Name,string Continent,int People,int PhoneCode,City Capital)
        {
            _name = Name;
            _continent = Continent;
            _people = People;
            _phoneCode = PhoneCode;
            _capital = Capital;
            _cities = new List<City>();
            _cities.Add(Capital);
        }

        public string getName() => _name;
        public string getContinent() => _continent;
        public int getPhoneCode() => _phoneCode;
        public City getCapitalCity() => _capital;
        public int getPeopleCount() => _people;
        public void AddCity(City city) => _cities.Add(city);
        public void printCities()
        {
            foreach (City item in _cities)
            {
                Console.WriteLine(item.getName());
            }
        }
    }
}

