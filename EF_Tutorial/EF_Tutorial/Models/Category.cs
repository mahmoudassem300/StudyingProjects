using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
