using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DressMe
{
    public class ClothingItemPanel : FlowLayoutPanel
    {
    
        public ClothingItemPanel(ClothingItem item)
        {
            int width = 120;
            LinkLabel nameLabel = new NameLabel(item.Name, item.URL, width);
            Label retailerLabel = new CenteredLabel(item.Retailer, width);
            Label priceLabel = new CenteredLabel("£" + item.Price, width);
            PictureBox imageBox = new PictureBox();

            imageBox.Image = item.Image;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.Size = new Size(width, 150);

            Controls.Add(nameLabel);
            Controls.Add(retailerLabel);
            Controls.Add(priceLabel);
            Controls.Add(imageBox);

            BackColor = Color.FromArgb(50, 50, 50);
            Padding = new Padding(0, 3, 0, 0);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowDirection = FlowDirection.TopDown;
        }
    }
}
