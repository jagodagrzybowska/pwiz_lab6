using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace pwiz_lab6
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int time_left;
        int found = 0;

        public Form2()
        {
            InitializeComponent();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time_left--;
            label1.Text = time_left.ToString() + " s";

            if (time_left <= 0)
            {
                timer.Stop();
                MessageBox.Show("KONIEC CZASU - PRZEGRYWASZ");
            }
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            time_left = form1.czas;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        public Form2(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }


        private void load_tiles()
        {
            PictureBox[] tile = new PictureBox[form1.x * form1.y];
            int cnt = 0;
            int a = 0;
            int b = 0;
            List<int> used = new List<int>();
            List<int> used1 = new List<int>();


            for (int i = 0; i < form1.x * form1.y; i++)
            {
                tile[i] = new PictureBox();
                tile[i].Height = 40;
                tile[i].Width = 40;
                tile[i].Left = a;
                tile[i].Top = b;
                tile[i].BorderStyle = BorderStyle.FixedSingle;
                tile[i].Image = imageList1.Images[3];
                tile[i].Tag = "p";
                tile[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tile[i].Click += new EventHandler(ClickTile);
                panel1.Controls.Add(tile[i]);
                a = a + 40;
                cnt++;
                if (cnt == form1.x)
                {
                    a = 0;
                    b = b + 40;
                    cnt = 0;
                }
            }

            Random random = new Random();
            while (used.Count < form1.dydelf)
            {
                int num = random.Next(form1.x * form1.y);
                if(!used.Contains(num))
                { 
                    tile[num].Tag = "d"; 
                    used.Add(num);
                }
            }
            while (used1.Count < form1.krokodyl)
            {
                int num = random.Next(form1.x * form1.y);
                if (!used.Contains(num))
                {
                    tile[num].Tag = "k";
                    used1.Add(num);
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_tiles();
        }

        private void ClickTile(object sender, EventArgs e)
        {
            
            PictureBox tile = (PictureBox)sender;
            if (tile.Tag.ToString() != "clicked")
            {
                if (tile.Tag.ToString() == "k")
                {
                    timer.Stop();
                    tile.Image = imageList1.Images[0];
                    MessageBox.Show("KROKODYL!!! - PRZEGRYWASZ");
                    this.Close();
                }
                else if (tile.Tag.ToString() == "d")
                {
                    tile.Image = imageList1.Images[1];
                    tile.Tag = "clicked";
                    found++;
                    if (found == form1.dydelf)
                    {
                        timer.Stop();
                        MessageBox.Show("ZNALEZIONO WSZYSTKIE DYDELFY - WYGRYWASZ");
                    }

                }
                else if (tile.Tag.ToString() == "p")
                    tile.Image = imageList1.Images[2];

            }
        }

        
    }
}
