using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
