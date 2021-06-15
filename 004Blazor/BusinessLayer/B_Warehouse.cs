using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class B_Warehouse
    {

        public List<WarehouseEntity> WarehouseList()
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Warehouses.ToList();
            }

        }


        public void CreateWarehouse(WarehouseEntity warehouse)
        {
            using (var dbContext = new InventoryContext())
            {
                //Insert
                dbContext.Warehouses.Add(warehouse);
                //Commit
                dbContext.SaveChanges();
            }
        }

        public void UpdateWarehouse(WarehouseEntity warehouse)
        {
            using (var dbContext = new InventoryContext())
            {
                //Update: EF will automatically check which entry will be updated.
                dbContext.Warehouses.Update(warehouse);
                //Commit
                dbContext.SaveChanges();
            }
        }
    }
}
