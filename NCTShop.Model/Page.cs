using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCTShop.Model
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public string Content { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}