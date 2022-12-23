using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFasade
{
	internal class CreditCard
	{
		public string cardOwner;
		public int limit;
		public int cardNo;

		public CreditCard(string str, int limit, int cardNo)
		{
			this.cardOwner = str;
			this.limit = limit;
			this.cardNo = cardNo;
		}
	}
}
