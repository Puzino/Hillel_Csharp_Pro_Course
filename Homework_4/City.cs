using System;
namespace Homework_4
{
	public class City
	{
		private int People { get; set; }

		public City(int people)
		{
			if (people < 0)
				throw new ArgumentException("City must have more people than 0.");
			People = people;
		}

		public static int operator +(City c1, City c2) => c1.People + c2.People;

        public static int operator -(City c1, City c2) => c1.People - c2.People;

        public static bool operator ==(City c1, City c2) => c1.People == c2.People;

        public static bool operator !=(City c1, City c2) => c1.People != c2.People;

        public static bool operator >(City c1, City c2) => c1.People > c2.People;

        public static bool operator <(City c1, City c2) => c1.People < c2.People;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is City))
                return false;

            City city = (City)obj;
            return city != null && People == city.People;
        }

        public override int GetHashCode() => HashCode.Combine(People);

        public void PrintPeople() => Console.WriteLine(People);
    }
}

