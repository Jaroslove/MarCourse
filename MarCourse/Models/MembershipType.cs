﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarCourse.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingUpFree { get; set; }
        public byte DurationInMonth { get; set; }
        public  byte DiscountRate { get; set; }
        public string Name { get; set; }
    }
}