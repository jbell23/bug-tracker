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
        DataTable dtblUp = new DataTable();

        int ID = 0;
        string solved;

        public Form1()
        {
            String[] Data = new String[100];

            InitializeComponent();
            //populateListBox();
            populatedataGridBug();

            //dataGridBug.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridBug_RowHeaderMouseDoubleClick);
            dtblUpdate.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dtblUpdate_RowHeaderMouseClick);
        }

        public void populatedataGridBug()
        {

            using (mySqlConnection)
            {
                mySqlConnection.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                sqlDa.Fill(dtbl);
                sqlDa.Fill(dtblUp);

                dataGridBug.DataSource = dtbl;
                dtblUpdate.DataSource = dtblUp;
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

        public void addBtn_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "INSERT INTO bugReport(author, project, method, Class, source_file, error_line) VALUES (@author, @project, @method, @Class, @source_file, @error_line)";

                insertRecord(authorInput.Text, projectInput.Text, methodInput.Text, classInput.Text, sourceInput.Text, errorInput.Text, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtbl.Clear();
                sqlDa.Fill(dtbl);
                cleartxtBoxes();

            }
        }

        /*public void dataGridBug_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt16(dataGridBug.Rows[e.RowIndex].Cells[0].Value.ToString());
            authorInput.Text = dataGridBug.Rows[e.RowIndex].Cells[1].Value.ToString();
            projectInput.Text = dataGridBug.Rows[e.RowIndex].Cells[2].Value.ToString();
            methodInput.Text = dataGridBug.Rows[e.RowIndex].Cells[3].Value.ToString();
            classInput.Text = dataGridBug.Rows[e.RowIndex].Cells[4].Value.ToString();
            sourceInput.Text = dataGridBug.Rows[e.RowIndex].Cells[5].Value.ToString();
            errorInput.Text = dataGridBug.Rows[e.RowIndex].Cells[6].Value.ToString();
        }*/

        public void dtblUpdate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt16(dataGridBug.Rows[e.RowIndex].Cells[0].Value.ToString());
            authorUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[1].Value.ToString();
            projectUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[2].Value.ToString();
            methodUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[3].Value.ToString();
            classUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[4].Value.ToString();
            sourceUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[5].Value.ToString();
            errorUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        public void updateBut_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cleartxtBoxes();
        }

        private void updateBut_Click_1(object sender, EventArgs e)
        {
            if (solvedUpdate.Checked == true)
            {
                solved = "Solved";
            }

            if (authorInput.Text != "" && projectInput.Text != "" && methodInput.Text != "" && classInput.Text != "" && sourceInput.Text != "" && errorInput.Text != "")
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                SqlCommand upCmd = new SqlCommand("UPDATE bugReport set author=@author, project=@project, method=@method, Class=@Class, source_file=@source_file, error_line=@error_line, solved=@solved WHERE id=@id", mySqlConnection);
                mySqlConnection.Open();
                upCmd.Parameters.AddWithValue("@id", ID);
                upCmd.Parameters.AddWithValue("@author", authorInput.Text);
                upCmd.Parameters.AddWithValue("@project", projectInput.Text);
                upCmd.Parameters.AddWithValue("@method", methodInput.Text);
                upCmd.Parameters.AddWithValue("@Class", classInput.Text);
                upCmd.Parameters.AddWithValue("@source_file", sourceInput.Text);
                upCmd.Parameters.AddWithValue("@error_line", errorInput.Text);
                upCmd.Parameters.AddWithValue("@solved", solved);
                upCmd.ExecuteNonQuery();
                MessageBox.Show("succesful");
                mySqlConnection.Close();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtbl.Clear();
                sqlDa.Fill(dtbl);
            }
            else
            {
                MessageBox.Show("didnt work");
            }
        }
    }
}