﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagment.Models
{
    public class Developer
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }


        public Developer() // default constructor
        {

        }
    }
}
