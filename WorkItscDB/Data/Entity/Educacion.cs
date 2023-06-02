using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItscDB.Data.Entity
{
    public class Educacion
    {
        //public int IdUsuario {get; set;} 
        public string School { get; set; }
        public string Degree { get; set; }
        public string TitleEdu { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }


    }
}
