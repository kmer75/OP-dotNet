﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChoixResto.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string Prenom { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}
