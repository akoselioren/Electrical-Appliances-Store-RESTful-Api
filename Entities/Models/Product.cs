﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
