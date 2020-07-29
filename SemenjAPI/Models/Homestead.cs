using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Models
{
    public class Homestead
    {
        public Homestead() { }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public int City { get; set; }
        public string WebPageAddress { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public float Rating { get; set; }
        public List<User> Users { get; set; }
        public List<User> Admins { get; set; }
        public List<Product> Products { get; set; }


    }
}
