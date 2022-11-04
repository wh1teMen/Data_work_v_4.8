using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Data_progect
{

  
    public partial class Form1 : Form
    {
        string dataname = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());

        public Form1()
        {
            InitializeComponent();
        }


        Data_progect newDatabase = new Data_progect();
      
        private void button_add_Click(object sender, EventArgs e)
        {
            /* вот в этом кусочке ниже в file_name создаю таблицу с именем 102022*/
       
        string databaseName = "project.db";

           
                var SQL_command_create = $"CREATE TABLE IF NOT EXISTS \"{dataname}\" ( id INTEGER PRIMARY KEY   UNIQUE,Rem_karta INTEGER, Kontragent VARCHAR (1, 100) NOT NULL, Baraban INTEGER,Value_ INTEGER,Price  DECIMAL, Price_material DECIMAL, Profit DECIMAL);";
                SQLiteConnection connects = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                connects.Open();
                SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, connects);
                command_create.ExecuteNonQuery();
                connects.Close();
            
                
            

           

             






                int exeption = 0;

                try
                {
                    exeption = 0;
                    newDatabase.Rem_karta = int.Parse(textBox_remkarta.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); exeption++; }

                try
                {
                    newDatabase.Kontragent = textBox_kontragent.Text;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); }
                try
                {
                    newDatabase.Baraban = int.Parse(textBox_baraban.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); }
                try
                {
                    newDatabase.Value_ = int.Parse(textBox_Value_.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); }
                try
                {
                    newDatabase.Price = decimal.Parse(textBox_Price.Text);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ОШИБКА"); }
                try
                {
                    newDatabase.Price_material = decimal.Parse(textBox_material.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


                decimal price = newDatabase.Price;
                decimal material_price = newDatabase.Price_material;

                string result_profit = ((price - material_price) * 0.28m).ToString();

                var SQL_command = $"INSERT INTO \"{dataname}\"(Rem_karta,Kontragent,Baraban,Value_,Price,Price_material,Profit)" +
                                  $"VALUES({newDatabase.Rem_karta},\"{newDatabase.Kontragent}\",{newDatabase.Baraban},{newDatabase.Value_}" +
                                  $",{newDatabase.Price},{newDatabase.Price_material},\"{result_profit}\");";
                SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(SQL_command, connection);
                command.ExecuteNonQuery();

                MessageBox.Show($" ДОБАВЛЕНО!!!\n с клиента {this.textBox_kontragent.Text}\nзаработанно: {result_profit} руб.");
                connection.Close();

            
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string databaseName = "project.db";     
          
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            var SQLCommand_update=" ";
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
                decimal tmp_price=decimal.Parse(textBox_Price.Text);
                SQLCommand_update = $"update \"{dataname}\" set Price = {textBox_Price.Text},Price_material=Price_material, Profit=({tmp_price}-Price_material)*0.28 where Rem_karta ={textBox_remkarta.Text};";
            }

            if (textBox_material.Text.Length != 0)
            {            
                decimal tmp_material=decimal.Parse(textBox_material.Text);
                SQLCommand_update = $"update \"{dataname}\" set Price_material = {textBox_material.Text},Profit=(Price-{tmp_material})*0.28 where Rem_karta ={textBox_remkarta.Text};";
            }
            if ((textBox_kontragent.Text).Length != 0&& textBox_baraban.Text.Length != 0&& textBox_Value_.Text.Length != 0&& textBox_Price.Text.Length != 0&&
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
        }

        private void button_delete_pos_Click(object sender, EventArgs e)
        {
           
            string databaseName = "project.db";
            var newDatabase = new Data_progect();
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            string SQLCommand_delete_record = $"delete from \"{dataname}\" where Rem_karta ={textBox_remkarta.Text};";
            SQLiteCommand command = new SQLiteCommand(SQLCommand_delete_record, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись Удалена\nуспешно!!!", "Удаление...");

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {

            string databaseName = "project.db";
            var newDatabase = new Data_progect();
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            string SQLCommand_delete_record = $"delete from \"{dataname}\" where Rem_karta =0;";
            SQLiteCommand command = new SQLiteCommand(SQLCommand_delete_record, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Очистка прошла\nуспешно!!!", "Cleaner...");

        }

        private void button_info_Click(object sender, EventArgs e)
        {
            string info =
                "ДОБАВИТЬ:\nРемонтная карта (число)\nКонтрагент (название организации)\nКол-во Барабанов (число от 1)\nОбщее кол-во(число от 1)\nСчет клиенту(число)" +
                "\nСтоимость материалов(число<счета клиенту)\nНажимаем кнопку => ДОБАВИТЬ\n\n" +
                "ИЗМЕНИТЬ:\nРемонтная карта (число)\nЗаполняем поле, в котором хотим произвести изменения\nНажимаем кнопку => ИЗМЕНИТЬ" +
                "\n\nУДАЛИТЬ:\nРемонтная карта (число)\nЗаполняем поле, в котором хотим произвести изменения\nНажимаем кнопку => УДАЛИТЬ" +
                "\n\nОЧИСТИТЬ:\nЧтобы очистить пустые записи,в которых Ремонтная карта равна 0\nНажимаем кнопку => ОЧИСТИТЬ";

            MessageBox.Show(info, "ИНФОРМАЦИЯ О РАБОТЕ ПРИЛОЖЕНИЯ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
   
}
