using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreFinalTest.Models
{
   
    public class Owner
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}




