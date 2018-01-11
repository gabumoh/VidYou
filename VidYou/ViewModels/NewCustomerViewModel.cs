using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidYou.Models;

namespace VidYou.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}