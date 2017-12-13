namespace BugTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl tabControl1;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.Button();
            this.updateBut = new System.Windows.Forms.Button();
            this.dataGridBug = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcefileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solvedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bugReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugDBDataSet = new BugTracker.bugDBDataSet();
            this.addBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sourceInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.classInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.methodInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bugReportTableAdapter = new BugTracker.bugDBDataSetTableAdapters.bugReportTableAdapter();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Location = new System.Drawing.Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(845, 402);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bugs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clear);
            this.tabPage2.Controls.Add(this.updateBut);
            this.tabPage2.Controls.Add(this.dataGridBug);
            this.tabPage2.Controls.Add(this.addBtn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.sourceInput);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.errorInput);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.classInput);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.methodInput);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.projectInput);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.authorInput);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload Bug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(48, 327);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(447, 246);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(75, 23);
            this.updateBut.TabIndex = 17;
            this.updateBut.Text = "Update";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // dataGridBug
            // 
            this.dataGridBug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBug.AutoGenerateColumns = false;
            this.dataGridBug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.methodDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.sourcefileDataGridViewTextBoxColumn,
            this.errorlineDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.solvedDataGridViewCheckBoxColumn});
            this.dataGridBug.DataSource = this.bugReportBindingSource;
            this.dataGridBug.Location = new System.Drawing.Point(194, 28);
            this.dataGridBug.Name = "dataGridBug";
            this.dataGridBug.Size = new System.Drawing.Size(570, 201);
            this.dataGridBug.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 38;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 60;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 62;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "method";
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            this.methodDataGridViewTextBoxColumn.Width = 65;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 54;
            // 
            // sourcefileDataGridViewTextBoxColumn
            // 
            this.sourcefileDataGridViewTextBoxColumn.DataPropertyName = "source_file";
            this.sourcefileDataGridViewTextBoxColumn.HeaderText = "source_file";
            this.sourcefileDataGridViewTextBoxColumn.Name = "sourcefileDataGridViewTextBoxColumn";
            this.sourcefileDataGridViewTextBoxColumn.Width = 81;
            // 
            // errorlineDataGridViewTextBoxColumn
            // 
            this.errorlineDataGridViewTextBoxColumn.DataPropertyName = "error_line";
            this.errorlineDataGridViewTextBoxColumn.HeaderText = "error_line";
            this.errorlineDataGridViewTextBoxColumn.Name = "errorlineDataGridViewTextBoxColumn";
            this.errorlineDataGridViewTextBoxColumn.Width = 73;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 51;
            // 
            // solvedDataGridViewCheckBoxColumn
            // 
            this.solvedDataGridViewCheckBoxColumn.DataPropertyName = "solved";
            this.solvedDataGridViewCheckBoxColumn.HeaderText = "solved";
            this.solvedDataGridViewCheckBoxColumn.Name = "solvedDataGridViewCheckBoxColumn";
            this.solvedDataGridViewCheckBoxColumn.Width = 42;
            // 
            // bugReportBindingSource
            // 
            this.bugReportBindingSource.DataMember = "bugReport";
            this.bugReportBindingSource.DataSource = this.bugDBDataSet;
            // 
            // bugDBDataSet
            // 
            this.bugDBDataSet.DataSetName = "bugDBDataSet";
            this.bugDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(48, 298);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Source File";
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(20, 232);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(144, 20);
            this.sourceInput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Error Line";
            // 
            // errorInput
            // 
            this.errorInput.Location = new System.Drawing.Point(20, 272);
            this.errorInput.Name = "errorInput";
            this.errorInput.Size = new System.Drawing.Size(144, 20);
            this.errorInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class";
            // 
            // classInput
            // 
            this.classInput.Location = new System.Drawing.Point(20, 193);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(144, 20);
            this.classInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Method";
            // 
            // methodInput
            // 
            this.methodInput.Location = new System.Drawing.Point(20, 154);
            this.methodInput.Name = "methodInput";
            this.methodInput.Size = new System.Drawing.Size(144, 20);
            this.methodInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project";
            // 
            // projectInput
            // 
            this.projectInput.Location = new System.Drawing.Point(20, 115);
            this.projectInput.Name = "projectInput";
            this.projectInput.Size = new System.Drawing.Size(144, 20);
            this.projectInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(20, 76);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(144, 20);
            this.authorInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bugReportTableAdapter
            // 
            this.bugReportTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 407);
            this.Controls.Add(tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sourceInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox errorInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox classInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox methodInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridBug;
        private System.Windows.Forms.Button updateBut;
        private bugDBDataSet bugDBDataSet;
        private System.Windows.Forms.BindingSource bugReportBindingSource;
        private bugDBDataSetTableAdapters.bugReportTableAdapter bugReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcefileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solvedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button clear;
    }
}

