using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarCourse.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSubscribeToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}