using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CardTypes
{
    public class Dankort : Card, IExpire
    {
        private string[] prefixes = { "4" };

        private DateTime expireDate;
        DateTime IExpire.ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public Dankort(string bankName, string holderName) : base(bankName, "Dankort", holderName, 0, 19)
        {
            number = GenerateCardNumber(prefixes);
            regNr = "8902";
            expireDate = IExpire.MakeCardExpireDate(8, 5);
        }

        public override string ToString()
        {
            return base.ToString() + "\nExpire: " + expireDate.ToString("mm-yy").PadLeft(2, '0');
        }
    }
}
