using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_progect
{
    public partial class Form3_add : Form
    {
        string dataname = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        public Form3_add()
        {
            InitializeComponent();
        }
        Data_progect newDatabase = new Data_progect();

        private void button_add_Click(object sender, EventArgs e)
        {
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

            
            this.Close();

        }
    }
}
