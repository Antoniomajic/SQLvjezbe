﻿using System.ComponentModel.DataAnnotations;

namespace MassageParlor.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
