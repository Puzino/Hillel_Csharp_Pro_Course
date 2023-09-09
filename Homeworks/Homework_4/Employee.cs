namespace Homework_4
{
	public class Employee
	{

		private double Salary { get; set; }

        public Employee(double salary)
        {
            Salary = salary;
        }

		public static double operator +(Employee employee, double append) => employee.Salary + append;

        public static double operator -(Employee employee, double subtract) => employee.Salary - subtract;

        public static bool operator ==(Employee employee, double sum) => employee.Salary == sum;

        public static bool operator !=(Employee employee, double sum) => employee.Salary != sum;

        public static bool operator >(Employee employee, double sum) => employee.Salary > sum;

        public static bool operator <(Employee employee, double sum) => employee.Salary < sum;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            Employee employee = (Employee)obj;
            return employee != null && Salary == employee.Salary;
        }

        public override int GetHashCode() => HashCode.Combine(Salary);

        public void PrintSalary() => Console.WriteLine(Salary);
    }
}

