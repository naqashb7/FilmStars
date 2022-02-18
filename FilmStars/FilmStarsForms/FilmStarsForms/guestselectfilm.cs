using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FilmStarsForms
{
    public partial class guestselectfilm : Form
    {
        public guestselectfilm()
        {
            InitializeComponent();
        }

        private void guestselectfilm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            string filmTitle = textBox1.Text;
            string genre = textBox2.Text;   
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=mydb;User ID=root;Password=WorkBench7";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataReader datareader;
            String mysql, Output = "";
            mysql = "SELECT film_title FROM movie WHERE film_title = \"" + filmTitle + "\";";
            
            command = new MySqlCommand(mysql, cnn);
            datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                Output = Output + datareader.GetValue(0) + "-" + datareader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);
            cnn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
