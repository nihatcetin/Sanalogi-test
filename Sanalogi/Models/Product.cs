﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sanalogi.Models
{
    public class Product
    {
        [Key]
        public int ProducyId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
