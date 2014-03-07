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
using HtmlAgilityPack;

namespace DressMe
{
    public partial class MainForm : Form
    {
        private IDictionary<RadioButton, string> itemTypesDict;

        public MainForm()
        {
            InitializeComponent();

            itemTypesDict = new Dictionary<RadioButton, string>();
            itemTypesDict.Add(tshirtsRadioButton, "t-shirts");
            itemTypesDict.Add(jeansRadioButton, "jeans");

            var item1 = new ClothingItem();
            item1.Name = "Asos Scoop Neck T-shirt";
            item1.Price = 6;
            item1.Retailer = "Asos Collection";
            item1.URL = "http://www.lyst.com/clothing/asos-collection-blue-asos-scoop-neck-t-shirt-1/";
            item1.Image = GetImage("http://cdnd.lystit.com/220/600/t/photos/2011/08/02/asos-collection-blue-asos-scoop-neck-t-shirt-product-1-1395616-067000392.jpeg");
            AddItem(item1);

            var item2 = new ClothingItem();
            item2.Name = "Asos Scoop Neck T-shirt";
            item2.Price = 5;
            item2.Retailer = "Asos Collection";
            item2.URL = "http://www.lyst.com/clothing/asos-collection-black-asos-scoop-neck-t-shirt/";
            item2.Image = GetImage("http://cdnd.lystit.com/220/600/t/photos/2011/08/02/asos-collection-black-asos-scoop-neck-t-shirt-product-1-1395729-143074562.jpeg");
            AddItem(item2);

            var item3 = new ClothingItem();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            int minPrice, maxPrice;
            if (!int.TryParse(minPriceTextBox.Text, out minPrice)
            || !int.TryParse(maxPriceTextBox.Text, out maxPrice))
            {
                return;
            }
            string itemType = null;
            foreach (var radioButton in itemTypesDict.Keys)
            {
                if (radioButton.Checked)
                {
                    itemType = itemTypesDict[radioButton];
                    break;
                }
            }
            if (itemType == null)
            {
                return;
            }

            AddItems(minPrice, maxPrice, itemType);
        }

        private async void AddItems(int minPrice, int maxPrice, string itemType)
        {
            var url = "http://www.lyst.com/shop/filter/?stock_status=3";
            url += "&gender=Men";
            url += "&product_type=Clothing";
            url += "&category=" + itemType;
            url += "&price_from=" + minPrice;
            url += "&price_to=" + maxPrice;

            var web = new HtmlWeb();
            var doc = web.Load(url);
            doc.OptionFixNestedTags = true;
            if (doc.ParseErrors != null)
            {
                Console.WriteLine(doc.ParseErrors.Count() + " parse errors");
                foreach (var error in doc.ParseErrors) {
                    Console.WriteLine(error.Reason);
                }
            }
            var items = new List<ClothingItem>();
            //HtmlNodeCollection productNodes = doc.DocumentNode.SelectNodes(".//*div[@class='product']");
            //Console.WriteLine(productNodes.Count + " nodes");
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
    }
}
