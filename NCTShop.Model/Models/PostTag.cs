﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCTShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}