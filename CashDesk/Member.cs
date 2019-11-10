using System;
using System.ComponentModel.DataAnnotations;

namespace CashDesk
{
    class Member : IMember
    {
        [Key]
        [Required]
        public int MemberNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}
