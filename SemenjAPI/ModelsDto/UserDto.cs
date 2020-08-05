﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.ModelsDto
{
    public class UserDto
    {
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
        public string Error { get; set; }
    }
}
