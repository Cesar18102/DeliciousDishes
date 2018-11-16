using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookTable {

    public class Meal {

        public int id;
        public int menu_id;
        public int amount;
        public string name;
        public double weight;
        public string state;
        public int state_id;
        public string reciepe;

        public List<Product> products;

        public void SetProducts() {

            products = Server.Deserialize<List<Product>>(Server.PostQuery(Constants.QueryURL, "query=SELECT U.id, P.name, TRUNCATE(U.amount, 3) AS amount, (SELECT UN.name FROM unit UN WHERE UN.id = P.unit_id) AS unit FROM used_product U, product P, storage_product STP WHERE U.storage_product_id = STP.id AND STP.product_id = P.id AND U.offered_meal_id = " + id + "&pas=Delishes228"));
        }
    }
}
