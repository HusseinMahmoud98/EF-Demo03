using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public int? ManagerId { get; set; }
        public virtual Employees Manager { get; set; }

        public virtual List<Employees> Employees { get; set; }
        
    }
}
