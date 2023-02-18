using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class CarRental
    {
        [Required(ErrorMessage = "Please input customer id")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "Please input car id")]
        public string CarId { get; set; }

        [Required(ErrorMessage = "Please input pickup date")]
        public DateTime PickupDate { get; set; }

        [Required(ErrorMessage = "Please input return date")]
        public DateTime ReturnDate { get; set; }

        [Required(ErrorMessage = "Please input rent price")]
        public decimal? RentPrice { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
