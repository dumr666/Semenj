﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Models
{
    public class User
    {
        // Empty constructor -> EF
        public User() { }
        public User(string name, string surname, string username, string password,
            string emailAddress, string phoneNumber, string mobileNumber, 
            string address, int postCode, string city, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Password = password;
            Username = username;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            MobileNumber = mobileNumber;
            Address = address;
            PostCode = postCode;
            City = city;
            BirthDate = birthDate;
        }


        [Key]
        public Guid Id { get; set; } = new Guid();
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
        public float Rating { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public List<Product> Products { get; set; }
        public Guid SessionId { get; set; }
        public Session Session { get; set; }
    }
}
