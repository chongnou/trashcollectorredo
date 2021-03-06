﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorRedo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Zip { get; set; }

        public string FilterCustomer { get; set; }

        public string ConfirmPickup { get; set; }

        public string ConfirmCharge { get; set; }

        public string UserId { get; set; }
    }
}