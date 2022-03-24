namespace Covid
{
    partial class PatientForm
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ptrecovereddsv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.bedwardlb = new System.Windows.Forms.Label();
            this.timedatelb = new System.Windows.Forms.Label();
            this.doblb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notrecoveredrb = new System.Windows.Forms.RadioButton();
            this.recoveredrb = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ptnumtb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.testtb = new System.Windows.Forms.TextBox();
            this.citytb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.mnumtb = new System.Windows.Forms.TextBox();
            this.pnumtb = new System.Windows.Forms.TextBox();
            this.cnictb = new System.Windows.Forms.TextBox();
            this.permaddresstb = new System.Windows.Forms.RichTextBox();
            this.presentaddtb = new System.Windows.Forms.RichTextBox();
            this.pobirthtb = new System.Windows.Forms.TextBox();
            this.f_hnametb = new System.Windows.Forms.TextBox();
            this.lnametb = new System.Windows.Forms.TextBox();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.admittb = new System.Windows.Forms.Button();
            this.gendergb = new System.Windows.Forms.GroupBox();
            this.xrb = new System.Windows.Forms.RadioButton();
            this.femalerb = new System.Windows.Forms.RadioButton();
            this.malerb = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bloodgroupcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrecovereddsv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gendergb.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ptrecovereddsv);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Patient Recovered";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ptrecovereddsv
            // 
            this.ptrecovereddsv.AllowUserToAddRows = false;
            this.ptrecovereddsv.AllowUserToDeleteRows = false;
            this.ptrecovereddsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptrecovereddsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptrecovereddsv.Location = new System.Drawing.Point(0, 0);
            this.ptrecovereddsv.Name = "ptrecovereddsv";
            this.ptrecovereddsv.ReadOnly = true;
            this.ptrecovereddsv.Size = new System.Drawing.Size(768, 400);
            this.ptrecovereddsv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchbtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.ptnumtb);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admit Patient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(105, 100);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(165, 37);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search Patient";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.acceptbtn);
            this.groupBox2.Controls.Add(this.bedwardlb);
            this.groupBox2.Controls.Add(this.timedatelb);
            this.groupBox2.Controls.Add(this.doblb);
            this.groupBox2.Controls.Add(this.namelb);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(339, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 317);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient";
            // 
            // acceptbtn
            // 
            this.acceptbtn.Location = new System.Drawing.Point(95, 261);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(217, 39);
            this.acceptbtn.TabIndex = 7;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // bedwardlb
            // 
            this.bedwardlb.AutoSize = true;
            this.bedwardlb.Location = new System.Drawing.Point(181, 127);
            this.bedwardlb.Name = "bedwardlb";
            this.bedwardlb.Size = new System.Drawing.Size(0, 13);
            this.bedwardlb.TabIndex = 6;
            // 
            // timedatelb
            // 
            this.timedatelb.AutoSize = true;
            this.timedatelb.Location = new System.Drawing.Point(181, 97);
            this.timedatelb.Name = "timedatelb";
            this.timedatelb.Size = new System.Drawing.Size(0, 13);
            this.timedatelb.TabIndex = 5;
            // 
            // doblb
            // 
            this.doblb.AutoSize = true;
            this.doblb.Location = new System.Drawing.Point(181, 64);
            this.doblb.Name = "doblb";
            this.doblb.Size = new System.Drawing.Size(0, 13);
            this.doblb.TabIndex = 4;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Location = new System.Drawing.Point(181, 35);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(0, 13);
            this.namelb.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notrecoveredrb);
            this.groupBox3.Controls.Add(this.recoveredrb);
            this.groupBox3.Location = new System.Drawing.Point(28, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recovered";
            // 
            // notrecoveredrb
            // 
            this.notrecoveredrb.AutoSize = true;
            this.notrecoveredrb.Location = new System.Drawing.Point(7, 53);
            this.notrecoveredrb.Name = "notrecoveredrb";
            this.notrecoveredrb.Size = new System.Drawing.Size(39, 17);
            this.notrecoveredrb.TabIndex = 1;
            this.notrecoveredrb.TabStop = true;
            this.notrecoveredrb.Text = "No";
            this.notrecoveredrb.UseVisualStyleBackColor = true;
            // 
            // recoveredrb
            // 
            this.recoveredrb.AutoSize = true;
            this.recoveredrb.Location = new System.Drawing.Point(6, 29);
            this.recoveredrb.Name = "recoveredrb";
            this.recoveredrb.Size = new System.Drawing.Size(43, 17);
            this.recoveredrb.TabIndex = 0;
            this.recoveredrb.TabStop = true;
            this.recoveredrb.Text = "Yes";
            this.recoveredrb.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Bed/Ward No:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Time/Date of admission:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Date of Birth:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name:";
            // 
            // ptnumtb
            // 
            this.ptnumtb.Location = new System.Drawing.Point(149, 54);
            this.ptnumtb.Name = "ptnumtb";
            this.ptnumtb.Size = new System.Drawing.Size(165, 20);
            this.ptnumtb.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Patient Mobile Number:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.testtb);
            this.tabPage1.Controls.Add(this.citytb);
            this.tabPage1.Controls.Add(this.emailtb);
            this.tabPage1.Controls.Add(this.mnumtb);
            this.tabPage1.Controls.Add(this.pnumtb);
            this.tabPage1.Controls.Add(this.cnictb);
            this.tabPage1.Controls.Add(this.permaddresstb);
            this.tabPage1.Controls.Add(this.presentaddtb);
            this.tabPage1.Controls.Add(this.pobirthtb);
            this.tabPage1.Controls.Add(this.f_hnametb);
            this.tabPage1.Controls.Add(this.lnametb);
            this.tabPage1.Controls.Add(this.fnametb);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.admittb);
            this.tabPage1.Controls.Add(this.gendergb);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.bloodgroupcb);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dobpicker);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 345);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Test (p or n):";
            // 
            // testtb
            // 
            this.testtb.Location = new System.Drawing.Point(143, 342);
            this.testtb.Name = "testtb";
            this.testtb.Size = new System.Drawing.Size(200, 20);
            this.testtb.TabIndex = 29;
            // 
            // citytb
            // 
            this.citytb.Location = new System.Drawing.Point(454, 128);
            this.citytb.Name = "citytb";
            this.citytb.Size = new System.Drawing.Size(200, 20);
            this.citytb.TabIndex = 25;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(454, 101);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(200, 20);
            this.emailtb.TabIndex = 23;
            // 
            // mnumtb
            // 
            this.mnumtb.Location = new System.Drawing.Point(454, 71);
            this.mnumtb.Name = "mnumtb";
            this.mnumtb.Size = new System.Drawing.Size(200, 20);
            this.mnumtb.TabIndex = 20;
            // 
            // pnumtb
            // 
            this.pnumtb.Location = new System.Drawing.Point(454, 44);
            this.pnumtb.Name = "pnumtb";
            this.pnumtb.Size = new System.Drawing.Size(200, 20);
            this.pnumtb.TabIndex = 19;
            // 
            // cnictb
            // 
            this.cnictb.Location = new System.Drawing.Point(454, 18);
            this.cnictb.Name = "cnictb";
            this.cnictb.Size = new System.Drawing.Size(200, 20);
            this.cnictb.TabIndex = 16;
            // 
            // permaddresstb
            // 
            this.permaddresstb.Location = new System.Drawing.Point(143, 258);
            this.permaddresstb.Name = "permaddresstb";
            this.permaddresstb.Size = new System.Drawing.Size(200, 67);
            this.permaddresstb.TabIndex = 15;
            this.permaddresstb.Text = "";
            // 
            // presentaddtb
            // 
            this.presentaddtb.Location = new System.Drawing.Point(143, 184);
            this.presentaddtb.Name = "presentaddtb";
            this.presentaddtb.Size = new System.Drawing.Size(200, 67);
            this.presentaddtb.TabIndex = 12;
            this.presentaddtb.Text = "";
            // 
            // pobirthtb
            // 
            this.pobirthtb.Location = new System.Drawing.Point(143, 125);
            this.pobirthtb.Name = "pobirthtb";
            this.pobirthtb.Size = new System.Drawing.Size(200, 20);
            this.pobirthtb.TabIndex = 8;
            // 
            // f_hnametb
            // 
            this.f_hnametb.Location = new System.Drawing.Point(143, 71);
            this.f_hnametb.Name = "f_hnametb";
            this.f_hnametb.Size = new System.Drawing.Size(200, 20);
            this.f_hnametb.TabIndex = 5;
            // 
            // lnametb
            // 
            this.lnametb.Location = new System.Drawing.Point(143, 44);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(200, 20);
            this.lnametb.TabIndex = 2;
            // 
            // fnametb
            // 
            this.fnametb.Location = new System.Drawing.Point(143, 17);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(200, 20);
            this.fnametb.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Dry Cough",
            "Fever",
            "Chest Pain",
            "Shortness of Breath",
            "Fatigue",
            "Headache",
            "Vomit",
            "Loss of smell",
            "Loss of taste",
            "Diarrhea"});
            this.checkedListBox1.Location = new System.Drawing.Point(454, 257);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 79);
            this.checkedListBox1.TabIndex = 28;
            // 
            // admittb
            // 
            this.admittb.Location = new System.Drawing.Point(454, 342);
            this.admittb.Name = "admittb";
            this.admittb.Size = new System.Drawing.Size(200, 34);
            this.admittb.TabIndex = 27;
            this.admittb.Text = "Admit Patient";
            this.admittb.UseVisualStyleBackColor = true;
            this.admittb.Click += new System.EventHandler(this.admittb_Click);
            // 
            // gendergb
            // 
            this.gendergb.Controls.Add(this.xrb);
            this.gendergb.Controls.Add(this.femalerb);
            this.gendergb.Controls.Add(this.malerb);
            this.gendergb.Location = new System.Drawing.Point(454, 156);
            this.gendergb.Name = "gendergb";
            this.gendergb.Size = new System.Drawing.Size(200, 95);
            this.gendergb.TabIndex = 26;
            this.gendergb.TabStop = false;
            this.gendergb.Text = "Gender";
            // 
            // xrb
            // 
            this.xrb.AutoSize = true;
            this.xrb.Location = new System.Drawing.Point(7, 68);
            this.xrb.Name = "xrb";
            this.xrb.Size = new System.Drawing.Size(32, 17);
            this.xrb.TabIndex = 2;
            this.xrb.TabStop = true;
            this.xrb.Text = "X";
            this.xrb.UseVisualStyleBackColor = true;
            // 
            // femalerb
            // 
            this.femalerb.AutoSize = true;
            this.femalerb.Location = new System.Drawing.Point(7, 44);
            this.femalerb.Name = "femalerb";
            this.femalerb.Size = new System.Drawing.Size(59, 17);
            this.femalerb.TabIndex = 1;
            this.femalerb.TabStop = true;
            this.femalerb.Text = "Female";
            this.femalerb.UseVisualStyleBackColor = true;
            // 
            // malerb
            // 
            this.malerb.AutoSize = true;
            this.malerb.Location = new System.Drawing.Point(7, 20);
            this.malerb.Name = "malerb";
            this.malerb.Size = new System.Drawing.Size(48, 17);
            this.malerb.TabIndex = 0;
            this.malerb.TabStop = true;
            this.malerb.Text = "Male";
            this.malerb.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "City:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mobile Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CNIC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Permenant Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Present Address:";
            // 
            // bloodgroupcb
            // 
            this.bloodgroupcb.FormattingEnabled = true;
            this.bloodgroupcb.Items.AddRange(new object[] {
            "A-",
            "A+",
            "B-",
            "B+",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodgroupcb.Location = new System.Drawing.Point(143, 156);
            this.bloodgroupcb.Name = "bloodgroupcb";
            this.bloodgroupcb.Size = new System.Drawing.Size(200, 21);
            this.bloodgroupcb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blood Group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Place of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // dobpicker
            // 
            this.dobpicker.Location = new System.Drawing.Point(143, 98);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(200, 20);
            this.dobpicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Father/Husband Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 0;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientForm_FormClosing);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrecovereddsv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gendergb.ResumeLayout(false);
            this.gendergb.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView ptrecovereddsv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Label bedwardlb;
        private System.Windows.Forms.Label timedatelb;
        private System.Windows.Forms.Label doblb;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton notrecoveredrb;
        private System.Windows.Forms.RadioButton recoveredrb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ptnumtb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox testtb;
        private System.Windows.Forms.TextBox citytb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox mnumtb;
        private System.Windows.Forms.TextBox pnumtb;
        private System.Windows.Forms.TextBox cnictb;
        private System.Windows.Forms.RichTextBox permaddresstb;
        private System.Windows.Forms.RichTextBox presentaddtb;
        private System.Windows.Forms.TextBox pobirthtb;
        private System.Windows.Forms.TextBox f_hnametb;
        private System.Windows.Forms.TextBox lnametb;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button admittb;
        private System.Windows.Forms.GroupBox gendergb;
        private System.Windows.Forms.RadioButton xrb;
        private System.Windows.Forms.RadioButton femalerb;
        private System.Windows.Forms.RadioButton malerb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bloodgroupcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label20;
    }
}