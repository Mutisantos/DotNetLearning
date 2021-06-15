using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class B_InOut
    {
        public List<InOutEntity> InOutList()
        {
            //Using in the middle of the code will provide a code that will only live between the brackets of it.
            //Connections and threads will be shutdown once the using is finished
            using (var dbContext = new InventoryContext())
            {
                return dbContext.InOuts.ToList();
            }

        }


        public void CreateInOut(InOutEntity InOut)
        {
            using (var dbContext = new InventoryContext())
            {
                //Insert
                dbContext.InOuts.Add(InOut);
                //Commit
                dbContext.SaveChanges();
            }
        }

        public void UpdateInOut(InOutEntity InOut)
        {
            using (var dbContext = new InventoryContext())
            {
                //Update: EF will automatically check which entry will be updated.
                dbContext.InOuts.Update(InOut);
                //Commit
                dbContext.SaveChanges();
            }
        }
    }
}
