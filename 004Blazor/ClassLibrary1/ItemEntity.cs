using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ItemEntity
    {
        [Key]
        [StringLength(50)]
        public string ItemId { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        [Required]
        public string ItemName { get; set; }

        [MaxLength(200)]
        [Required]
        public string ItemDescription { get; set; }
        public int TotalQuantity { get; set; }
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        public ICollection<StorageEntity> Storages { get; set; }

    }
}
