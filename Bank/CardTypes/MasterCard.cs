using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CardTypes
{
    class MasterCard : Card, IExpire
    {
        private string[] prefixes = { "4026", "417500", "4508", "4844", "4913", "4917" };

        private DateTime expireDate;
        DateTime IExpire.ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public MasterCard(string bankName, string holderName) : base(bankName, "MasterCard", holderName, 0, 19)
        {
            number = GenerateCardNumber(prefixes);
            regNr = "6942";
            expireDate = IExpire.MakeCardExpireDate(8, 5);
        }

        public override string ToString()
        {
            return base.ToString() + "\nExpire: " + expireDate.ToString("mm-yy").PadLeft(2, '0');
        }
    }
}
