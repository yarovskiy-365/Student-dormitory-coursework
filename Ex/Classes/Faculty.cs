using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // название факультета
        public string Building { get; set; } // корпус
        public Faculty()
        {
            Students = new List<Student>();
        }
    }
}
