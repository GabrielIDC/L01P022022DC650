﻿using System.ComponentModel.DataAnnotations;
namespace L01P022022DC650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        public string departamento { get; set; }
    }
}
