using System;
using System.Collections.Generic;
using System.Text;
using Bank.CardTypes;

namespace Bank
{
    public abstract class Card
    {
		#region Properties
		protected string bankName;
		protected string type;
		protected string number;
		protected string holderName;
		protected string regNr;
		protected string accountNumber;
		protected string cvv;
		protected double balance;
		protected int length;
        
        public string BankName
		{
			get { return bankName; }
			private set { bankName = value; }
		}

		public string Type
		{
			get { return type; }
			private set { type = value; }
		}

		public string Number
		{
			get { return number; }
			private set { number = value; }
		}

		public string HolderName
		{
			get { return holderName; }
			private set { holderName = value; }
		}

		public string RegNr
		{
			get { return regNr; }
			private set { regNr = value; }
		}


		public string AccountNumber
		{
			get { return accountNumber; }
			private set { accountNumber = value; }
		}

		public string Cvv
		{
			get { return cvv; }
			private set { cvv = value; }
		}

		public double Balance
		{
			get { return balance; }
			private set { balance = value; }
		}

		public int Length
		{
			get { return length; }
			private set { length = value; }
		}
		#endregion


		public Card(string bankName, string type, string holderName, double balance, int length)
		{
			this.bankName = bankName;
			this.type = type;
			this.holderName = holderName;
			this.accountNumber = GenerateAccountNumber();
			this.cvv = GenerateCvv();
			this.balance = balance;
			this.length = length;
		}

		protected string GenerateCardNumber(string[] prefixes)
		{
			Random random = new Random();
			string cardNumber = prefixes[random.Next(0, prefixes.Length)] + "-";
			for (int i = cardNumber.Length - 1; i < length; i++)
			{
				cardNumber += random.Next(0, 9);
			}
			return cardNumber;
		}

		protected string GenerateAccountNumber()
		{
			Random random = new Random();
			string cardNumber = "3520-";
			for (int i = cardNumber.Length - 1; i < 14; i++)
			{
				cardNumber += random.Next(0, 9);
			}
			return cardNumber;
		}

		protected string GenerateCvv()
		{
			Random random = new Random();
			string cvvNumber = "";
			for (int i = 0; i < 2; i++)
			{
				cvvNumber += random.Next(0, 9);
			}
			return cvvNumber;
		}

		public override string ToString()
		{
			return "Bank: " + bankName
				+ "\nName: " + holderName
				+ "\nType: " + type
				+ "\nCard Nr:" + number
				+ "\nReg.Nr: " + regNr
				+ "\nKonto Nr: " + accountNumber
				+ "\nCVV: " + cvv;
		}
	}
}
