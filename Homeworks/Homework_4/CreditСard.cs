namespace Homework_4
{
	public class CreditСard
	{
		private double Money { get; set; }
		private int CVV { get; set; }

		public CreditСard(double money, int cvv)
		{
			Money = money;
			CVV = cvv;
		}

		public static double operator +(CreditСard creditСard, double money) => creditСard.Money + money;

		public static double operator -(CreditСard creditСard, double money) => creditСard.Money - money;

        public static bool operator ==(CreditСard creditСard, int cvv) => creditСard.CVV == cvv;

        public static bool operator !=(CreditСard creditСard, int cvv) => creditСard.CVV != cvv;

        public static bool operator >(CreditСard creditСard, double money) => creditСard.Money > money;

        public static bool operator <(CreditСard creditСard, double money) => creditСard.Money < money;

        public override bool Equals(object obj)
		{
            if (obj == null || !(obj is CreditСard))
                return false;

            CreditСard сard = (CreditСard)obj;
            return сard != null && Money == сard.Money && CVV == сard.CVV;
        }

        public override int GetHashCode() => HashCode.Combine(Money, CVV);

        public void PrintInfo() => Console.WriteLine($"Credit Card have money: {Money}\nCVV: {CVV}");
    }
}

