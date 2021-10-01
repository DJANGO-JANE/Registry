
namespace Registry2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDash = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEditGender = new System.Windows.Forms.ComboBox();
            this.dtpEditDOB = new System.Windows.Forms.DateTimePicker();
            this.tbEditEmail = new System.Windows.Forms.TextBox();
            this.tbEditFname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbEditLname = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUserRep = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbYear0 = new System.Windows.Forms.ComboBox();
            this.cmbYear1 = new System.Windows.Forms.ComboBox();
            this.cmbAge0 = new System.Windows.Forms.ComboBox();
            this.cmbAge1 = new System.Windows.Forms.ComboBox();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnAge = new System.Windows.Forms.RadioButton();
            this.btnGenByYearOrAge = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDash
            // 
            this.dgvDash.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDash.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDash.EnableHeadersVisualStyles = false;
            this.dgvDash.Location = new System.Drawing.Point(916, 85);
            this.dgvDash.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgvDash.MultiSelect = false;
            this.dgvDash.Name = "dgvDash";
            this.dgvDash.RowHeadersVisible = false;
            this.dgvDash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDash.ShowEditingIcon = false;
            this.dgvDash.Size = new System.Drawing.Size(575, 660);
            this.dgvDash.TabIndex = 2;
            this.dgvDash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDash_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnGenRep);
            this.tabPage2.Controls.Add(this.dgvSearchResults);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.gb1);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPage2.Size = new System.Drawing.Size(876, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find & Edit User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search here :";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(119, 35);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(242, 24);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnUserRep);
            this.gb1.Controls.Add(this.btnDeleteUser);
            this.gb1.Controls.Add(this.tbEditLname);
            this.gb1.Controls.Add(this.tbAge);
            this.gb1.Controls.Add(this.label13);
            this.gb1.Controls.Add(this.tbID);
            this.gb1.Controls.Add(this.label12);
            this.gb1.Controls.Add(this.btnUpdate);
            this.gb1.Controls.Add(this.tbEditFname);
            this.gb1.Controls.Add(this.tbEditEmail);
            this.gb1.Controls.Add(this.dtpEditDOB);
            this.gb1.Controls.Add(this.cmbEditGender);
            this.gb1.Controls.Add(this.label11);
            this.gb1.Controls.Add(this.label10);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(512, 194);
            this.gb1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.gb1.Size = new System.Drawing.Size(350, 362);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Edit";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Last Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Gender :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "Date Of Birth :";
            // 
            // cmbEditGender
            // 
            this.cmbEditGender.FormattingEnabled = true;
            this.cmbEditGender.Location = new System.Drawing.Point(109, 149);
            this.cmbEditGender.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cmbEditGender.Name = "cmbEditGender";
            this.cmbEditGender.Size = new System.Drawing.Size(157, 22);
            this.cmbEditGender.TabIndex = 5;
            // 
            // dtpEditDOB
            // 
            this.dtpEditDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditDOB.Location = new System.Drawing.Point(109, 171);
            this.dtpEditDOB.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dtpEditDOB.Name = "dtpEditDOB";
            this.dtpEditDOB.Size = new System.Drawing.Size(144, 22);
            this.dtpEditDOB.TabIndex = 6;
            // 
            // tbEditEmail
            // 
            this.tbEditEmail.Location = new System.Drawing.Point(109, 126);
            this.tbEditEmail.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbEditEmail.Name = "tbEditEmail";
            this.tbEditEmail.Size = new System.Drawing.Size(175, 22);
            this.tbEditEmail.TabIndex = 7;
            this.tbEditEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEditEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbEditFname
            // 
            this.tbEditFname.Location = new System.Drawing.Point(109, 57);
            this.tbEditFname.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbEditFname.Name = "tbEditFname";
            this.tbEditFname.Size = new System.Drawing.Size(175, 22);
            this.tbEditFname.TabIndex = 8;
            this.tbEditFname.Validating += new System.ComponentModel.CancelEventHandler(this.tbEditFname_Validating);
            this.tbEditFname.Validated += new System.EventHandler(this.tbEditFname_Validated);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(237, 253);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 45);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 14);
            this.label12.TabIndex = 11;
            this.label12.Text = "ID :";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(109, 34);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "Age :";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(109, 103);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 14;
            // 
            // tbEditLname
            // 
            this.tbEditLname.Location = new System.Drawing.Point(109, 79);
            this.tbEditLname.Name = "tbEditLname";
            this.tbEditLname.Size = new System.Drawing.Size(175, 22);
            this.tbEditLname.TabIndex = 15;
            this.tbEditLname.Validating += new System.ComponentModel.CancelEventHandler(this.tbEditLname_Validating);
            this.tbEditLname.Validated += new System.EventHandler(this.tbEditLname_Validated);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteUser.Location = new System.Drawing.Point(10, 253);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(99, 45);
            this.btnDeleteUser.TabIndex = 16;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUserRep
            // 
            this.btnUserRep.Location = new System.Drawing.Point(123, 253);
            this.btnUserRep.Name = "btnUserRep";
            this.btnUserRep.Size = new System.Drawing.Size(99, 45);
            this.btnUserRep.TabIndex = 17;
            this.btnUserRep.Text = "Generate Report";
            this.btnUserRep.UseVisualStyleBackColor = true;
            this.btnUserRep.Click += new System.EventHandler(this.btnUserRep_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(364, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSearchResults.Location = new System.Drawing.Point(7, 106);
            this.dgvSearchResults.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersVisible = false;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(491, 496);
            this.dgvSearchResults.TabIndex = 5;
            this.dgvSearchResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResults_CellContentDoubleClick);
            this.dgvSearchResults.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearchResults_CellMouseDoubleClick);
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(358, 614);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(140, 35);
            this.btnGenRep.TabIndex = 6;
            this.btnGenRep.Text = "Generate Reports";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenByYearOrAge);
            this.groupBox1.Controls.Add(this.rbtnAge);
            this.groupBox1.Controls.Add(this.rbtnYear);
            this.groupBox1.Controls.Add(this.cmbAge1);
            this.groupBox1.Controls.Add(this.cmbAge0);
            this.groupBox1.Controls.Add(this.cmbYear1);
            this.groupBox1.Controls.Add(this.cmbYear0);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(518, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Year :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Age :";
            // 
            // cmbYear0
            // 
            this.cmbYear0.FormattingEnabled = true;
            this.cmbYear0.Location = new System.Drawing.Point(116, 21);
            this.cmbYear0.Name = "cmbYear0";
            this.cmbYear0.Size = new System.Drawing.Size(87, 23);
            this.cmbYear0.TabIndex = 10;
            this.cmbYear0.SelectedIndexChanged += new System.EventHandler(this.cmbYear0_SelectedIndexChanged);
            // 
            // cmbYear1
            // 
            this.cmbYear1.FormattingEnabled = true;
            this.cmbYear1.Location = new System.Drawing.Point(234, 21);
            this.cmbYear1.Name = "cmbYear1";
            this.cmbYear1.Size = new System.Drawing.Size(96, 23);
            this.cmbYear1.TabIndex = 11;
            this.cmbYear1.SelectedIndexChanged += new System.EventHandler(this.cmbYear1_SelectedIndexChanged);
            // 
            // cmbAge0
            // 
            this.cmbAge0.Enabled = false;
            this.cmbAge0.FormattingEnabled = true;
            this.cmbAge0.Location = new System.Drawing.Point(116, 64);
            this.cmbAge0.Name = "cmbAge0";
            this.cmbAge0.Size = new System.Drawing.Size(87, 23);
            this.cmbAge0.TabIndex = 12;
            // 
            // cmbAge1
            // 
            this.cmbAge1.Enabled = false;
            this.cmbAge1.FormattingEnabled = true;
            this.cmbAge1.Location = new System.Drawing.Point(231, 64);
            this.cmbAge1.Name = "cmbAge1";
            this.cmbAge1.Size = new System.Drawing.Size(99, 23);
            this.cmbAge1.TabIndex = 13;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Checked = true;
            this.rbtnYear.Location = new System.Drawing.Point(9, 33);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(14, 13);
            this.rbtnYear.TabIndex = 14;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // rbtnAge
            // 
            this.rbtnAge.AutoSize = true;
            this.rbtnAge.Location = new System.Drawing.Point(8, 67);
            this.rbtnAge.Name = "rbtnAge";
            this.rbtnAge.Size = new System.Drawing.Size(14, 13);
            this.rbtnAge.TabIndex = 15;
            this.rbtnAge.UseVisualStyleBackColor = true;
            this.rbtnAge.CheckedChanged += new System.EventHandler(this.rbtnAge_CheckedChanged);
            // 
            // btnGenByYearOrAge
            // 
            this.btnGenByYearOrAge.Location = new System.Drawing.Point(197, 124);
            this.btnGenByYearOrAge.Name = "btnGenByYearOrAge";
            this.btnGenByYearOrAge.Size = new System.Drawing.Size(133, 39);
            this.btnGenByYearOrAge.TabIndex = 16;
            this.btnGenByYearOrAge.Text = "Generate Report";
            this.btnGenByYearOrAge.UseVisualStyleBackColor = true;
            this.btnGenByYearOrAge.Click += new System.EventHandler(this.btnGenByYearOrAge_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.tbLname);
            this.tabPage1.Controls.Add(this.tbFname);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtp1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabPage1.Size = new System.Drawing.Size(876, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User";
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(322, 160);
            this.tbFname.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(200, 24);
            this.tbFname.TabIndex = 1;
            this.tbFname.Validating += new System.ComponentModel.CancelEventHandler(this.tbFname_Validating);
            this.tbFname.Validated += new System.EventHandler(this.tbFname_Validated);
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(322, 210);
            this.tbLname.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(200, 24);
            this.tbLname.TabIndex = 2;
            this.tbLname.Validating += new System.ComponentModel.CancelEventHandler(this.tbLname_Validating);
            this.tbLname.Validated += new System.EventHandler(this.tbLname_Validated);
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(322, 295);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(228, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 405);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 55);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(322, 330);
            this.dtp1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(144, 24);
            this.dtp1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Of Birth :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(324, 255);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 24);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(328, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 62);
            this.label14.TabIndex = 13;
            this.label14.Text = "Register now !";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 685);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 790);
            this.Controls.Add(this.dgvDash);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDash;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenByYearOrAge;
        private System.Windows.Forms.RadioButton rbtnAge;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.ComboBox cmbAge1;
        private System.Windows.Forms.ComboBox cmbAge0;
        private System.Windows.Forms.ComboBox cmbYear1;
        private System.Windows.Forms.ComboBox cmbYear0;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnUserRep;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox tbEditLname;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbEditFname;
        private System.Windows.Forms.TextBox tbEditEmail;
        private System.Windows.Forms.DateTimePicker dtpEditDOB;
        private System.Windows.Forms.ComboBox cmbEditGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
    }
}

