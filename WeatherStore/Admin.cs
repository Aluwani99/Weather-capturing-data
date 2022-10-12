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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter("WeatherForecase.txt"))
            {
                    sr.WriteLine(txtReport.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("WeatherForecase.txt"))
            {
                while (sr.ReadLine() != null)
                {
                    txtReport.Text += sr.ReadLine() + Environment.NewLine;
                }
              
            }
        
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new WeatherAdmin().Show();
            this.Hide();

        }
    }
}
