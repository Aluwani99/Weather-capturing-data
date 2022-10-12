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
        public partial class WeatherForecast : Form
    {
        // Declaration of Varibles
        string[,] item;
        int run;
        // Declaration Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = WeatherStore; Integrated Security=True;";

        public WeatherForecast()
        {
            InitializeComponent();
            item = new string[30, 7];
            run = 0;
        }


        public void store()
        {
            string City = comboBxCity.Text, MiniTemp = txtMini.Text, MaxiTemp = txtMaxi.Text, Precip = txtPrecip.Text, Humidity = txtHumidty.Text, Wind = txtWind.Text;
            string Date = dateTimeCity.Text;

            // Storing 2D array that will be in rows and columns
            item[run, 0] = Date;
            item[run, 1] = City;
            item[run, 2] = MiniTemp;
            item[run, 3] = MaxiTemp;
            item[run, 4] = Precip;
            item[run, 5] = Humidity;
            item[run, 6] = Wind;
            run++;

            int Table = GridViewStore.Rows.Add();
            GridViewStore.Rows[Table].Cells[0].Value = Date;
            GridViewStore.Rows[Table].Cells[1].Value = City;
            GridViewStore.Rows[Table].Cells[2].Value = MiniTemp;
            GridViewStore.Rows[Table].Cells[3].Value = MaxiTemp;
            GridViewStore.Rows[Table].Cells[4].Value = Precip;
            GridViewStore.Rows[Table].Cells[5].Value = Humidity;
            GridViewStore.Rows[Table].Cells[6].Value = Wind;


        }

        private void WeatherForecast_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(DataFile);

            try
            {
                sqlCon.Open();
                String query = "insert into tblWeatherGeneral (City,Date,Minimum,Maximum,Preciption,Humidty,Wind) values('" + comboBxCity.Text + "' , '" 
                    + dateTimeCity.Text + "' , '" + txtMini.Text + "' , '" 
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
            catch (Exception ex)
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
            new GeneralUser().Show();
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

        private void btnSingle_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBxCity.SelectedText)
            {
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[0].Value = comboBxCity.SelectedText[0].ToString();
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[1].Value = this.item[run, 2];
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[2].Value = this.item[run, 3];
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[3].Value = this.item[run, 4];
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[4].Value = this.item[run, 5];
                GridViewStore.Rows[GridViewStore.Rows.Count - 1].Cells[5].Value = this.item[run, 6];
                run++;
            }
            GridViewStore.DataSource = null;
        }

        private void btnReportView_Click(object sender, EventArgs e)
        {
            string City = comboBxCity.Text, MiniTemp = txtMini.Text, MaxiTemp = txtMaxi.Text, Precip = txtPrecip.Text, Humidity = txtHumidty.Text, Wind = txtWind.Text;
            string Date = dateTimeCity.Text;

            // Storing 2D array that will be in rows and columns
            item[run, 0] = Date;
            item[run, 1] = City;
            item[run, 2] = MiniTemp;
            item[run, 3] = MaxiTemp;
            item[run, 4] = Precip;
            item[run, 5] = Humidity;
            item[run, 6] = Wind;
            run++;

            int Table = GridViewStore.Rows.Add();
            GridViewStore.Rows[Table].Cells[0].Value = Date;
            GridViewStore.Rows[Table].Cells[1].Value = City;
            GridViewStore.Rows[Table].Cells[2].Value = MiniTemp;
            GridViewStore.Rows[Table].Cells[3].Value = MaxiTemp;
            GridViewStore.Rows[Table].Cells[4].Value = Precip;
            GridViewStore.Rows[Table].Cells[5].Value = Humidity;
            GridViewStore.Rows[Table].Cells[6].Value = Wind;

            GridViewStore.DataSource = null;
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            GridViewStore.Rows.Clear();

            foreach (var item in comboBxCity.Items)
            {
                int i = GridViewStore.Rows.Add();
                int t = GridViewStore.Rows.Add();
                GridViewStore.Rows[i].Cells[0].Value = item.ToString();
                GridViewStore.Rows[t].Cells[1].Value = this.item[run, 2];
                GridViewStore.Rows[t].Cells[2].Value = this.item[run, 3];
                GridViewStore.Rows[t].Cells[3].Value = this.item[run, 4];
                GridViewStore.Rows[t].Cells[4].Value = this.item[run, 5];
                GridViewStore.Rows[t].Cells[5].Value = this.item[run, 6];
                run++;
            }
            GridViewStore.DataSource = null;
        }
    }
}
