using System.Collections.Generic;
using Vidly2.Models;

namespace Vidly2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> Membershiptypes { get; set; }
        public Customer Customer { get; set; }

    }
}