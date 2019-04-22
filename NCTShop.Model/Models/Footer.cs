﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCTShop.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}