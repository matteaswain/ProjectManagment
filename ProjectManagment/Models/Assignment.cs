using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagment.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        [Required]
        public int DeveloperId { get; set; }

        [Required]
        public int ProjectId { get; set; }


        public virtual Developer developer { get; set; }

        public virtual Project  project { get; set; }


        public Assignment() // default constructor
        {

        }
    }
}
