using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Classes
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int RoomNumber { get; set; } // номер комнаты
        public string InfoAboutStudents { get; set; } // информация о студенте
        public string FixedFurniture { get; set; } // закрепленная мебель с инвентарными номерами
    }
}
