﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMovie.Models.ViewModels.Home
{
    public class IndexVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products{ get; set; }
    }
}
