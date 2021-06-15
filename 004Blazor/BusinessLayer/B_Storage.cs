using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BusinessLayer
{
    public class B_Storage
    {


        public bool IsProductInWarehouse(string itemId, string warehouseId)
        {
            using (var dbContext = new InventoryContext())
            {
                var item = dbContext.Storages.ToList().Where(storage => storage.ItemId == itemId && storage.WarehouseId == warehouseId);
                return item.Any();
            }
        }

        public List<StorageEntity> StorageList()
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Storages.ToList();
            }

        }
        public List<StorageEntity> StorageListByWarehouse(string warehouseId)
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Storages
                    .Include(s => s.Item)
                    .Include(s => s.Warehouse)
                    .Where(store => store.WarehouseId == warehouseId)
                    .ToList();
            }

        }


        public void CreateStorage(StorageEntity Storage)
        {
            using (var dbContext = new InventoryContext())
            {
                //Insert
                dbContext.Storages.Add(Storage);
                //Commit
                dbContext.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity Storage)
        {
            using (var dbContext = new InventoryContext())
            {
                //Update: EF will automatically check which entry will be updated.
                dbContext.Storages.Update(Storage);
                //Commit
                dbContext.SaveChanges();
            }
        }
    }
}
