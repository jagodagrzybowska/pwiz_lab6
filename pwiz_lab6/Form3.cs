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
    public partial class Form3 : Form
    {
        private Form1 form1;
        private Form2 form2;
        public int x, y;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//x
        {
            form1.x = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//y
        {
            form1.y = int.Parse(comboBox2.SelectedItem.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//dydelfy
        {
            form1.dydelf = int.Parse(comboBox3.SelectedItem.ToString());
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//krokodyle
        {
            form1.krokodyl = int.Parse(comboBox4.SelectedItem.ToString());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)//czas
        {
            form1.czas = int.Parse(comboBox5.SelectedItem.ToString());
        }
    }
}
