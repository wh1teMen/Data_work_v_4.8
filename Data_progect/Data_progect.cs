using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_progect
{
    internal class Data_progect
    {
        
        public int rem_karta;
        public string kontragent;
        public int baraban;
        public int value_;
        public decimal price;
        public decimal price_material;
        

        public int Rem_karta 
        {
            get => rem_karta;
            set
            {
                if (value == 0) throw new Exception("ошибка!! Номер ремонтной карты\nне может быть равен нулю");
                if (value <0) throw new Exception("ошибка!! Номер ремонтной карты\nне может быть меньше нуля");
                else rem_karta = value;

            }
        }
        public string Kontragent
        {
            get => kontragent;
            set 
            {
                if (value.Length < 3) throw new Exception("ошибка!!! Имя Контрагента не\nможет быть меньше 3 букв!!");
                else kontragent = value;
            }
        }
        public int Baraban
        {
            get => baraban;
            set
            {
               
                if (value < 0) throw new Exception("Ошибка!!! Количество замененных\nфотобарабанов не может быть меньше нуля!!");
                else baraban = value;
            } 
        }
        public int Value_
        {
            get => value_;
            set
            {
                if (value == 0) throw new Exception("Общее количесвто картриджей\nне может быть равным нулю!!!");
                if (value < 0) throw new Exception("Общее количество фотобарабанов\nне может быть меньше нуля!!!");
                else value_ = value;
            } 
        }
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0) throw new Exception("Счёт клиенту не может\nбыть меньше нуля!!!!");
                if (value == 0) throw new Exception("Счёт клиенту не может\nбыть равным нулю!!!");
                else price = value;
            }
        }
        public decimal Price_material
        {
            get => price_material;
            set
            {
                if (value < 0) throw new Exception("Цена за материалы\nне может быть меньше нуля!!!");
               if (value == 0) throw new Exception("Цена за материалы\nне может быть меньше нуля!!!");
                else price_material = value;

            }
        }
       
        public Data_progect()
        {
            rem_karta = 0000;
            kontragent = "NonameKontragent";
            baraban = 0;
            value_ = 0;
            price = 0;
            price_material =0;
           
        }
    }
}
