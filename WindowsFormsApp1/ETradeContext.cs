using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ETradeContext: System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; }


    }
}
