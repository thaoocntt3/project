﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFilm.Core.Enitites.Order
{
    public class OrderDTO
    {
        public int productID { get; set; }
        public int productDetailID { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
    }
}
