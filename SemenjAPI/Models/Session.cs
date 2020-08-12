using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemenjAPI.Models
{
    public class Session
    {
        public Session() { }

        public Session(Guid userId, User user)
        {
            UserId = userId;
            User = user;
        }

        [Key]
        public Guid Id { get; set; } = new Guid();
        public Guid Sid { get; set; } = new Guid();
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;

    }
}
