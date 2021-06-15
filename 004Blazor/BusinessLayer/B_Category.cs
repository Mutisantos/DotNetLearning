using System;
using System.Collections.Generic;
using Entities;
using DataAccess;
using System.Linq;

namespace BusinessLayer
{
    public class B_Category
    {
        public List<CategoryEntity> CategoryList()
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.Categories.ToList();
            }

        }


        public void CreateCategory(CategoryEntity newCategory)
        {
            using (var dbContext = new InventoryContext())
            {
                //Insert
                dbContext.Categories.Add(newCategory);
                //Commit
                dbContext.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity currentCategory)
        {
            using (var dbContext = new InventoryContext())
            {
                //Update: EF will automatically check which entry will be updated.
                dbContext.Categories.Update(currentCategory);
                //Commit
                dbContext.SaveChanges();
            }
        }
    }
}
