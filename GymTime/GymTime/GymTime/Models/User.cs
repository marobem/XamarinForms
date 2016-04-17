using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Models
{
    public class User
    {
        //precisa referencia ao sqlite para essa linha abaixo
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int GymId { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastAccess { get; set; }
        //public bool Facebook { get; set; }

        public override string ToString()
        {
            return Name;
            //return string.Format("Nome={0}, Email={1}, Nascimento={2}", Name, Login, Birth);
        }
    }
}
