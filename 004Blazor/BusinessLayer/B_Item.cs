using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class B_Item
    {
        public List<ItemEntity> ItemList()
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Items.ToList();
            }

        }
        public ItemEntity ItemById(string id)
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Items.ToList().LastOrDefault(p => p.ItemId == id);
            }

        }


        public void CreateItem(ItemEntity Item)
        {
            using (var dbContext = new InventoryContext())
            {
                //Insert
                dbContext.Items.Add(Item);
                //Commit
                dbContext.SaveChanges();
            }
        }

        public void UpdateItem(ItemEntity Item)
        {
            using (var dbContext = new InventoryContext())
            {
                //Update: EF will automatically check which entry will be updated.
                dbContext.Items.Update(Item);
                //Commit
                dbContext.SaveChanges();
            }
        }
    }
}
