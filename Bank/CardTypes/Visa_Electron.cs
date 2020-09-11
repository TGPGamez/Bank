using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CardTypes
{
    class Visa_Electron : Card, IExpire
    {
        private string[] prefixes = { "4026", "417500", "4508", "4844", "4913", "4917" };

        private DateTime expireDate;
        DateTime IExpire.ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        public Visa_Electron(string bankName, string holderName) : base(bankName, "Visa_E", holderName, 0, 19)
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
