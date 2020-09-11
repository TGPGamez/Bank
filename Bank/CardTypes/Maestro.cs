using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CardTypes
{
    class Maestro : Card, IExpire
    {
        private string[] prefixes = { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
        
        private DateTime expireDate;
        DateTime IExpire.ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public Maestro(string bankName, string holderName) : base(bankName, "Maestro", holderName, 0, 19)
        {
            number = GenerateCardNumber(prefixes);
            regNr = "1290";
            expireDate = IExpire.MakeCardExpireDate(8, 5);
        }

        public override string ToString()
        {
            return base.ToString() + "\nExpire: " + expireDate.ToString("mm-yy").PadLeft(2, '0');
        }
    }
}
