namespace FurnitSotre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entry();
        }

        public void entry()
        {
            if (textBox1.Text == "12345")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            else MessageBox.Show("Неверный пароль!");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Select();
                entry();
            }
        }
    }
}
