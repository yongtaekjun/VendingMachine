using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UI
{
    public class Item
    {
        public string code { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public uint amount { get; set; }

        public string full_description
        {
            get
            {
                return $"{code} {title} {price} {amount}";
            }
        }
        //public Item(string code, string title, double price)
        //{
        //    this.code = code;
        //    this.title = title;
        //    this.price = price;
        //}
    }
}
