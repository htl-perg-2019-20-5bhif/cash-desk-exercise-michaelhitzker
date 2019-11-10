using System;
using System.ComponentModel.DataAnnotations;

namespace CashDesk
{
    class Deposit : IDeposit
    {
        public int DepositId { get; set; }

        [Required]
        public Membership Membership { get; set; }

        [Required]
        public decimal Amount
        {
            get { return Amount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Amount must be greater than 0!");
                }
                Amount = value;
            }
        }

        IMembership IDeposit.Membership => Membership;
    }
}
