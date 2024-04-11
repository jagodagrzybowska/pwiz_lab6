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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = comboBox1.SelectedValue;
        }
    }
}
