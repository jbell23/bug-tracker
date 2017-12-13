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
            this.dataGridBug = new System.Windows.Forms.DataGridView();
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
            this.bugUpdate = new System.Windows.Forms.TabPage();
            this.solvedUpdate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.classUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.methodUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.projectUpdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.authorUpdate = new System.Windows.Forms.TextBox();
            this.dtblUpdate = new System.Windows.Forms.DataGridView();
            this.bugReportTableAdapter = new BugTracker.bugDBDataSetTableAdapters.bugReportTableAdapter();
            this.updateBut = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDBDataSet)).BeginInit();
            this.bugUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.bugUpdate);
            tabControl1.Location = new System.Drawing.Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(845, 393);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bugs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clear);
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
            this.tabPage2.Size = new System.Drawing.Size(837, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload Bug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(49, 313);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dataGridBug
            // 
            this.dataGridBug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBug.Location = new System.Drawing.Point(194, 28);
            this.dataGridBug.Name = "dataGridBug";
            this.dataGridBug.Size = new System.Drawing.Size(636, 201);
            this.dataGridBug.TabIndex = 16;
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
            this.addBtn.Location = new System.Drawing.Point(49, 253);
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
            this.label7.Location = new System.Drawing.Point(64, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Source File";
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(21, 187);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(144, 20);
            this.sourceInput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Error Line";
            // 
            // errorInput
            // 
            this.errorInput.Location = new System.Drawing.Point(21, 227);
            this.errorInput.Name = "errorInput";
            this.errorInput.Size = new System.Drawing.Size(144, 20);
            this.errorInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class";
            // 
            // classInput
            // 
            this.classInput.Location = new System.Drawing.Point(21, 148);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(144, 20);
            this.classInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Method";
            // 
            // methodInput
            // 
            this.methodInput.Location = new System.Drawing.Point(21, 109);
            this.methodInput.Name = "methodInput";
            this.methodInput.Size = new System.Drawing.Size(144, 20);
            this.methodInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project";
            // 
            // projectInput
            // 
            this.projectInput.Location = new System.Drawing.Point(21, 70);
            this.projectInput.Name = "projectInput";
            this.projectInput.Size = new System.Drawing.Size(144, 20);
            this.projectInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(21, 31);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(144, 20);
            this.authorInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bugUpdate
            // 
            this.bugUpdate.Controls.Add(this.updateBut);
            this.bugUpdate.Controls.Add(this.solvedUpdate);
            this.bugUpdate.Controls.Add(this.label2);
            this.bugUpdate.Controls.Add(this.sourceUpdate);
            this.bugUpdate.Controls.Add(this.label8);
            this.bugUpdate.Controls.Add(this.errorUpdate);
            this.bugUpdate.Controls.Add(this.label9);
            this.bugUpdate.Controls.Add(this.classUpdate);
            this.bugUpdate.Controls.Add(this.label10);
            this.bugUpdate.Controls.Add(this.methodUpdate);
            this.bugUpdate.Controls.Add(this.label11);
            this.bugUpdate.Controls.Add(this.projectUpdate);
            this.bugUpdate.Controls.Add(this.label12);
            this.bugUpdate.Controls.Add(this.authorUpdate);
            this.bugUpdate.Controls.Add(this.dtblUpdate);
            this.bugUpdate.Location = new System.Drawing.Point(4, 22);
            this.bugUpdate.Name = "bugUpdate";
            this.bugUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.bugUpdate.Size = new System.Drawing.Size(837, 367);
            this.bugUpdate.TabIndex = 2;
            this.bugUpdate.Text = "Update Bug";
            this.bugUpdate.UseVisualStyleBackColor = true;
            // 
            // solvedUpdate
            // 
            this.solvedUpdate.AutoSize = true;
            this.solvedUpdate.Location = new System.Drawing.Point(224, 275);
            this.solvedUpdate.Name = "solvedUpdate";
            this.solvedUpdate.Size = new System.Drawing.Size(59, 17);
            this.solvedUpdate.TabIndex = 32;
            this.solvedUpdate.Text = "Solved";
            this.solvedUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Source File";
            // 
            // sourceUpdate
            // 
            this.sourceUpdate.Location = new System.Drawing.Point(339, 210);
            this.sourceUpdate.Name = "sourceUpdate";
            this.sourceUpdate.Size = new System.Drawing.Size(144, 20);
            this.sourceUpdate.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Error Line";
            // 
            // errorUpdate
            // 
            this.errorUpdate.Location = new System.Drawing.Point(339, 250);
            this.errorUpdate.Name = "errorUpdate";
            this.errorUpdate.Size = new System.Drawing.Size(144, 20);
            this.errorUpdate.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Class";
            // 
            // classUpdate
            // 
            this.classUpdate.Location = new System.Drawing.Point(179, 249);
            this.classUpdate.Name = "classUpdate";
            this.classUpdate.Size = new System.Drawing.Size(144, 20);
            this.classUpdate.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Method";
            // 
            // methodUpdate
            // 
            this.methodUpdate.Location = new System.Drawing.Point(179, 210);
            this.methodUpdate.Name = "methodUpdate";
            this.methodUpdate.Size = new System.Drawing.Size(144, 20);
            this.methodUpdate.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Project";
            // 
            // projectUpdate
            // 
            this.projectUpdate.Location = new System.Drawing.Point(19, 249);
            this.projectUpdate.Name = "projectUpdate";
            this.projectUpdate.Size = new System.Drawing.Size(144, 20);
            this.projectUpdate.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Author";
            // 
            // authorUpdate
            // 
            this.authorUpdate.Location = new System.Drawing.Point(19, 210);
            this.authorUpdate.Name = "authorUpdate";
            this.authorUpdate.Size = new System.Drawing.Size(144, 20);
            this.authorUpdate.TabIndex = 18;
            // 
            // dtblUpdate
            // 
            this.dtblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtblUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtblUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtblUpdate.Location = new System.Drawing.Point(6, 6);
            this.dtblUpdate.Name = "dtblUpdate";
            this.dtblUpdate.Size = new System.Drawing.Size(824, 185);
            this.dtblUpdate.TabIndex = 17;
            // 
            // bugReportTableAdapter
            // 
            this.bugReportTableAdapter.ClearBeforeFill = true;
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(208, 315);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(75, 25);
            this.updateBut.TabIndex = 33;
            this.updateBut.Text = "Update";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 398);
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
            this.bugUpdate.ResumeLayout(false);
            this.bugUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUpdate)).EndInit();
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
        private bugDBDataSet bugDBDataSet;
        private System.Windows.Forms.BindingSource bugReportBindingSource;
        private bugDBDataSetTableAdapters.bugReportTableAdapter bugReportTableAdapter;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TabPage bugUpdate;
        private System.Windows.Forms.DataGridView dtblUpdate;
        private System.Windows.Forms.CheckBox solvedUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox errorUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox classUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox methodUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox projectUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox authorUpdate;
        private System.Windows.Forms.Button updateBut;
    }
}

