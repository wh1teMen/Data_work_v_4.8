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
    public partial class Form5_delete : Form
    {
        public Form5_delete()
        {
            InitializeComponent();
        }
        string dataname = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        Data_progect newDatabase = new Data_progect();

        private void button_del_f5_Click(object sender, EventArgs e)
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
            this.Close();

        }
    }
}
