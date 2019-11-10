using System;
using System.ComponentModel.DataAnnotations;

namespace CashDesk
{
    class Membership : IMembership
    {
        public int MembershipId { get; set; }

        [Required]
        public Member Member { get; set; }

        [Required]
        public DateTime Begin { get; set; }

        public DateTime End
        {
            get { return End; }
            set
            {
                if (value <= Begin)
                {
                    throw new ArgumentException("End must be later than begin");
                }
                End = value;
            }
        }
        IMember IMembership.Member => Member;
    }
}
