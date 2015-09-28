﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class Tables
    {
        [Key]
        public int TableID { get; set; }

        [Required, Range(1, 25)]
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        [Range(2, 8)]
        public int Capacity { get; set; }
        public bool Available { get; set; }
        // Navigation Properties
        public virtual ICollection<Reservations> Reservations { get; set; }

        public Tables()
        {
            Available = true;
            Reservations = new HashSet<Reservations>();
        }
    }
}
