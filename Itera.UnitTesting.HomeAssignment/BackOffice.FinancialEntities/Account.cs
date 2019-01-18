using System;

namespace BackOffice.FinancialEntities
{
    public class Account
    {
        // Constructor to set the default value of Balance
        public Account()
        {
            Balance = 0.0m; // decimal format in C#
        }

        // Constructor to set initialt value of Balance
        public Account(decimal initialAmount)
        {
            Balance = initialAmount;
        }

        // Creates a property that allows the value to be retrieved from outside the class, but can only be set from within
        public decimal Balance { get; private set; }

        public bool WithdrawFunds(decimal amount)
        {
            if (Balance < amount)
                return false;

            Balance -= amount;
            return true;
        }

        public void DepositFunds(decimal deposit)
        {
            if (deposit <= 0)
                throw new ArgumentOutOfRangeException(nameof(deposit), "Deposit amount should be positive");

            Balance += deposit;
        }
    }
}