using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapp.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public Owner Owner { get; set; }
    }


    public class mvcappContext : DbContext
    {
        public mvcappContext(DbContextOptions<mvcappContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }

}
