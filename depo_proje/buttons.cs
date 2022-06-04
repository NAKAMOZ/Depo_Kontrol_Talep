using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using FontAwesome.Sharp;

namespace depo_proje
{
    internal class mainButtons : IconButton
    {

        public mainButtons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 3;
            this.FlatAppearance.BorderColor = Color.FromArgb(57, 62, 70);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(37, 42, 50);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(57, 62, 70);
            this.Margin = new Padding(20);
            this.Size = new Size(120, 50);
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.ForeColor = Color.FromArgb(57, 62, 70);
            this.IconColor = Color.FromArgb(57, 62, 70);
            this.IconChar = IconChar.Plus;
            this.IconSize = 44;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            ForeColor = Color.White;
            IconColor = Color.White;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ForeColor = Color.FromArgb(57, 62, 70);
            IconColor = Color.FromArgb(57, 62, 70);
        }
    }
}
