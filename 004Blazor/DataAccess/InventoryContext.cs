using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext:DbContext
    {
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity > Storages { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Create a connection link
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=Inventory;User Id=sa;Password=3Mangoplumo!!;");
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Armaduras" },
                new CategoryEntity { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Armas" },
                new CategoryEntity { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Accesorios" },
                new CategoryEntity { CategoryId = Guid.NewGuid().ToString(), CategoryName = "Secundarias" }
            );


            builder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Main Warehouse",
                    WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540"
                },
                new WarehouseEntity {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "North Warehouse",
                    WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540"
                },
                new WarehouseEntity {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Omega Warehouse",
                    WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540"
                }
            );
        }
    }
}
