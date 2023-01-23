using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Group_Project.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string NativeLanguage { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoIdType { get; set; }
        public string PhotoIdNumber { get; set; }
        public DateTime PhotoIdIssueDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int? PostalCode { get; set; }
        public string Country { get; set; }
        public string LandlineNumber { get; set; }
        public string MobileNumber { get; set; }

    }
}