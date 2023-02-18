using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class Customer
    {
        public Customer()
        {
            CarRentals = new HashSet<CarRental>();
            Reviews = new HashSet<Review>();
        }

        [Required(ErrorMessage ="Please input customer id")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "Please input customer name")]
        public string CustomerName { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please input mobile")]
        public string Mobile { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please input customer email")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Please input customer password")]
        public string CustomerPassword { get; set; }

        [Required(ErrorMessage = "Please input identity card")]
        public string IdentityCard { get; set; }

        [Required(ErrorMessage = "Please input licence number")]
        public string LicenceNumber { get; set; }

        [Required(ErrorMessage = "Please input licence date")]
        public DateTime? LicenceDate { get; set; }

        public virtual ICollection<CarRental> CarRentals { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
