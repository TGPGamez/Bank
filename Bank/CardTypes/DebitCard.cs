using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.CardTypes
{
    class DebitCard : Card
    {
        private string[] prefixes = { "2400" };

        public DebitCard(string bankName, int balance, string holderName) 
            : base(bankName, "DebitCard", holderName, 0, 16)
        {
            number = GenerateCardNumber(prefixes);
            regNr = "3478";
        }
    }
}
