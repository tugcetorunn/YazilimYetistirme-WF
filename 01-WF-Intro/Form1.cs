namespace _01_WF_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add("ali");
            listBox1.Items.Add("veli");
            listBox1.Items.Add("ayşe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1 nesnesinin click eventi tetiklendiğinde bu metod çalışacak.
            // MessageBox.Show("hellöö");

            listBox1.Items.Add(textBox1.Text);

            MessageBox.Show(radioButton1.Checked ? "kadın" : !radioButton1.Checked ? "erkek" : "seçim yok");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label3.Text = textBox1.Text.Length.ToString(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("slm");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // timer1.Start();
        }
    }
}