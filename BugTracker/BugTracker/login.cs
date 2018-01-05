using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login Form";
            this.AcceptButton = loginBtn;
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30";

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please Enter A Username And Password");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE name=@name AND password=@password", con);

                cmd.Parameters.AddWithValue("@name", userName.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}