using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class BlogImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required, MaxLength(250)]
        public string Caption { get; set; }
        public int BlogFK { get; set; }
        public Blog Blog { get; set; }
    }
}
