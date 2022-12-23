using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFasade
{
	internal class Customer
	{
		public string firsName;
		public string lastName;
		public CreditCard crd;

		public Customer(string firsName, string lastName)
		{
			this.firsName = firsName;
			this.lastName = lastName;
		}
	}
}
