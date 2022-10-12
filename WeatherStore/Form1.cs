using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
/**
 * Author : Aluwani Mahlatse Rambau
 * Student Number : 19010010
 * Programming 2A Assessment
 * Contact no : 0676225015
 * Email : 19010010@rcconnect.co.za
**/

namespace WeatherStore
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaration Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = WeatherStore; Integrated Security=True;";

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(DataFile);

            try
            {
                sqlCon.Open();
                String query = "SELECT * FROM tblUsername WHERE Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                String cmbItemValue = comboBxSelect.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i =0; i<dt.Rows.Count; i++) 
                    {
                        if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You Are Login As "+dt.Rows[i][2]);
                            if (comboBxSelect.SelectedIndex == 0) 
                            {

                            }
                        }
                    }
                }
                sqlCmd.ExecuteNonQuery();
                int count = 0;
                SqlDataReader dr = sqlCmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                 MessageBox.Show("Username and password is correct");
                 WeatherAdmin adm = new WeatherAdmin();
                 adm.Show();
                 this.Hide();
                }
                else
                {
                 WeatherForecast we = new WeatherForecast();
                 we.Show();
                 this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }
    

    private void btnRegister_Click(object sender, EventArgs e)
    {
        new Registration().Show();
        this.Hide();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void txtUsername_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void ShowAndHide_CheckedChanged(object sender, EventArgs e)
    {
        if (ShowAndHide.Checked)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        else
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }

        private void comboBxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


           
