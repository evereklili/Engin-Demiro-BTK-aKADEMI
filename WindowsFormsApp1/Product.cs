using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
       //namespace bizim gruplama tekniği olarak kullanılır. 
       //en önemli kurual; tabloya karşılık gelen bir class olmasıdır. biz entity framework 
       //bizim bir klasımız var sql şuraya karşılık gelmektedir. Context(UnitifWork) tasarım deseninini çağırırız. 

    }
}
