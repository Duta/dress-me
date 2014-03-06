using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ClothingItem item1 = new ClothingItem();
            item1.Name = "Asos Scoop Neck T-shirt";
            item1.Price = 6;
            item1.Retailer = "Asos Collection";
            item1.URL = "http://www.lyst.com/clothing/asos-collection-blue-asos-scoop-neck-t-shirt-1/";
            item1.Image = GetImage("http://cdnd.lystit.com/220/600/t/photos/2011/08/02/asos-collection-blue-asos-scoop-neck-t-shirt-product-1-1395616-067000392.jpeg");
            AddItem(item1);

            ClothingItem item2 = new ClothingItem();
            item2.Name = "Asos Scoop Neck T-shirt";
            item2.Price = 5;
            item2.Retailer = "Asos Collection";
            item2.URL = "http://www.lyst.com/clothing/asos-collection-black-asos-scoop-neck-t-shirt/";
            item2.Image = GetImage("http://cdnd.lystit.com/220/600/t/photos/2011/08/02/asos-collection-black-asos-scoop-neck-t-shirt-product-1-1395729-143074562.jpeg");
            AddItem(item2);

            ClothingItem item3 = new ClothingItem();
            item3.Name = "Asos Crew Neck T-shirt with Pocket";
            item3.Price = 6;
            item3.Retailer = "Asos Collection";
            item3.URL = "http://www.lyst.com/clothing/asos-collection-white-asos-crew-neck-t-shirt-with-pocket/";
            item3.Image = GetImage("http://cdna.lystit.com/220/600/t/photos/2011/08/02/asos-collection-white-asos-crew-neck-t-shirt-with-pocket-product-1-1395719-116467054.jpeg");
            AddItem(item3);
        }

        private Image GetImage(string url)
        {
            return Image.FromStream(new MemoryStream(new WebClient().DownloadData(url)));
        }

        public void AddItem(ClothingItem item)
        {
            flowLayoutPanel.Controls.Add(new ClothingItemPanel(item));
        }

        public void ClearItems()
        {
            flowLayoutPanel.Controls.Clear();
        }
    }
}
