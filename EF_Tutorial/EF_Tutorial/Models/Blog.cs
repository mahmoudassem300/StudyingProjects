using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class Blog
    {
        public int Id { get; set; }
        
        public string? Url { get; set; }
        public DateTime AddedOn { get; set; } // Neglected in ApplicationDbContext.cs (modelBuilder)
        public DateTime CreateDate { get; set; }
        public int Rating { get; set; }       
        public List<Post> Posts{ get; set; }
    }
}
