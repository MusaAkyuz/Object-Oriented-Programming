using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFasade
{
	
	internal class CreditCardFacade
	{	
		public void CreateCreditCard(Customer customer)
		{
			CardManager cm = new CardManager();
			BlackListService bs = new BlackListService();
			if (bs.checkBlackList(customer, ))
			{
				CreditCard c1 = new CreditCard(customer.firsName, 1000, 123);
				customer.crd = c1;
			}
			else
			{
				Console.WriteLine("User in blacklist");
			}
			
		}
	}
}
