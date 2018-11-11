using HealthyPet.Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyPet.Api.Entities
{
    public class Pet
    {
        public Guid Id { get; set; }
        public PetType PetType { get; set; }
        public string PetName { get; set; }
    }
}
