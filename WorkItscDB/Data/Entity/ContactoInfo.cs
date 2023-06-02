using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItscDB.Data.Entity
{
    public class ContactoInformacion
    {
        //public int IdUsuario { get; set; }
        //public int IdEmpresa { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; } //puede ser link de nav
        public string Address { get; set; }

    }
}
