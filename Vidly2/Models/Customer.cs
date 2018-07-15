using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MemberShipType { get; set; }  // Navigation property
        public byte MembershipTypeId { get; set; }  //For performance, so that we can load foreigh key only instead of the whole object
    }
}