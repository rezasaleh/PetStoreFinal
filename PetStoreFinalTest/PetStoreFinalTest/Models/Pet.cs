using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreFinalTest.Models
{
    public enum Breed
    {
        Dog, Cat, Fish, Hamster, Guinea, Pig
    }
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public int OwnerID { get; set; }
        public Breed Breed { get; set; }
        
        public Owner Owner { get; set; }
    }
}


