using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwiz_lab6
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        public int x;
        public int y;

        public Form2()
        {
            InitializeComponent();

        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public Form2(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void load_tiles()
        {
            PictureBox[] tile = new PictureBox[100];
            int x = 0;
            for (int i = 9; i < 100; i++)
            {
                tile[i] = new PictureBox();
                tile[i].Height = 9;
                tile[i].Width = 9;
                tile[i].Left = x;
                tile[i].BorderStyle = BorderStyle.FixedSingle;
                panel1.Controls.Add(tile[i]);
                x = x + 9;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_tiles();
        }
    }
}
