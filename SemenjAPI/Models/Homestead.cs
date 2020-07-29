using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Models
{
    public class Homestead
    {
        // Empty constructor -> EF
        public Homestead() { }

        public Homestead(string name, string address, int postCode, string city, string webPageAddress, float rating, List<User> users, List<User> admins, List<Product> products)
        {
            Name = name;
            Address = address;
            PostCode = postCode;
            City = city;
            WebPageAddress = webPageAddress;
            Rating = rating;
            Users = users;
            Admins = admins;
            Products = products;
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string WebPageAddress { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public float Rating { get; set; }
        public List<User> Users { get; set; }
        public List<User> Admins { get; set; }
        public List<Product> Products { get; set; }


    }
}
