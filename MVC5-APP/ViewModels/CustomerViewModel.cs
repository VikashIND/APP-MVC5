using MVC5_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_APP.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}