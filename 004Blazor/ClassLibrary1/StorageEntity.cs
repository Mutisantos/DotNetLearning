using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemId { get; set; }
        public ItemEntity Item { get; set; }

        [StringLength(50)]
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }
        public ICollection<InOutEntity> InOuts { get; set; }

    }
}
