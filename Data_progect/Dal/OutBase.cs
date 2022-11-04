using System;
using System.ComponentModel;

namespace Data_progect.Dal
{
    internal class OutBase
    {
        [Browsable(false)]
        public int Id { get; internal set; }
        [DisplayName("Ремонтная карта")]
        public int Rem_karta { get; internal set; }
        [DisplayName("Контрагент")]
        public string Kontragent { get; internal set; }
        [DisplayName("Кол-во Барабанов")]
        public int Baraban { get; internal set; }
        [DisplayName("Кол-во Картриджей")]
        public int Value_ { get; internal set; }
        [DisplayName("Счёт")]
        public decimal Price { get; internal set; }
        [DisplayName("Цена материалов")]
        public decimal Price_material { get; internal set; }
        [DisplayName("Прибыль")]
        public string Profit { get; internal set; }
    }
      
}