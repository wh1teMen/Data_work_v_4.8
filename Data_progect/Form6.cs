using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Data_progect
{
  
    public partial class Form6 : Form
    {
       static public string month { get; set; }
        private int value_mont; 
        static public decimal _profit_count { get; set; }
        static public int _baraban_count { get; set; }
        static public int _value_count { get; set; }
        public int Value_month
        {
            get=> value_mont;
            set
            {
                int tmp = DateTime.Now.Month;
                if (value > tmp&&value<13) throw new Exception("Этот месяц еще не наступил");
                if (value > 12) throw new Exception("В году всего 12 месяцев");
                if (value < 1||value==0) throw new Exception("Месяц не иожет быть меньше 1");
                else value_mont = value;
            }
        }
        


        private List<Dal.OutBase> _list;
      

        public Form6()
        {
            InitializeComponent();
            _list = new List<Dal.OutBase>();
            Base.DataSource=_list;
            dataGridView1.AutoGenerateColumns = true;
            
        }
            public void refresh()
            {
          
            try
            {
               
                Value_month = int.Parse(textBox1.Text);
                month = Value_month.ToString() + DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА");

            }



            _list.Clear();
            List<Dal.OutBase> list = Dal.SqlHelper.GetData();
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);
                Base.ResetBindings(false);
            }           

            }






        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();                
          
        }

        private void button_money_Click(object sender, EventArgs e)
        {
            _profit_count = 0;
            _value_count = 0;
            _baraban_count = 0;
            _list.Clear();
            try
            {
               
                Value_month = int.Parse(textBox1.Text);
                month = Value_month.ToString() + DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА");

            }



            _list.Clear();
            List<Dal.OutBase> list = Dal.SqlHelper.GetData();
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);
                Base.ResetBindings(false);
            }


            _list.ForEach(x => _profit_count += decimal.Parse(x.Profit));
            _list.ForEach(x => _baraban_count += x.Baraban);
            _list.ForEach(x => _value_count += x.Value_);
            decimal itog = _profit_count - 16000;
            MessageBox.Show("Заработанно: "+_profit_count.ToString()+"\nКол-во Брабанов: "+_baraban_count.ToString()+"\nКол-во Картриджей: "+_value_count.ToString()+"\nНа руки:"+itog.ToString(),"ИНФОРМАЦИЯ");

        }
    }
}
