using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        public BankAccount(string owner )
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot able to deposite" + amount;
            if (amount > 2000) 
                return "you crossed the maximum limit";

            Balance += amount;
            return "deposited completedd successfully";
        }
        public string WithDrawl(decimal amount)
        {
            if (amount <= 0)
                return "You cannot able to withdrawl" + amount;
            if (amount > 2000)
                return "you dont  have enough money";

            Balance -= amount;
            return "withdrawl completedd successfully";
        }

    }
}
