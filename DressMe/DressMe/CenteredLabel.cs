using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DressMe
{
    public class CenteredLabel : Label
    {
        public CenteredLabel(string text, int width)
        {
            Text = text;
            ForeColor = Color.White;
            AutoSize = true;
            Size = new Size(width, 23);
            MaximumSize = new Size(width, 0);
            TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;
        }
    }
}
