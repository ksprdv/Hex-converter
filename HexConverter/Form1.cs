namespace HexConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToInt32(textBox1.Text, 16).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = int.Parse(textBox1.Text).ToString("X");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (0).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (255).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Convert.ToInt32(textBox1.Text, 16) - 1).ToString("X").ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Convert.ToInt32(textBox1.Text, 16) + 1).ToString("X").ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToInt32("00", 16).ToString("X").ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToInt32("FF", 16).ToString("X").ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
