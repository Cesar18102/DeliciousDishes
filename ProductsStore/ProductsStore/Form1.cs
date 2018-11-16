using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;

namespace ProductsStore
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        JavaScriptSerializer serializer = new JavaScriptSerializer();

        private void Storage_Load(object sender, EventArgs e) {

            UpdateProductList();
            UpdateStoreList();
            UpdateOldProducts();

            LoadProducts();
            LoadUnits();
            LoadStoredProducts();

            if (CategoryInput.Items.Count > 0)
                CategoryInput.SelectedIndex = 0;

            if (UnitInput.Items.Count > 0)
                UnitInput.SelectedIndex = 0;

            if (StoreProductName.Items.Count > 0)
                StoreProductName.SelectedIndex = 0;
        }

        public void InsertProduct(string name, int shelfLife) {

            int id = serializer.Deserialize<List<MaxId>>(PostQuery(Constants.QueryURL, "query=SELECT MAX(id) FROM product&pas=Delishes228").Replace("MAX(id)", "id"))[0].id + 1;
            
            int CategId = serializer.Deserialize<List<MaxId>>(PostQuery(Constants.QueryURL, "query=SELECT id FROM category WHERE name = '" + CategoryInput.Items[CategoryInput.SelectedIndex].ToString() + "'&pas=Delishes228"))[0].id;
            int UnitId = serializer.Deserialize<List<MaxId>>(PostQuery(Constants.QueryURL, "query=SELECT id FROM unit WHERE name = '" + UnitInput.Items[UnitInput.SelectedIndex].ToString() + "'&pas=Delishes228"))[0].id;

            string values = "'" + id.ToString() + "','" + name + "','" + CategId + "','" + UnitId + "','" + shelfLife.ToString() + "'";

            string response = PostQuery(Constants.QueryURL, "query=INSERT INTO product VALUES(" + values + ")&pas=Delishes228");

            UpdateProductList();
        }

        public void InsertStoredProduct(string name, double count, double price, DateTime start) {

            int id = serializer.Deserialize<List<MaxId>>(PostQuery(Constants.QueryURL, "query=SELECT MAX(id) FROM storage_product&pas=Delishes228").Replace("MAX(id)", "id"))[0].id + 1;
            int productId = serializer.Deserialize<List<MaxId>>(PostQuery(Constants.QueryURL, "query=SELECT id FROM product WHERE name = '" + name + "'&pas=Delishes228"))[0].id;

            string values = "'" + id.ToString() + "','" + productId.ToString() + "','" + start.Year + "-" + start.Month + "-" + start.Day + "','" + count.ToString() + "','" + price.ToString() + "'";

            string response = PostQuery(Constants.QueryURL, "query=INSERT INTO storage_product VALUES(" + values + ")&pas=Delishes228");

            UpdateStoreList();
            UpdateOldProducts();
        }

        public void LoadStoredProducts() {

            string response = PostQuery(Constants.QueryURL, "query=SELECT name FROM product&pas=Delishes228");

            List<Product> products = serializer.Deserialize<List<Product>>(response);

            foreach (Product i in products)
                StoreProductName.Items.Add(i.name);
        }

        public void LoadProducts() {

            string response = PostQuery(Constants.QueryURL, "query=SELECT name FROM category&pas=Delishes228");

            List<Category> categories = serializer.Deserialize<List<Category>>(response);

            foreach (Category i in categories)
                CategoryInput.Items.Add(i.name);
        }

        public void LoadUnits() {

            string response = PostQuery(Constants.QueryURL, "query=SELECT name FROM unit&pas=Delishes228");

            List<Category> units = serializer.Deserialize<List<Category>>(response);

            foreach (Category i in units)
                UnitInput.Items.Add(i.name);
        }

        public void UpdateProductList() {

            productsList.Rows.Clear();

            string response = PostQuery(Constants.QueryURL, "query=SELECT P.id, P.name, U.name AS unit, C.name AS category, P.shelf_life FROM product P, unit U, category C WHERE U.id = P.unit_id AND C.id = P.category_id ORDER BY P.id ASC&pas=Delishes228");

            List<Product> products = serializer.Deserialize<List<Product>>(response);

            if (products != null)
                foreach (Product i in products) {

                    productsList.Rows.Add();
                    productsList.Rows[productsList.RowCount - 1].Cells[0].Value = i.id;
                    productsList.Rows[productsList.RowCount - 1].Cells[1].Value = i.name;
                    productsList.Rows[productsList.RowCount - 1].Cells[2].Value = i.category;
                    productsList.Rows[productsList.RowCount - 1].Cells[3].Value = i.unit;
                    productsList.Rows[productsList.RowCount - 1].Cells[4].Value = i.shelf_life;
                }
        }

        public void UpdateStoreList() {

            storeList.Rows.Clear();

            string response = PostQuery(Constants.QueryURL,
                                        "query=SELECT S.id, P.id AS product_id, P.name, (SELECT U.name FROM unit U WHERE U.id = P.unit_id) AS unit, S.made_date, S.amount, S.discrete_price FROM product P, storage_product S WHERE P.id = S.product_id&pas=Delishes228");

            List<StoreProduct> stores = serializer.Deserialize<List<StoreProduct>>(response);

            if (stores != null)
                foreach (StoreProduct i in stores) {

                    storeList.Rows.Add();
                    storeList.Rows[storeList.RowCount - 1].Cells[0].Value = i.id;
                    storeList.Rows[storeList.RowCount - 1].Cells[1].Value = i.name;
                    storeList.Rows[storeList.RowCount - 1].Cells[2].Value = i.amount;
                    storeList.Rows[storeList.RowCount - 1].Cells[3].Value = i.unit;
                    storeList.Rows[storeList.RowCount - 1].Cells[4].Value = i.discrete_price;
                    storeList.Rows[storeList.RowCount - 1].Cells[5].Value = i.made_date.ToShortDateString();
                }
        }

        public void UpdateOldProducts() {

            oldProductsList.Rows.Clear();

            for (int i = 0; i < storeList.RowCount; i++) {

                DateTime shelfStart = Convert.ToDateTime(storeList.Rows[i].Cells["ShelfStart"].Value);
                DateTime now = DateTime.Now;

                for (int j = 0; j < productsList.RowCount; j++) {

                    int shelfLife = Convert.ToInt32(productsList.Rows[j].Cells["shelfLife"].Value);

                    if (storeList.Rows[i].Cells["StoreName"].Value.ToString() == productsList.Rows[j].Cells["ProductName"].Value.ToString() &&
                        shelfStart.AddHours(shelfLife) < now) {

                        oldProductsList.Rows.Add();
                        int hours = Convert.ToInt32((shelfStart.AddHours(shelfLife) - now).TotalHours);
                        int cellCount = storeList.Rows[i].Cells.Count;

                        for (int k = 0; k < cellCount - 1; k++) {

                            storeList.Rows[i].Cells[k].Style.BackColor = Color.Red;
                            oldProductsList.Rows[oldProductsList.RowCount - 1].Cells[k].Value = storeList.Rows[i].Cells[k].Value;
                        }

                        oldProductsList.Rows[oldProductsList.RowCount - 1].Cells[cellCount - 1].Value = hours;
                        storeList.Rows[i].Cells[cellCount - 1].Style.BackColor = Color.Red;
                    }
                }
                    
            }
        }

        public string PostQuery(string PHPpath, string query) {

            string response = "";

            try {

                byte[] data = Encoding.UTF8.GetBytes(query);

                HttpWebRequest HTRQ = HttpWebRequest.CreateHttp(PHPpath);
                HTRQ.Method = "POST";
                HTRQ.ContentType = "application/x-www-form-urlencoded";
                HTRQ.ContentLength = data.Length;

                Stream strw = HTRQ.GetRequestStream();
                strw.Write(data, 0, data.Length);
                strw.Close();

                HttpWebResponse HTPR = HTRQ.GetResponse() as HttpWebResponse;
                StreamReader str = new StreamReader(HTPR.GetResponseStream());

                response = str.ReadLine();
                str.Close();
                HTPR.Close();
            }
            catch { MessageBox.Show("Отсутствует подключение к Интренет"); }

            return response == "" || response == "<!-- zzz <!--]-->" ? "{ }" : response;
        }

        private void SubmitProduct_Click(object sender, EventArgs e) {

            if(ProductNameInput.Text != "" && CategoryInput.SelectedIndex != -1 && UnitInput.SelectedIndex != -1 && ShelfLifeInput.Value > 0)
                InsertProduct(ProductNameInput.Text, Convert.ToInt32(ShelfLifeInput.Value));

            LoadStoredProducts();
        }

        private void InsertStoredButton_Click(object sender, EventArgs e) {

            if (StoreProductName.SelectedIndex != -1 && CountInput.Value > 0 && PrimalPriceInput.Value > 0)
                InsertStoredProduct(StoreProductName.Items[StoreProductName.SelectedIndex].ToString(), Convert.ToDouble(CountInput.Value), Convert.ToDouble(PrimalPriceInput.Value), ShelfStartDate.Value);
        }

        private void RemoveOldProducts_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < oldProductsList.RowCount; i++)
                PostQuery(Constants.QueryURL, "query=DELETE FROM storage_product WHERE id = " + oldProductsList.Rows[i].Cells["oldProductID"].Value + ";&pas=Delishes228");

            UpdateStoreList();
            UpdateOldProducts();
        }
    }
}
