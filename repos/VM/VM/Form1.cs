namespace VM
{
    public partial class Form1 : Form
    {
        CoinSlots cs = new CoinSlots();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs.insert("quarter");
            totalLabel.Text = cs.total().ToString();
        }
    }
}
