using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string KinshipStatus { get; set; } // статус родителя
        public string Address { get; set; } // место проживания
        public string Phone { get; set; } // номер телефона
        public string PlaceWork { get; set; } // место работы
        public int StudentId { get; set; }
        virtual public Student Student { get; set; } // Ребёнок
        public Parent()
        {
            
        }
    }
}
