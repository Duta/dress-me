using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DressMe
{
    public class ClothingItem
    {
        public string Name { get; set; }
        public string Retailer { get; set; }
        public int Price { get; set; } // GBP
        public Image Image { get; set; }
        public string URL { get; set; }
    }
}
