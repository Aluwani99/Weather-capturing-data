using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

/**
 * Author : Aluwani Mahlatse Rambau
 * Student Number : 19010010
 * Programming 2A Assessment
 * Contact no : 0676225015
 * Email : 19010010@rcconnect.co.za
 * 
**/

namespace WeatherStore
{
    public partial class WeatherAdmin : Form
    {
        public WeatherAdmin()
        {
            InitializeComponent();
        }
        // Declaration Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = WeatherStore; Integrated Security=True;";

        private void WeatherForecast_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(DataFile);

            try
            {
                sqlCon.Open();
                String query = "insert into tblWeatherAdmini (City,Date,Minimum,Maximum,Preciption,Humidty,Wind) values('" + comboBox1.Text + "' , '"
                    + dateTimePicker1.Text + "' , '" + txtMini.Text + "' , '"
                    + txtMaxi.Text + "', '" + txtPrecip.Text + "', '"
                    + txtHumidty.Text + "' , '" + txtWind.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Data has been store", "Press OK", MessageBoxButtons.OK);

                txtMini.Clear();
                txtMaxi.Clear();
                txtHumidty.Clear();
                txtPrecip.Clear();
                txtWind.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("You Data is INCORRECT");
            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMini_KeyPress(object sender, KeyPressEventArgs e)
        {
            char src = e.KeyChar;

            if (!Char.IsDigit(src) && src != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMaxi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char src = e.KeyChar;

            if (!Char.IsDigit(src) && src != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecip_KeyPress(object sender, KeyPressEventArgs e)
        {
            char src = e.KeyChar;

            if (!Char.IsDigit(src) && src != 8)
            {
                e.Handled = true;
            }
        }

        private void txtHumidty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char src = e.KeyChar;

            if (!Char.IsDigit(src) && src != 8)
            {
                e.Handled = true;
            }
        }

        private void txtWind_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWind_KeyPress(object sender, KeyPressEventArgs e)
        {
            char src = e.KeyChar;

            if (!Char.IsDigit(src) && src != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMini_TextChanged(object sender, EventArgs e)
        {

        }
    }
}