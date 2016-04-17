using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Models
{
    public class Gym
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime WeekDayOpening { get; set; }
        public DateTime WeekDayClosing { get; set; }
        public DateTime SaturdayOpening { get; set; }
        public DateTime SaturdayClosing { get; set; }
        public DateTime SundayOpening { get; set; }
        public DateTime SundayClosing { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FacebookPage { get; set; }
        public string Photo { get; set; }

        //public bool Facebook { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Name;
            //return string.Format("Nome={0}, Email={1}, Nascimento={2}", Name, Login, Birth);
        }
    }
}
