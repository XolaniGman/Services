using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDC_MVC.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        public string Fullnames { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string HighestGrade { get; set; }
        public Boolean hasQualification { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateAccepted { get; set; }
        public byte[] ID_Document { get; set; }
        public byte[] Qualification { get; set; }
        public byte[] CV { get; set; }
        public byte[] OtherQualification { get; set; }
    }
}
