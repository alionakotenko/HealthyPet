using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyPet.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private ApplicationDBContext _db;

        public PetsController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpPost]
        public void Add([FromBody] Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
        }

        [HttpGet]
        public List<Pet> Get()
        {
            return _db.Pets.ToList();
        }

        [HttpGet("{id}")]
        public Pet GetById(Guid id)
        {
            return _db.Pets.FirstOrDefault(x => x.Id == id);
        }

        [HttpPut]
        public void Update(Pet pet)
        {
            var current_pet = _db.Pets.FirstOrDefault(x => x.Id == pet.Id);
            if (current_pet != null)
            {
                current_pet.PetName = pet.PetName;
                current_pet.PetType = pet.PetType;
                _db.SaveChanges();
            }  
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var pet = _db.Pets.FirstOrDefault(x => x.Id == id);
            _db.Pets.Remove(pet);
            _db.SaveChanges();
        }
    }
}
