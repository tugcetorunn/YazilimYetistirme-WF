namespace _02_DinamikButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0; // globalde çünkü her seferinde 0 olmaması için

        Random random = new Random();

        private void btnYeniButton_Click(object sender, EventArgs e)
        {
            Button btn = new Button();

            btn.Width = btn.Height = 50;

            btn.Text = sayac++.ToString();

            btn.Location = new Point(random.Next(0, ClientSize.Width - btn.Width), random.Next(0, ClientSize.Height - btn.Height));
            
            btn.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // btn.Click += Btn_Click; // yeni btn a basıldığında bu metodu çalıştırıyor.

            // btn.MouseMove += Btn_MouseMove;

            btn.MouseMove += Btn_MouseMove;

            this.Controls.Add(btn);

        }

        private void Btn_MouseMove(object? sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Location = new Point(random.Next(0, ClientSize.Width - btn.Width), random.Next(0, ClientSize.Height - btn.Height));
        }

        //private void Btn_MouseMove(object? sender, EventArgs e)
        //{
        //    (sender as Button).BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        //}

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show($"Ben {btn.Text}. butonum.");
        }
    }
}