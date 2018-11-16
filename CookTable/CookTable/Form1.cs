using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookTable
{
    public partial class Cooker : Form
    {
        public Cooker()
        {
            InitializeComponent();
        }

        private List<Offer> offers;

        private void Cooker_Load(object sender, EventArgs e) {

            UpdateOffers(UpdateProgress);
            UpdateTimer.Start();
            ProgressTimer.Start();
        }

        public void UpdateOffers(ProgressBar PB) {

            PB.Value = 0;
            offeredmeals.Rows.Clear();
            offers = GetOffers(UpdateProgress);

            for (int i = 0; i < offers.Count; i++)
                for (int j = 0; j < offers[i].meals.Count; j++) {

                    offeredmeals.Rows.Add();
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["ID"].Value = offers[i].id;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["SubOfferId"].Value = offers[i].meals[j].id;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["MealId"].Value = offers[i].meals[j].menu_id;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["MealName"].Value = offers[i].meals[j].name;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["MealCount"].Value = offers[i].meals[j].amount;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["MealWeight"].Value = offers[i].meals[j].weight;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["Start"].Value = offers[i].date;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["TimeSpent"].Value = Convert.ToInt32((DateTime.Now - offers[i].date).TotalMinutes);
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["Comment"].Value = offers[i].comment;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["Reciepe"].Value = "Перейти к рецепту";

                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["CookStart"].Value = offers[i].meals[j].state_id >= 2;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["State"].Value = offers[i].meals[j].state_id >= 3;

                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["OfferIdHidden"].Value = i;
                    offeredmeals.Rows[offeredmeals.RowCount - 1].Cells["OfferedMealIdHidden"].Value = j;
                }
            PB.Value = 100;
        }

        public List<Offer> GetOffers(ProgressBar PB) {

            List<Offer> offers = Server.Deserialize<List<Offer>>(Server.PostQuery(Constants.QueryURL, "query=SELECT id, date, comment FROM offer ORDER BY offer.date ASC&pas=Delishes228"));

            int delta = 100 / (offers.Count + 3);
            PB.Value += delta;

            foreach (Offer offer in offers) {

                offer.SetMeals();
                PB.Value += delta;
            }

            return offers;
        }

        private void offeredmeals_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            switch (e.ColumnIndex) {

                case 9:
                    DataGridViewRow row = offeredmeals.Rows[e.RowIndex];
                    LoadReciepe(offers[Convert.ToInt32(row.Cells["OfferIdHidden"].Value)].meals[Convert.ToInt32(row.Cells["OfferedMealIdHidden"].Value)]);
                    break;

                case 10:
                    if (Convert.ToBoolean(offeredmeals.Rows[e.RowIndex].Cells[10].EditedFormattedValue)) {

                        if (Server.Deserialize<List<Count>>(Server.PostQuery(Constants.QueryURL, "query=SELECT COUNT(id) FROM offered_meal WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 1&pas=Delishes228").Replace("COUNT(id)", "count"))[0].count == 0) {

                            offeredmeals.Rows[e.RowIndex].Cells["CookStart"].Value = false;
                            MessageBox.Show("Уже готовится!!! Заказ не принят!!!");
                        }
                        else {

                            Server.PostQuery(Constants.QueryURL, "query=UPDATE offered_meal SET state_id = 2 WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 1&pas=Delishes228");
                            MessageBox.Show("Заказ принят!!!");
                        }
                    }
                    else {

                        if (Convert.ToBoolean(offeredmeals.Rows[e.RowIndex].Cells["State"].EditedFormattedValue))
                            MessageBox.Show("Невозможно отклонить заказ: уже готово!");
                        else {

                            Server.PostQuery(Constants.QueryURL, "query=UPDATE offered_meal SET state_id = 1 WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 2&pas=Delishes228");
                            MessageBox.Show("Вы отклонили заказ!!!");
                        }
                    }
                    break;

                case 11:
                    if (Convert.ToBoolean(offeredmeals.Rows[e.RowIndex].Cells[11].EditedFormattedValue)) {

                        if (Server.Deserialize<List<Count>>(Server.PostQuery(Constants.QueryURL, "query=SELECT COUNT(id) FROM offered_meal WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 2&pas=Delishes228").Replace("COUNT(id)", "count"))[0].count == 0)
                        {

                            offeredmeals.Rows[e.RowIndex].Cells["State"].Value = false;
                            MessageBox.Show("Вы не приняли заказ!!!");
                        }
                        else {

                            Server.PostQuery(Constants.QueryURL, "query=UPDATE offered_meal SET state_id = 3 WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 2&pas=Delishes228");
                            MessageBox.Show("Хорошая работа!!!");
                        }
                    }
                    else {

                        Server.PostQuery(Constants.QueryURL, "query=UPDATE offered_meal SET state_id = 2 WHERE id = " + offeredmeals.Rows[e.RowIndex].Cells["SubOfferId"].Value + " AND state_id = 3&pas=Delishes228");
                        MessageBox.Show("Вы отменили готовность заказа!!!");
                    }
                    break;
            }
        }

        public void LoadReciepe(Meal meal) {

            string message = meal.reciepe;
            foreach (Product i in meal.products) {

                message = message.Substring(0, message.IndexOf("%a")) + (Convert.ToDouble(i.amount) / meal.amount).ToString() + message.Substring(message.IndexOf("%a") + 2);
                message = message.Substring(0, message.IndexOf("%u")) + i.unit + message.Substring(message.IndexOf("%u") + 2);
                message = message.Substring(0, message.IndexOf("%p")) + i.name + message.Substring(message.IndexOf("%p") + 2);
            }
            MessageBox.Show(message + ".\n В количестве " + meal.amount + " порций.", "Рецепт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e) {

            Update();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e) {

            int seconds = Convert.ToInt32(TimeLabel.Text) - 1;

            UpdateProgress.Value = 5 * seconds / 3;
            TimeLabel.Text = seconds.ToString();
        }

        private void ForceUpdate_Click(object sender, EventArgs e) {

            Update();
        }

        private void Update() {

            ProgressTimer.Stop();
            UpdateBarLabel.Text = "Обновление";
            TimeLabel.Visible = false;

            UpdateOffers(UpdateProgress);

            UpdateBarLabel.Text = "До обновления";
            TimeLabel.Visible = true;
            TimeLabel.Text = "60";
            ProgressTimer.Start();
        }
    }
}
