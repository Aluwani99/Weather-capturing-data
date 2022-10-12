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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            // Declaration Varibles
            StreamReader sr = new StreamReader("WeatherForecase.txt");
            var citys = new List<CitiesChoose>();
            string divide;

            // A loop for the array split each text in the files
            while (!sr.EndOfStream)
            {
                divide = sr.ReadLine();
                string[] cut = divide.Split(',');
                CitiesChoose Towns = new CitiesChoose();
                Towns.Name = cut[0];
                citys.Add(Towns);
            }

            var groupTowns = citys.GroupBy(x => x.Name);
            foreach (var group in groupTowns)
            {
                // Declaration Varibles
                string  Town = "";
                // A loop for names for Towns
                foreach (var x in group)
                {
                    Town = x.Name;
                }
                // Combobox will contains the cities name after loop
                cbxCities.Items.Add(Town);
            }
            // Close the StreamReader
            sr.Close();
        }

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declaration Varibles
            StreamReader sr = new StreamReader("WeatherForecase.txt");
            string Towns = cbxCities.SelectedItem.ToString();
            string divide;
            lbxTowns.Items.Clear();

            // A loop in for file 
            while (!sr.EndOfStream)
            {
                // Declaration Varibles
                divide = sr.ReadLine();
                string[] split = divide.Split(',');

                // Check if Towns are equals to array which contains
                if (Towns.Equals(split[0]))
                {
                    lbxTowns.Items.Add(split[0] + "\t" + split[1] + "\t" + split[2] + "\t" + split[3] + "\t" + split[4] + "\t" + split[5] + "\t" + split[6] + "\t" + split[7] + "\t" + split[8] );
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GeneralUser().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
