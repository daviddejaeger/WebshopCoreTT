﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopCoreTT.Models.Domain
{
    public class CartItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
