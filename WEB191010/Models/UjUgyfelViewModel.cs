﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class UjUgyfelViewModel
    {
        public Ugyfel Ugyfel { get; set; }
        public IEnumerable<ElofizetesTipus> ElofizetesTipusok { get; set; }
    }
}