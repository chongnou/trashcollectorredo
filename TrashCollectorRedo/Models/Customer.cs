using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorRedo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Zip { get; set; }

        public string PickUp { get; set; }

        public string OneTimePickup { get; set; }

        public string AmountDueThisMonth { get; set; }

        public string UserId { get; set; }
    }
}