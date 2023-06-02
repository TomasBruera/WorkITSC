using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkITSC.Shared.DTOs
{
    public class EmpleoDTO
    {
        public int IdEmpresa { get; set; }

        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string EmploymentType { get; set; }
        
        public int ExperienceLevel { get; set; }
        [Required]
        public DateTime PostedDate { get; set; }

        public string Foto { get; set; }
    }
}
