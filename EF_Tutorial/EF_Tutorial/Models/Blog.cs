﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class Blog
    {
        public int Id { get; set; }
        
        public string? Url { get; set; }
    }
}