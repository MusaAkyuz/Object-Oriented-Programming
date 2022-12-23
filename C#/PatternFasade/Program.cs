namespace PatternFasade
{
	class Program
	{
		public static void Main(string[] args) 
		{
			Customer cus1 = new Customer("Musa", "Akyüz");
			Customer cus2 = new Customer("Yadikar", "Akyüz");
			CardManager cm = new CardManager();
			cm.CreateCreditCard(cus1);

			Console.WriteLine(cus1.crd.cardOwner);
		}
	}
}