﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}