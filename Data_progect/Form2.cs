using Data_progect.Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_progect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3_add form = new Form3_add();
            form.Show();
        }

        private void button_update_f2_Click(object sender, EventArgs e)
        {
            Form4_update form = new Form4_update();
            form.Show();
        }

        private void button_del_f2_Click(object sender, EventArgs e)
        {
            Form5_delete form = new Form5_delete();
            form.Show();
        }
        private void button_show_data_f2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }       

    }
}
