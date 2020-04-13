using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace mvcapp.Models {
    public class PetsContext : DbContext {
        public PetsContext(DbContextOptions<PetsContext> options): base(options) {

        }
        public DbSet<Owner> Owners{get;set;}
        public DbSet<Pet> Pets {get;set;}
    }

    public class Owner {
        public int OwnerId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string email {get;set;}
        public List<Pet> Pets{get;set;}
    }

    public class Pet{
        public int PetId{get;set;}
        public string Name {get;set;}
        public int OwnerId {get;set;}
        public Owner Owner {get;set;}
    }
}