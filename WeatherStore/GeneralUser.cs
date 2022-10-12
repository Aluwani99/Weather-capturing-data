using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeatherStore
{
    public partial class GeneralUser : Form
    {
        public GeneralUser()
        {
            InitializeComponent();
        }
              
        private void GeneralUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new Search().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new WeatherForecast().Show();
            this.Hide();
        }

        private void txtFavorite_TextChanged(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("WeatherForecase.txt"))
            {
                while (sr.ReadLine() != null)
                {
                    txtFavorite.Text += sr.ReadLine() + Environment.NewLine;
                }

            }

        }
    }
}
