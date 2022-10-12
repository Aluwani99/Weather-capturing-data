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
 * 
**/

namespace WeatherStore
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        // Declaration Varibles
        String DataFile = @"Data Source = DESKTOP-SSH67JG\SQLEXPRESS; Initial Catalog = WeatherStore; Integrated Security=True;";


        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlCon = new SqlConnection(DataFile);
            try
            {
                sqlCon.Open();
                String query = "insert into tblUsername (Email,Username,Password,ConPassword,UserType) values('" + txtEmail.Text + "' , '" + txtUsername.Text + "' , '"
                    + txtPassword.Text + "' , '" + txtConFirm.Text + "', '" + txtUsertype.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();
                               
                MessageBox.Show("You have register account now can login", "WELCOME", MessageBoxButtons.OK);
                Form1 log = new Form1();
                log.Show();
                this.Hide();
                this.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
