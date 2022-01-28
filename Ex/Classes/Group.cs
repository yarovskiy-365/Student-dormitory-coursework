using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // название группы
        public string Year { get; set; } // год/курс
        public Group()
        {
            Students = new List<Student>();
        }
    }
}
