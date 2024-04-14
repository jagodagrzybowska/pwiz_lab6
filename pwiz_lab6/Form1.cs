namespace pwiz_lab6
{
    public partial class Form1 : Form
    {
        public int x, y, dydelf, krokodyl, czas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//START
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)//ustawienia
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)//koniec
        {
            this.Close();
        }
    }
}
