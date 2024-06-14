namespace fukuv0614
{

    public partial class Form1 : Form
    {
        static Random random = new Random();

        int ans = random.Next(51);
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yosou;



            count++;

            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");

            if (ans == yosou)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
            }
            else if (ans<yosou) 
            {
                MessageBox.Show("Less");
            }
            else
            {
                MessageBox.Show("Greater");
            }
        }
    }
}