using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookTable {

    public class Offer {

        public int id;
        public DateTime date;
        public string comment;

        public List<Meal> meals;

        public void SetMeals() {

            meals = Server.Deserialize<List<Meal>>(Server.PostQuery(Constants.QueryURL, "query=SELECT DISTINCT OM.id, MN.id AS menu_id, OM.amount, MN.weight, ML.name, OM.state_id, R.rtext AS reciepe, (SELECT S.name FROM state S WHERE S.id = OM.state_id) AS state FROM reciepe R, offered_meal OM, menu MN, meal ML WHERE R.meal_id = ML.id AND OM.menu_id = MN.id AND ML.id = MN.meal_id AND OM.offer_id =" + id + " AND OM.state_id <= 2&pas=Delishes228"));

            foreach (Meal meal in meals)
                meal.SetProducts();
        }
    }
}
