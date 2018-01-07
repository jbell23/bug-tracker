using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BugTracker
{
    /// <summary>
    /// This class sets up the connection strings, DataTables and two variables ('ID', 'solved').
    /// </summary>
    public partial class Form1 : Form
    {
        //Setting up connections to the database
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30";
        SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

        //Creating data tables
        DataTable dtbl = new DataTable();
        DataTable dtblUp = new DataTable();
        DataTable auditDtbl = new DataTable();

        int ID = 0;
        string solved;

        /// <summary>
        /// Initialising the form and using the populategridbug function.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            PopulatedataGridBug();
            this.Text = "Leeds Bug Tracker";

            dtblUpdate.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(DtblUpdate_RowHeaderMouseClick);
        }

        /// <summary>
        /// This class creates an sql data adapter and uses the data to fill up the data tables which were initialised in the previous section.
        /// These data sources are then used to fill the tables within the program.
        /// </summary>
        public void PopulatedataGridBug()
        {
            using (mySqlConnection)
            {
                mySqlConnection.Open();

                //Creating a dataAdapter which selects all data from the bug report table.
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                sqlDa.Fill(dtbl);
                sqlDa.Fill(dtblUp);

                dataGridBug.DataSource = dtbl;
                dtblUpdate.DataSource = dtblUp;

            }
        }
        /// <summary>
        /// This function is used to clear textboxes after the user has filled out a form. 
        /// This function is called on the button click to empty those text boxes.
        /// </summary>
        public void CleartxtBoxes()
        {
            authorInput.Text = projectInput.Text = methodInput.Text = classInput.Text = sourceInput.Text = errorInput.Text = codeInput.Text = comment.Text = fixerName.Text = "";
        }
        /// <summary>
        /// This method checks whether the inputs which the user has submitted are null or empty.
        /// </summary>
        /// <returns>If empty return error messagebox.</returns>
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
        /// <summary>
        /// This method takes all the values inputted by the user and associats them with the corresponding database table field.
        /// If there is an error with the data a messagebox will pop up and display the error.
        /// </summary>
        /// <param name="author">Used to refer to field in table.</param>
        /// <param name="project">Used to refer to field in table.</param>
        /// <param name="method">Used to refer to field in table.</param>
        /// <param name="Class">Used to refer to field in table.</param>
        /// <param name="source_file">Used to refer to field in table.</param>
        /// <param name="error_line">Used to refer to field in table.</param>
        /// <param name="code">Used to refer to field in table.</param>
        /// <param name="commandString"></param>
        public void InsertRecord(String author, String project, String method, String Class, String source_file, String error_line, String code, String commandString)
        {
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                try
                {
                    myCon.Open();

                    SqlCommand bugInsert = new SqlCommand(commandString, myCon);

                    //Attaching strings to rows in the database so the program knows what data to insert where.
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
        /// <summary>
        /// When add button is clicked, use checkinputs function then run commandString to insert the inputted data into the table.
        /// The DataTable is then cleared and repopulated with the new data.
        /// </summary>
        /// <param name="sender">Sends data from the object to the event handler.</param>
        /// <param name="e">Accept event argument.</param>
        public void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "INSERT INTO bugReport(author, project, method, Class, source_file, error_line, code) VALUES (@author, @project, @method, @Class, @source_file, @error_line, @code)";

                //Calling the InsertRecord function and filling it with the data the program has collected.
                InsertRecord(authorInput.Text, projectInput.Text, methodInput.Text, classInput.Text, sourceInput.Text, errorInput.Text, codeInput.Text, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtbl.Clear();
                sqlDa.Fill(dtbl);
                CleartxtBoxes();

            }
        }
        /// <summary>
        /// When a row header is clicked it moves all the associated data into textfields.
        /// This allows the user to be able to edit the information within.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// When the cell content is clicked in the data table, it moves the user to the third tab and displays the associated fields code into a rich textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridBug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //When function called, take the user to tab 3.
            tabCtrl.SelectedIndex = 3;

            if (e.RowIndex >= 0)
            {

                int i;
                i = dataGridBug.SelectedCells[0].RowIndex;

                //take id and code from selected cell into the new tab.
                ID = Convert.ToInt16(dataGridBug.Rows[e.RowIndex].Cells[0].Value.ToString());
                codeText.Text = dataGridBug.Rows[e.RowIndex].Cells[9].Value.ToString();

            }


        }
        /// <summary>
        /// Declaring the checkbox value. Associating the text boxes with database fields. If the function executes correctly a success messagebox will show.
        /// If not a messagebox containing the corresponding error will be displayed.
        /// </summary>
        /// <param name="author">Used to refer to field in table.</param>
        /// <param name="project">Used to refer to field in table.</param>
        /// <param name="method">Used to refer to field in table.</param>
        /// <param name="Class">Used to refer to field in table.</param>
        /// <param name="source_file">Used to refer to field in table.</param>
        /// <param name="error_line">Used to refer to field in table.</param>
        /// <param name="solved">Used to refer to field in table.</param>
        /// <param name="commandString"></param>
        public void UpdateRecord (String author, String project, String method, String Class, String source_file, String error_line, String solved, String commandString)
        {
            //If checkbox is checked/un-checked give the string solved a different value.
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

                    //Attaching strings to rows in the database so the program knows what data to insert where.
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
        /// <summary>
        /// When update button is clicked, make sure all fields have been then run commandString to insert the updated data into the table.
        /// The DataTable is then cleared and repopulated with the updated data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateBut_Click(object sender, EventArgs e)
        {
            if (authorUpdate.Text != "" && projectUpdate.Text != "" && methodUpdate.Text != "" && classUpdate.Text != "" && sourceUpdate.Text != "" && errorUpdate.Text != "")
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                String commandString = "UPDATE bugReport SET author=@author, project=@project, method=@method, Class=@Class, source_file=@source_file, error_line=@error_line, solved=@solved WHERE id=@id";

                UpdateRecord(authorUpdate.Text, projectUpdate.Text, methodUpdate.Text, classUpdate.Text, sourceUpdate.Text, errorUpdate.Text, solved, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtblUp.Clear();
                sqlDa.Fill(dtblUp);
                CleartxtBoxes();
            }

        }
        /// <summary>
        /// This method takes the user inputted values from the text boxes and adds them to String parameters.
        /// The query is then executed and textboxes are cleared.
        /// If the query is unsucesful in any way the user is show an error messagebox.
        /// </summary>
        /// <param name="code">Used to refer to associated field in table.</param>
        /// <param name="fixer_id">Used to refer to associated field in table.</param>
        /// <param name="audit_comment">Used to refer to associated field in table.</param>
        /// <param name="fixer_id_report">Used to refer to associated field in table.</param>
        /// <param name="solved">Used to refer to associated field in table.</param>
        /// <param name="commandString"></param>
        public void UpdateCode (String code, String fixer_id, String audit_comment, String fixer_id_report, String solved, String commandString)
        {
            if (audit_solved.Checked)
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
                    upCmd.Parameters.AddWithValue("@fixer_id_report", fixerName.Text);
                    upCmd.Parameters.AddWithValue("@fixer_id", fixerName.Text);
                    upCmd.Parameters.AddWithValue("@audit_comment", comment.Text);
                    upCmd.Parameters.AddWithValue("@code", codeText.Text);
                    upCmd.Parameters.AddWithValue("@solved", solved);
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

        /// <summary>
        /// When clear button is clicked all textboxes will be cleared of any input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            CleartxtBoxes();
        }

        private void UpdateBut_Click_1(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// When the refresh button is clicked this function is triggered, it then reloads the database data into the datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

            mySqlConnection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

            dtbl.Clear();
            sqlDa.Fill(dtbl);
        }
        /// <summary>
        /// This function is used to add data to two different tables according to the users inputs.
        /// The bugReport table will have certain fields updated and the fixers table will be given a new entry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if (fixerName.Text != "" && codeText.Text != "")
            {
                SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jbell\Documents\bugDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");

                mySqlConnection.Open();

                String commandString = "UPDATE bugReport SET fixer_id_report=@fixer_id_report, solved=@solved, code=@code WHERE id=@id; INSERT INTO Fixers(fixer_id,audit_comment,code,id) VALUES (@fixer_id, @audit_comment, @code,@id)";

                UpdateCode(fixerName.Text, codeText.Text, comment.Text, fixerName.Text, solved, commandString);

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bugReport", mySqlConnection);

                dtblUp.Clear();
                sqlDa.Fill(dtblUp);
                CleartxtBoxes();
            }
        }
    }
}