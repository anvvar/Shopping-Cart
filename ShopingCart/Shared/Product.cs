﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool Ispublic { get; set; }
        public bool Isdeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime Datecreated { get; set; } = DateTime.Now;
        public DateTime Dateupdated { get; set; }
    }
}
