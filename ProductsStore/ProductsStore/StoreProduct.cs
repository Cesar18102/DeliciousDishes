using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStore
{
    public class StoreProduct {

        public int id;
        public int product_id;
        public string name;
        public string unit;
        public DateTime made_date;
        public double amount;
        public double discrete_price;

        public StoreProduct() { }
    }
}
