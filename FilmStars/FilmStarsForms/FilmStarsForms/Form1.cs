namespace FilmStarsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                MessageBox.Show("You are not a user, try again please.");
            else
            {
                guestselectfilm f1 = new guestselectfilm();
                Form1 form = new Form1();
                form.Close();
                f1.Show();
            }
        }

      
    }
}