using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_progect
{
    
    public partial class Form4_update : Form
    {
        public Form4_update()
        {
            InitializeComponent();
        }
        string dataname = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        Data_progect newDatabase = new Data_progect();
        private void button_update_Click(object sender, EventArgs e)
        {
            string databaseName = "project.db";

            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            var SQLCommand_update = " ";
            if ((textBox_kontragent.Text).Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\" where Rem_karta ={textBox_remkarta.Text};";
            }
            if (textBox_baraban.Text.Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set Baraban = \"{textBox_baraban.Text}\" where Rem_karta = {textBox_remkarta.Text};";
            }

            if (textBox_Value_.Text.Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set Value_ = \"{textBox_Value_.Text}\" where Rem_karta ={textBox_remkarta.Text};";
            }

            if (textBox_Price.Text.Length != 0)
            {
                decimal tmp_price = decimal.Parse(textBox_Price.Text);
                SQLCommand_update = $"update \"{dataname}\" set Price = {textBox_Price.Text},Price_material=Price_material, Profit=({tmp_price}-Price_material)*0.28 where Rem_karta ={textBox_remkarta.Text};";
            }

            if (textBox_material.Text.Length != 0)
            {
                decimal tmp_material = decimal.Parse(textBox_material.Text);
                SQLCommand_update = $"update \"{dataname}\" set Price_material = {textBox_material.Text},Profit=(Price-{tmp_material})*0.28 where Rem_karta ={textBox_remkarta.Text};";
            }
            if ((textBox_kontragent.Text).Length != 0 && textBox_baraban.Text.Length != 0 && textBox_Value_.Text.Length != 0 && textBox_Price.Text.Length != 0 &&
                textBox_material.Text.Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\"" +
                    $", Baraban = {textBox_baraban.Text},Value_ = {textBox_Value_.Text},Price = {textBox_Price.Text},Price_material = {textBox_material.Text}," +
                    $"Profit=(Price-Price_material)*0.28" +
                    $" where Rem_karta ={textBox_remkarta.Text};";
            }
            //NO Price_material
            if ((textBox_kontragent.Text).Length != 0 && textBox_baraban.Text.Length != 0 && textBox_Value_.Text.Length != 0 && textBox_Price.Text.Length != 0 &&
                textBox_material.Text.Length == 0)
            {
                decimal tmp_price = decimal.Parse(textBox_Price.Text);
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\"" +
                    $", Baraban = {textBox_baraban.Text},Value_ = {textBox_Value_.Text},Price = {textBox_Price.Text}," +
                    $"Profit=({tmp_price}-Price_material)*0.28 where Rem_karta ={textBox_remkarta.Text};";
            }
            //NO Price
            if ((textBox_kontragent.Text).Length != 0 && textBox_baraban.Text.Length != 0 && textBox_Value_.Text.Length != 0 && textBox_Price.Text.Length == 0 &&
                textBox_material.Text.Length != 0)
            {
                decimal tmp_material = decimal.Parse(textBox_material.Text);
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\"" +
                    $", Baraban = {textBox_baraban.Text},Value_ = {textBox_Value_.Text}," +
                    $"Profit=(Price-{tmp_material})*0.28,Price_material = {textBox_material.Text}" +
                    $" where Rem_karta ={textBox_remkarta.Text};";
            }
            //No Value_
            if ((textBox_kontragent.Text).Length != 0 && textBox_baraban.Text.Length != 0 && textBox_Value_.Text.Length == 0 && textBox_Price.Text.Length != 0 &&
               textBox_material.Text.Length != 0)
            {
                float price_tmp = float.Parse(textBox_Price.Text);
                float price_material = float.Parse(textBox_material.Text);
                string result_profit = ((price_tmp - price_material) * 0.28f).ToString();
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\"" +
                    $", Baraban = {textBox_baraban.Text},Price = {textBox_Price.Text}," +
                    $"Profit =\"{result_profit}\",Price_material = {textBox_material.Text}" +
                    $" where Rem_karta ={textBox_remkarta.Text};";
            }
            //No Baraban
            if ((textBox_kontragent.Text).Length != 0 && textBox_baraban.Text.Length == 0 && textBox_Value_.Text.Length != 0 && textBox_Price.Text.Length != 0 &&
               textBox_material.Text.Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set Kontragent = \"{textBox_kontragent.Text}\"" +
                $",Value_ = \"{textBox_Value_.Text}\",Price = {textBox_Price.Text}," +
                $"Profit=(Price-Price_material)*0.28,Price_material = {textBox_material.Text}" +
                $" where Rem_karta ={textBox_remkarta.Text};";
            }
            //No Kontragent
            if ((textBox_kontragent.Text).Length == 0 && textBox_baraban.Text.Length != 0 && textBox_Value_.Text.Length != 0 && textBox_Price.Text.Length != 0 &&
              textBox_material.Text.Length != 0)
            {
                SQLCommand_update = $"update \"{dataname}\" set " +
                    $"Value_ = \"{textBox_Value_.Text}\",Price = {textBox_Price.Text}," +
                    $"Profit=(Price-Price_material)*0.28,Price_material = {textBox_material.Text}" +
                    $" where Rem_karta ={textBox_remkarta.Text};";
            }
            SQLiteCommand command = new SQLiteCommand(SQLCommand_update, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"Изменения прошли\nуспешно","**Сообщение**");
            this.Close();

        }
    }
}
