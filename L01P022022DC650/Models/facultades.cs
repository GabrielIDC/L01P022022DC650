﻿using System.ComponentModel.DataAnnotations;

namespace L01P022022DC650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }
    }
}
