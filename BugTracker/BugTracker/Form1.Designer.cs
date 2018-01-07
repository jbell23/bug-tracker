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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.codeInput = new System.Windows.Forms.RichTextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dataGridBug = new System.Windows.Forms.DataGridView();
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
            this.bugUpdate = new System.Windows.Forms.TabPage();
            this.solvedUpdate = new System.Windows.Forms.CheckBox();
            this.updateBut = new System.Windows.Forms.Button();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.auditHist = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.bugid_text = new System.Windows.Forms.TextBox();
            this.submitBut = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.fixerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.codeText = new System.Windows.Forms.RichTextBox();
            this.bugReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugDBDataSet = new BugTracker.bugDBDataSet();
            this.bugReportTableAdapter = new BugTracker.bugDBDataSetTableAdapters.bugReportTableAdapter();
            this.audit_solved = new System.Windows.Forms.CheckBox();
            this.tabCtrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBug)).BeginInit();
            this.bugUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUpdate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auditHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Controls.Add(this.bugUpdate);
            this.tabCtrl.Controls.Add(this.tabPage3);
            this.tabCtrl.Location = new System.Drawing.Point(2, 1);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1140, 557);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.codeInput);
            this.tabPage2.Controls.Add(this.refresh);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload Bug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(236, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Code";
            // 
            // codeInput
            // 
            this.codeInput.Location = new System.Drawing.Point(35, 322);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(478, 203);
            this.codeInput.TabIndex = 20;
            this.codeInput.Text = "";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(751, 423);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(153, 23);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Refresh Table";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(751, 376);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(153, 41);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dataGridBug
            // 
            this.dataGridBug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBug.Location = new System.Drawing.Point(6, 6);
            this.dataGridBug.Name = "dataGridBug";
            this.dataGridBug.Size = new System.Drawing.Size(1119, 198);
            this.dataGridBug.TabIndex = 16;
            this.dataGridBug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBug_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(751, 329);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 41);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Source File";
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(369, 232);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(144, 20);
            this.sourceInput.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Error Line";
            // 
            // errorInput
            // 
            this.errorInput.Location = new System.Drawing.Point(369, 272);
            this.errorInput.Name = "errorInput";
            this.errorInput.Size = new System.Drawing.Size(144, 20);
            this.errorInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class";
            // 
            // classInput
            // 
            this.classInput.Location = new System.Drawing.Point(204, 271);
            this.classInput.Name = "classInput";
            this.classInput.Size = new System.Drawing.Size(144, 20);
            this.classInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Method";
            // 
            // methodInput
            // 
            this.methodInput.Location = new System.Drawing.Point(204, 232);
            this.methodInput.Name = "methodInput";
            this.methodInput.Size = new System.Drawing.Size(144, 20);
            this.methodInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project";
            // 
            // projectInput
            // 
            this.projectInput.Location = new System.Drawing.Point(35, 271);
            this.projectInput.Name = "projectInput";
            this.projectInput.Size = new System.Drawing.Size(144, 20);
            this.projectInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(35, 232);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(144, 20);
            this.authorInput.TabIndex = 1;
            // 
            // bugUpdate
            // 
            this.bugUpdate.Controls.Add(this.solvedUpdate);
            this.bugUpdate.Controls.Add(this.updateBut);
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
            this.bugUpdate.Size = new System.Drawing.Size(1132, 531);
            this.bugUpdate.TabIndex = 2;
            this.bugUpdate.Text = "Update Bug";
            this.bugUpdate.UseVisualStyleBackColor = true;
            // 
            // solvedUpdate
            // 
            this.solvedUpdate.AutoSize = true;
            this.solvedUpdate.Location = new System.Drawing.Point(215, 347);
            this.solvedUpdate.Name = "solvedUpdate";
            this.solvedUpdate.Size = new System.Drawing.Size(59, 17);
            this.solvedUpdate.TabIndex = 34;
            this.solvedUpdate.Text = "Solved";
            this.solvedUpdate.UseVisualStyleBackColor = true;
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(172, 370);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(144, 29);
            this.updateBut.TabIndex = 33;
            this.updateBut.Text = "Update";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Source File";
            // 
            // sourceUpdate
            // 
            this.sourceUpdate.Location = new System.Drawing.Point(332, 282);
            this.sourceUpdate.Name = "sourceUpdate";
            this.sourceUpdate.Size = new System.Drawing.Size(144, 20);
            this.sourceUpdate.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Error Line";
            // 
            // errorUpdate
            // 
            this.errorUpdate.Location = new System.Drawing.Point(332, 322);
            this.errorUpdate.Name = "errorUpdate";
            this.errorUpdate.Size = new System.Drawing.Size(144, 20);
            this.errorUpdate.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Class";
            // 
            // classUpdate
            // 
            this.classUpdate.Location = new System.Drawing.Point(172, 321);
            this.classUpdate.Name = "classUpdate";
            this.classUpdate.Size = new System.Drawing.Size(144, 20);
            this.classUpdate.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Method";
            // 
            // methodUpdate
            // 
            this.methodUpdate.Location = new System.Drawing.Point(172, 282);
            this.methodUpdate.Name = "methodUpdate";
            this.methodUpdate.Size = new System.Drawing.Size(144, 20);
            this.methodUpdate.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Project";
            // 
            // projectUpdate
            // 
            this.projectUpdate.Location = new System.Drawing.Point(12, 321);
            this.projectUpdate.Name = "projectUpdate";
            this.projectUpdate.Size = new System.Drawing.Size(144, 20);
            this.projectUpdate.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Author";
            // 
            // authorUpdate
            // 
            this.authorUpdate.Location = new System.Drawing.Point(12, 282);
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
            this.dtblUpdate.Location = new System.Drawing.Point(8, 25);
            this.dtblUpdate.Name = "dtblUpdate";
            this.dtblUpdate.Size = new System.Drawing.Size(1119, 214);
            this.dtblUpdate.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.audit_solved);
            this.tabPage3.Controls.Add(this.auditHist);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.bugid_text);
            this.tabPage3.Controls.Add(this.submitBut);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.comment);
            this.tabPage3.Controls.Add(this.fixerName);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.codeText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1132, 531);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Fix Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // auditHist
            // 
            this.auditHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auditHist.Location = new System.Drawing.Point(42, 55);
            this.auditHist.Name = "auditHist";
            this.auditHist.Size = new System.Drawing.Size(240, 150);
            this.auditHist.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(158, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Bug id";
            // 
            // bugid_text
            // 
            this.bugid_text.Location = new System.Drawing.Point(133, 256);
            this.bugid_text.Name = "bugid_text";
            this.bugid_text.Size = new System.Drawing.Size(100, 20);
            this.bugid_text.TabIndex = 9;
            // 
            // submitBut
            // 
            this.submitBut.Location = new System.Drawing.Point(134, 427);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(75, 23);
            this.submitBut.TabIndex = 8;
            this.submitBut.Text = "Submit";
            this.submitBut.UseVisualStyleBackColor = true;
            this.submitBut.Click += new System.EventHandler(this.SubmitBut_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Audit Comment";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(158, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Fixer Id";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(61, 336);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(245, 52);
            this.comment.TabIndex = 5;
            // 
            // fixerName
            // 
            this.fixerName.Location = new System.Drawing.Point(106, 295);
            this.fixerName.Name = "fixerName";
            this.fixerName.Size = new System.Drawing.Size(152, 20);
            this.fixerName.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(118, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "Audit History";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(769, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Code";
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(404, 35);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(721, 315);
            this.codeText.TabIndex = 0;
            this.codeText.Text = "";
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
            // bugReportTableAdapter
            // 
            this.bugReportTableAdapter.ClearBeforeFill = true;
            // 
            // audit_solved
            // 
            this.audit_solved.AutoSize = true;
            this.audit_solved.Location = new System.Drawing.Point(150, 394);
            this.audit_solved.Name = "audit_solved";
            this.audit_solved.Size = new System.Drawing.Size(59, 17);
            this.audit_solved.TabIndex = 35;
            this.audit_solved.Text = "Solved";
            this.audit_solved.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 562);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBug)).EndInit();
            this.bugUpdate.ResumeLayout(false);
            this.bugUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtblUpdate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auditHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorInput;
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
        private System.Windows.Forms.CheckBox solvedUpdate;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox codeText;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.TextBox fixerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.RichTextBox codeInput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bugid_text;
        private System.Windows.Forms.DataGridView auditHist;
        private System.Windows.Forms.CheckBox audit_solved;
    }
}

