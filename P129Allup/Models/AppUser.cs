﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P129Allup.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string SurName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        [StringLength(255)]
        public string ConnectionId { get; set; }
        public Nullable<DateTime> ConnectedAt { get; set; }
        public List<Basket> Baskets { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
