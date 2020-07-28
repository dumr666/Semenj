using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Semenj.Models;

namespace Semenj.Models
{
    public class User
    {
        public User() { }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public float Ratimg { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public Guid HomesteadId { get; set; }
        public Homestead Homestead { get; set; }
        public List<Product> Products { get; set; }
    }
}
