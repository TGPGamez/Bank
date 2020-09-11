using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface IExpire
    {
        public DateTime ExpireDate { get; protected set; }
		static protected DateTime MakeCardExpireDate(int month, int year)
		{
			DateTime dateTime = DateTime.Now;
			dateTime = dateTime.AddYears(year);
			dateTime = dateTime.AddMonths(month);
			return dateTime;
		}
	}
}
