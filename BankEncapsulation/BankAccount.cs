using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
        
        public BankAccount()
		{
		}

        private double balance = 0.0;


        public void Deposit(double deposit)
		{
			balance += deposit;
		}

		public double GetBalance()
		{
			return balance;
		}
	}
}
/*
\
In your BankAccount class, create the following:

Define a method named Deposit that will accept a double and store that value in the balance field
Define a method named GetBalance that will return the amount stored in the balance field
Allow the user of the application to Deposit money and retrieve their balance through the console.
*/