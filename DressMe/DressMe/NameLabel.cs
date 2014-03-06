using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressMe
{
    public class NameLabel : LinkLabel
    {
        public NameLabel(string name, string url, int width)
        {
            Text = name;
            ForeColor = Color.White;
            Links.Add(new LinkLabel.Link(0, Text.Length, url));
            AutoSize = true;
            Font = new Font(
                "Microsoft Sans Serif",
                8.25F,
                FontStyle.Bold | FontStyle.Underline,
                GraphicsUnit.Point, ((byte)(0)));
            LinkColor = Color.White;
            VisitedLinkColor = Color.White;
            Size = new Size(width, 23);
            MaximumSize = new Size(width, 0);
            TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;
        }
    }
}
