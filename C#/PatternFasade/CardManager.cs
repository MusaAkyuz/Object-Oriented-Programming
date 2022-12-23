using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFasade
{
	internal class CardManager
	{
		public void CreateCreditCard(Customer customer)
		{
			CreditCard c1 = new CreditCard(customer.firsName, 1000, 123);
			customer.crd = c1;
		}
	}
}
