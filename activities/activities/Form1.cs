namespace activities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.Add("Year");
            comboBox1.Items.Add("Months");


            comboBox3.Items.Add("small");
            comboBox3.Items.Add("Medium");
            comboBox3.Items.Add("Large");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedItem=="Year")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("2020");
                comboBox2.Items.Add("2021");
                comboBox2.Items.Add("2023");
                comboBox2.Items.Add("2024");
            }
            else if(comboBox1.SelectedItem=="Months")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Jan");
                comboBox2.Items.Add("feb");
                comboBox2.Items.Add("mar");
                comboBox2.Items.Add("Apr");

               
            }
            else
            {
                comboBox2.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you selected " + comboBox2.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && checkBox1.Checked)
            {
                MessageBox.Show("You ordered a " + comboBox3.SelectedItem + "," + radioButton1.Text + "," + checkBox1.Text + " Pizza");
            }
            else if(radioButton2.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You ordered a " + comboBox3.SelectedItem + "," + radioButton2.Text + "," + checkBox2.Text + " Pizza");
            }
            else if(radioButton2.Checked && checkBox1.Checked)
            {
                MessageBox.Show("You ordered a " + comboBox3.SelectedItem + "," + radioButton2.Text + "," + checkBox1.Text + " Pizza");
            }
            else if(radioButton1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You ordered a " + comboBox3.SelectedItem + "," + radioButton1.Text + "," + checkBox2.Text + " Pizza");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}