using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30";
        
        //SqlConnection mySqlConnection;
        SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");


        DataTable dtbl = new DataTable();

        public Form1()
        {
            String[] Data = new String[100];

            InitializeComponent();
            //populateListBox();
            populatedataGridBug();
            

        }

        public void populatedataGridBug()
        {

            using (mySqlConnection)
            {
                mySqlConnection.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                sqlDa.Fill(dtbl);

                dataGridBug.DataSource = dtbl;
            }
        }

        /*public void populateListBox()
        {
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

            String selcmd = "SELECT * FROM bugReport ";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbBugs.Items.Clear();


                while (mySqlDataReader.Read()){
                    lbBugs.Items.Add(mySqlDataReader["id"] + " || " +
                        mySqlDataReader["author"] + " || " +
                        mySqlDataReader["project"] + " || " +
                        mySqlDataReader["method"] + " || " +
                        mySqlDataReader["class"] + " || " +
                        mySqlDataReader["source_file"] + " || " +
                        mySqlDataReader["error_line"] + " || " +
                        mySqlDataReader["date"]);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("id" + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        public void cleartxtBoxes()
        {
            authorInput.Text = projectInput.Text = methodInput.Text = classInput.Text = sourceInput.Text = errorInput.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(authorInput.Text) ||
                string.IsNullOrEmpty(projectInput.Text) ||
                string.IsNullOrEmpty(methodInput.Text) ||
                string.IsNullOrEmpty(classInput.Text) ||
                string.IsNullOrEmpty(sourceInput.Text) ||
                string.IsNullOrEmpty(errorInput.Text))
            {
                MessageBox.Show("Error");
                rtnvalue = false;
            }

            return (rtnvalue);
        }

        public void insertRecord(String author, String project, String method, String Class, String source_file, String error_line, String commandString)
        {
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                try
                {
                    myCon.Open();

                    SqlCommand bugInsert = new SqlCommand(commandString, myCon);

                    bugInsert.Parameters.AddWithValue("@author", author);
                    bugInsert.Parameters.AddWithValue("@project", project);
                    bugInsert.Parameters.AddWithValue("@method", method);
                    bugInsert.Parameters.AddWithValue("@Class", Class);
                    bugInsert.Parameters.AddWithValue("@source_file", source_file);
                    bugInsert.Parameters.AddWithValue("@error_line", error_line);
                    bugInsert.ExecuteNonQuery();

                }

                catch (SqlException ex)
                {
                    MessageBox.Show("id" + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "INSERT INTO bugReport(author, project, method, Class, source_file, error_line) VALUES (@author, @project, @method, @Class, @source_file, @error_line)";

                insertRecord(authorInput.Text, projectInput.Text, methodInput.Text, classInput.Text, sourceInput.Text, errorInput.Text, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                sqlDa.Fill(dtbl);
                cleartxtBoxes();
            }
        }
    }
}