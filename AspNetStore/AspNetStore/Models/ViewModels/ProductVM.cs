﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AspNetStore.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
