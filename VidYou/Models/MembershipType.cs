﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidYou.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }
    }
}