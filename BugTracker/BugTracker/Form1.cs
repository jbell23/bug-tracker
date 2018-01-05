using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            PopulatedataGridBug();
            this.Text = "Leeds Bug Tracker";


            //dataGridBug.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridBug_RowHeaderMouseDoubleClick);
            dtblUpdate.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(DtblUpdate_RowHeaderMouseClick);
        }

        public void PopulatedataGridBug()
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

        public void CleartxtBoxes()
        {
            authorInput.Text = projectInput.Text = methodInput.Text = classInput.Text = sourceInput.Text = errorInput.Text = codeInput.Text = comment.Text = fixerName.Text = "";
        }

        public bool CheckInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(authorInput.Text) ||
                string.IsNullOrEmpty(projectInput.Text) ||
                string.IsNullOrEmpty(methodInput.Text) ||
                string.IsNullOrEmpty(classInput.Text) ||
                string.IsNullOrEmpty(sourceInput.Text) ||
                string.IsNullOrEmpty(errorInput.Text) ||
                string.IsNullOrEmpty(codeInput.Text))
            {
                MessageBox.Show("Error - Inputs Incorrect");
                rtnvalue = false;
            }
           return (rtnvalue);
        }

        public void InsertRecord(String author, String project, String method, String Class, String source_file, String error_line, String code, String commandString)
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
                    bugInsert.Parameters.AddWithValue("@code", code);
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

        public void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "INSERT INTO bugReport(author, project, method, Class, source_file, error_line, code) VALUES (@author, @project, @method, @Class, @source_file, @error_line, @code)";

                InsertRecord(authorInput.Text, projectInput.Text, methodInput.Text, classInput.Text, sourceInput.Text, errorInput.Text, codeInput.Text, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtbl.Clear();
                sqlDa.Fill(dtbl);
                CleartxtBoxes();

            }
        }

        public void DtblUpdate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt16(dataGridBug.Rows[e.RowIndex].Cells[0].Value.ToString());
            authorUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[1].Value.ToString();
            projectUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[2].Value.ToString();
            methodUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[3].Value.ToString();
            classUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[4].Value.ToString();
            sourceUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[5].Value.ToString();
            errorUpdate.Text = dataGridBug.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
        private void DataGridBug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabCtrl.SelectedIndex = 3;

            if (e.RowIndex >= 0)
            {
                int i;
                i = dataGridBug.SelectedCells[0].RowIndex;

                ID = Convert.ToInt16(dataGridBug.Rows[e.RowIndex].Cells[0].Value.ToString());
                codeText.Text = dataGridBug.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        public void UpdateRecord (String author, String project, String method, String Class, String source_file, String error_line, String solved, String commandString)
        {
            if (solvedUpdate.Checked)
            {
                solved = "Solved";
            }
            else
            {
                solved = "Un-solved";
            }
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                try
                {
                    myCon.Open();

                    SqlCommand upCmd = new SqlCommand(commandString, myCon);

                    upCmd.Parameters.AddWithValue("@id", ID);
                    upCmd.Parameters.AddWithValue("@author", authorUpdate.Text);
                    upCmd.Parameters.AddWithValue("@project", projectUpdate.Text);
                    upCmd.Parameters.AddWithValue("@method", methodUpdate.Text);
                    upCmd.Parameters.AddWithValue("@Class", classUpdate.Text);
                    upCmd.Parameters.AddWithValue("@source_file", sourceUpdate.Text);
                    upCmd.Parameters.AddWithValue("@error_line", errorUpdate.Text);
                    upCmd.Parameters.AddWithValue("@solved", solved);
                    upCmd.ExecuteNonQuery();
                    MessageBox.Show("successful");

                    myCon.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("@id" + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateBut_Click(object sender, EventArgs e)
        {
            if (authorUpdate.Text != "" && projectUpdate.Text != "" && methodUpdate.Text != "" && classUpdate.Text != "" && sourceUpdate.Text != "" && errorUpdate.Text != "")
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                //mySqlConnection.Open();

                String commandString = "UPDATE bugReport SET author=@author, project=@project, method=@method, Class=@Class, source_file=@source_file, error_line=@error_line, solved=@solved WHERE id=@id";

                UpdateRecord(authorUpdate.Text, projectUpdate.Text, methodUpdate.Text, classUpdate.Text, sourceUpdate.Text, errorUpdate.Text, solved, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtblUp.Clear();
                sqlDa.Fill(dtblUp);
                CleartxtBoxes();
            }

        }
        public void UpdateCode (String code, String fixer_id, String audit_comment, String fixer_id_report, String commandString)
        {
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                try
                {
                    myCon.Open();

                    SqlCommand upCmd = new SqlCommand(commandString, myCon);

                    upCmd.Parameters.AddWithValue("@id", ID);
                    upCmd.Parameters.AddWithValue("@fixer_id_report", fixerName.Text);
                    upCmd.Parameters.AddWithValue("@fixer_id", fixerName.Text);
                    upCmd.Parameters.AddWithValue("@audit_comment", comment.Text);
                    upCmd.Parameters.AddWithValue("@code", codeText.Text);
                    //upCmd.Parameters.AddWithValue("@id", bugid_text.Text);
                    upCmd.ExecuteNonQuery();
                    MessageBox.Show("succesful");
                    CleartxtBoxes();


                    myCon.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("@id" + ".." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            CleartxtBoxes();
        }

        private void UpdateBut_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

            mySqlConnection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

            dtbl.Clear();
            sqlDa.Fill(dtbl);
        }

        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if (fixerName.Text != "" && codeText.Text != "")
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "UPDATE bugReport SET fixer_id_report=@fixer_id_report, code=@code WHERE id=@id; INSERT INTO Fixers(fixer_id,audit_comment,code,id) VALUES (@fixer_id, @audit_comment, @code,@id)";

                UpdateCode(fixerName.Text, codeText.Text, comment.Text, fixerName.Text, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtblUp.Clear();
                sqlDa.Fill(dtblUp);
                CleartxtBoxes();
            }
        }
    }
}