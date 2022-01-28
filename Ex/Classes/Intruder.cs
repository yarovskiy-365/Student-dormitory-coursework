using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Intruder
    {
        [Key]
        public int Id { get; set; }
        //virtual public ICollection<Student> Student { get; set; } // студент
        public int RoomNumber { get; set; } // номер комнаты
        public DateTime DateOfIncident { get; set; } // дата происшествия
        public string Violation { get; set; } // нарушение
        public Intruder()
        {
            Student = new List<Student>();
        }
    }
}
