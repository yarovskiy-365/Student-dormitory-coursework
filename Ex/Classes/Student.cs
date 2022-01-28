using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; } // пол
        public string Address { get; set; } // местро проживания
        public string Phone { get; set; } // номер телефона
        public DateTime DateOfBirth { get; set; } // дата рождения
        public int Course { get; set; } // курс
        public string Photo { get; set; } // путь к фото
        virtual public ICollection<Parent> Parents { get; set; }
        public int GropId { get; set; }
        public int FacultyId { get; set; }
        public int RoomId { get; set; }
        virtual public ICollection<Intruder> Intruders { get; set; }

        //virtual public ICollection<Faculty> Faculty { get; set; } // факультет
        //virtual public ICollection<Group> Group { get; set; } // группа
    }
}
