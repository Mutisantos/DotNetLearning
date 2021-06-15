using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        [Required]
        public string CategoryName { get; set; }

        public ICollection<ItemEntity> Items { get; set; }

    }
}
