using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm
{
    public partial class cinema :Form
    {

        public cinema()
        {
           


            this.Size = new System.Drawing.Size(600,800);
            this.BackgroundImage = new Bitmap(@"../../image/kos.jpg");
            Label lbl = new Label()
            {
                Text = "Tere tulemast kinno!",
                Location = new System.Drawing.Point(150, 30),
                Size = new Size(240, 40),
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = Color.FromArgb(39, 61, 167)

            };
            Label lbl2 = new Label()
            {
                Text = "Valige film",
                Location = new System.Drawing.Point(150, 70),
                Size = new Size(240, 40),
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = Color.FromArgb(39, 61, 167)

            };
            this.Controls.Add(lbl);
            this.Controls.Add(lbl2);

            List<string> lists = new List<string>();

            lists.Add("sb.jpg");
            lists.Add("zw.jpg");
            lists.Add("jm.jpg");

            PictureBox pb = new PictureBox()
            {
                ImageLocation = ($"../../image/{lists[0]}"),
                Location = new Point(25, 200),
                Size = new Size(150, 250),
                SizeMode = PictureBoxSizeMode.StretchImage
                
            };

            pb.MouseClick += Pb_MouseClick;
            PictureBox pb2 = new PictureBox()
            {
                ImageLocation = ($"../../image/{lists[1]}"),
                Location = new Point(370, 200),
                Size = new Size(150, 250),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox pb3 = new PictureBox()
            {
                ImageLocation = ($"../../image/{lists[2]}"),
                Location = new Point(200, 410),
                Size = new Size(150, 250),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pb);
            this.Controls.Add(pb2);
            this.Controls.Add(pb3);
            pb2.MouseClick += Pb2_MouseClick; pb3.MouseClick += Pb3_MouseClick;






        }

        private void Pb3_MouseClick(object sender, MouseEventArgs e)
        {
           
            room room = new room("Cinema", "Valige saali suurus", "Väike", "Keskmine", "Suur");
            room.StartPosition = FormStartPosition.CenterScreen;
            room.ShowDialog();
  
        }

        private void Pb2_MouseClick(object sender, MouseEventArgs e)
        {
            room room = new room("Cinema", "Valige saali suurus", "Väike", "Keskmine", "Suur");
            room.StartPosition = FormStartPosition.CenterScreen;
            room.ShowDialog();
        }

        private void Pb_MouseClick(object sender, MouseEventArgs e)
        {
            room room = new room("Cinema", "Valige saali suurus", "Väike", "Keskmine", "Suur");
            room.StartPosition = FormStartPosition.CenterScreen;
            room.ShowDialog();
        }
    }
}
