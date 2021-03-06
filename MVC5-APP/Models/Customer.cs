﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_APP.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribeToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name ="Membership Type")]
        [Required]
        public byte MembershipTypeId { get; set; }
    }
}