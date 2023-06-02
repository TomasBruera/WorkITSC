using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItscDB.Data.Entity
{
    public class PerfilUsuario
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage = "El NOMBRE es Obligatorio")]
        [MaxLength(50, ErrorMessage = "Solo se aceptan hasta 50 caracteres en el NOMBRE")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El APELLIDO es Obligatorio")]
        [MaxLength(50, ErrorMessage = "Solo se aceptan hasta 50 caracteres en el APELLIDO")]
        public string Surname { get; set; }

        [MaxLength(150, ErrorMessage = "Solo se aceptan hasta 150 caracteres en el LOCATION")]
        public string Location { get; set; }


        public string ProfilePicture { get; set; }


        [MaxLength(150, ErrorMessage = "Solo se aceptan hasta 150 caracteres en el EDUCATION")]
        public string Education { get; set; }

        [MaxLength(150, ErrorMessage = "Solo se aceptan hasta 150 caracteres en el WORKEXPERINCE")]
        public string WorkExperience { get; set; }

        [MaxLength(150, ErrorMessage = "Solo se aceptan hasta 150 caracteres en el WORKEXPERINCE")]
        public string Skills { get; set; }

        public string Foto { get; set; }


    }
}
