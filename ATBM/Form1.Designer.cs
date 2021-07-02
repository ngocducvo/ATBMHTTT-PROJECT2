
namespace ATBM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_user_privi = new System.Windows.Forms.DataGridView();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.dgv_role_privi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_check_pri = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.check_update = new System.Windows.Forms.CheckBox();
            this.check_delete = new System.Windows.Forms.CheckBox();
            this.check_select = new System.Windows.Forms.CheckBox();
            this.check_with = new System.Windows.Forms.CheckBox();
            this.check_insert = new System.Windows.Forms.CheckBox();
            this.cb_name_table = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name_pri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_role_del = new System.Windows.Forms.Button();
            this.bt_role_create = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_roleName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_new_pass = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_update_name = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bt_user_delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_username_del = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bt_user_create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_userName_create = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_userPass_Create = new System.Windows.Forms.TextBox();
            this.tb_col = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_privi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role_privi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_check_pri)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 633);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1244, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_user_privi);
            this.groupBox2.Controls.Add(this.dgv_users);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 602);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Privileges";
            // 
            // dgv_user_privi
            // 
            this.dgv_user_privi.AllowUserToAddRows = false;
            this.dgv_user_privi.AllowUserToDeleteRows = false;
            this.dgv_user_privi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user_privi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_privi.Location = new System.Drawing.Point(6, 315);
            this.dgv_user_privi.Name = "dgv_user_privi";
            this.dgv_user_privi.ReadOnly = true;
            this.dgv_user_privi.RowTemplate.Height = 25;
            this.dgv_user_privi.Size = new System.Drawing.Size(607, 281);
            this.dgv_user_privi.TabIndex = 1;
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(6, 22);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowTemplate.Height = 25;
            this.dgv_users.Size = new System.Drawing.Size(607, 268);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_roles);
            this.groupBox1.Controls.Add(this.dgv_role_privi);
            this.groupBox1.Location = new System.Drawing.Point(627, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 602);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Privileges";
            // 
            // dgv_roles
            // 
            this.dgv_roles.AllowUserToAddRows = false;
            this.dgv_roles.AllowUserToDeleteRows = false;
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.Location = new System.Drawing.Point(6, 22);
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.ReadOnly = true;
            this.dgv_roles.RowTemplate.Height = 25;
            this.dgv_roles.Size = new System.Drawing.Size(602, 268);
            this.dgv_roles.TabIndex = 3;
            this.dgv_roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_roles_CellClick);
            // 
            // dgv_role_privi
            // 
            this.dgv_role_privi.AllowUserToAddRows = false;
            this.dgv_role_privi.AllowUserToDeleteRows = false;
            this.dgv_role_privi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_role_privi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role_privi.Location = new System.Drawing.Point(0, 315);
            this.dgv_role_privi.Name = "dgv_role_privi";
            this.dgv_role_privi.ReadOnly = true;
            this.dgv_role_privi.RowTemplate.Height = 25;
            this.dgv_role_privi.Size = new System.Drawing.Size(602, 281);
            this.dgv_role_privi.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_check_pri);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1244, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Privileges";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_check_pri
            // 
            this.dgv_check_pri.AllowUserToAddRows = false;
            this.dgv_check_pri.AllowUserToDeleteRows = false;
            this.dgv_check_pri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_check_pri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_check_pri.Location = new System.Drawing.Point(40, 304);
            this.dgv_check_pri.Name = "dgv_check_pri";
            this.dgv_check_pri.ReadOnly = true;
            this.dgv_check_pri.RowTemplate.Height = 25;
            this.dgv_check_pri.Size = new System.Drawing.Size(1168, 280);
            this.dgv_check_pri.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_col);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.check_update);
            this.groupBox3.Controls.Add(this.check_delete);
            this.groupBox3.Controls.Add(this.check_select);
            this.groupBox3.Controls.Add(this.check_with);
            this.groupBox3.Controls.Add(this.check_insert);
            this.groupBox3.Controls.Add(this.cb_name_table);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_name_pri);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1238, 278);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grant/Revoke";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.tb_role);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.tb_user);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(824, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(381, 204);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Grant role to user";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Grant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(137, 86);
            this.tb_role.Name = "tb_role";
            this.tb_role.Size = new System.Drawing.Size(207, 23);
            this.tb_role.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name Role";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(137, 49);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(207, 23);
            this.tb_user.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Column";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Revoke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Grant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_update
            // 
            this.check_update.AutoSize = true;
            this.check_update.Location = new System.Drawing.Point(440, 92);
            this.check_update.Name = "check_update";
            this.check_update.Size = new System.Drawing.Size(64, 19);
            this.check_update.TabIndex = 8;
            this.check_update.Text = "Update";
            this.check_update.UseVisualStyleBackColor = true;
            // 
            // check_delete
            // 
            this.check_delete.AutoSize = true;
            this.check_delete.Location = new System.Drawing.Point(531, 91);
            this.check_delete.Name = "check_delete";
            this.check_delete.Size = new System.Drawing.Size(59, 19);
            this.check_delete.TabIndex = 7;
            this.check_delete.Text = "Delete";
            this.check_delete.UseVisualStyleBackColor = true;
            // 
            // check_select
            // 
            this.check_select.AutoSize = true;
            this.check_select.Location = new System.Drawing.Point(440, 55);
            this.check_select.Name = "check_select";
            this.check_select.Size = new System.Drawing.Size(57, 19);
            this.check_select.TabIndex = 6;
            this.check_select.Text = "Select";
            this.check_select.UseVisualStyleBackColor = true;
            // 
            // check_with
            // 
            this.check_with.AutoSize = true;
            this.check_with.Location = new System.Drawing.Point(626, 55);
            this.check_with.Name = "check_with";
            this.check_with.Size = new System.Drawing.Size(120, 19);
            this.check_with.TabIndex = 5;
            this.check_with.Text = "With grant option";
            this.check_with.UseVisualStyleBackColor = true;
            // 
            // check_insert
            // 
            this.check_insert.AutoSize = true;
            this.check_insert.Location = new System.Drawing.Point(531, 55);
            this.check_insert.Name = "check_insert";
            this.check_insert.Size = new System.Drawing.Size(55, 19);
            this.check_insert.TabIndex = 4;
            this.check_insert.Text = "Insert";
            this.check_insert.UseVisualStyleBackColor = true;
            // 
            // cb_name_table
            // 
            this.cb_name_table.FormattingEnabled = true;
            this.cb_name_table.Items.AddRange(new object[] {
            "EMPLOYEE",
            "DEPARTMENT",
            "MEDICAL_RECORD",
            "SERVICES",
            "INVOICE",
            "PATIENT",
            "PRESCRIPTION",
            "MEDICINE",
            "PRES_DETAILS",
            "MeR_Se",
            "INVOICE_DETAILS"});
            this.cb_name_table.Location = new System.Drawing.Point(177, 87);
            this.cb_name_table.Name = "cb_name_table";
            this.cb_name_table.Size = new System.Drawing.Size(207, 23);
            this.cb_name_table.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Table";
            // 
            // tb_name_pri
            // 
            this.tb_name_pri.Location = new System.Drawing.Point(177, 51);
            this.tb_name_pri.Name = "tb_name_pri";
            this.tb_name_pri.Size = new System.Drawing.Size(207, 23);
            this.tb_name_pri.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name User/Role";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1244, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create/Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_role_del);
            this.groupBox5.Controls.Add(this.bt_role_create);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tb_roleName);
            this.groupBox5.Location = new System.Drawing.Point(3, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1238, 284);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Role";
            // 
            // bt_role_del
            // 
            this.bt_role_del.Location = new System.Drawing.Point(618, 124);
            this.bt_role_del.Name = "bt_role_del";
            this.bt_role_del.Size = new System.Drawing.Size(134, 40);
            this.bt_role_del.TabIndex = 7;
            this.bt_role_del.Text = "DELETE";
            this.bt_role_del.UseVisualStyleBackColor = true;
            this.bt_role_del.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_role_create
            // 
            this.bt_role_create.Location = new System.Drawing.Point(446, 124);
            this.bt_role_create.Name = "bt_role_create";
            this.bt_role_create.Size = new System.Drawing.Size(129, 40);
            this.bt_role_create.TabIndex = 6;
            this.bt_role_create.Text = "CREATE";
            this.bt_role_create.UseVisualStyleBackColor = true;
            this.bt_role_create.Click += new System.EventHandler(this.bt_role_create_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name";
            // 
            // tb_roleName
            // 
            this.tb_roleName.Location = new System.Drawing.Point(491, 75);
            this.tb_roleName.Name = "tb_roleName";
            this.tb_roleName.Size = new System.Drawing.Size(261, 23);
            this.tb_roleName.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1238, 280);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.tb_new_pass);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.tb_update_name);
            this.groupBox9.Location = new System.Drawing.Point(831, 22);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(399, 242);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Update";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "New Password";
            // 
            // tb_new_pass
            // 
            this.tb_new_pass.Location = new System.Drawing.Point(145, 101);
            this.tb_new_pass.Name = "tb_new_pass";
            this.tb_new_pass.Size = new System.Drawing.Size(207, 23);
            this.tb_new_pass.TabIndex = 8;
            this.tb_new_pass.UseSystemPasswordChar = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // tb_update_name
            // 
            this.tb_update_name.Location = new System.Drawing.Point(145, 70);
            this.tb_update_name.Name = "tb_update_name";
            this.tb_update_name.Size = new System.Drawing.Size(207, 23);
            this.tb_update_name.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bt_user_delete);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.tb_username_del);
            this.groupBox7.Location = new System.Drawing.Point(415, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(410, 242);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Delete";
            // 
            // bt_user_delete
            // 
            this.bt_user_delete.Location = new System.Drawing.Point(125, 146);
            this.bt_user_delete.Name = "bt_user_delete";
            this.bt_user_delete.Size = new System.Drawing.Size(189, 40);
            this.bt_user_delete.TabIndex = 7;
            this.bt_user_delete.Text = "DELETE";
            this.bt_user_delete.UseVisualStyleBackColor = true;
            this.bt_user_delete.Click += new System.EventHandler(this.bt_user_delete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // tb_username_del
            // 
            this.tb_username_del.Location = new System.Drawing.Point(121, 70);
            this.tb_username_del.Name = "tb_username_del";
            this.tb_username_del.Size = new System.Drawing.Size(240, 23);
            this.tb_username_del.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bt_user_create);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.tb_userName_create);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.tb_userPass_Create);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 242);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Create";
            // 
            // bt_user_create
            // 
            this.bt_user_create.Location = new System.Drawing.Point(114, 146);
            this.bt_user_create.Name = "bt_user_create";
            this.bt_user_create.Size = new System.Drawing.Size(189, 40);
            this.bt_user_create.TabIndex = 6;
            this.bt_user_create.Text = "CREATE";
            this.bt_user_create.UseVisualStyleBackColor = true;
            this.bt_user_create.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // tb_userName_create
            // 
            this.tb_userName_create.Location = new System.Drawing.Point(154, 70);
            this.tb_userName_create.Name = "tb_userName_create";
            this.tb_userName_create.Size = new System.Drawing.Size(207, 23);
            this.tb_userName_create.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password";
            // 
            // tb_userPass_Create
            // 
            this.tb_userPass_Create.Location = new System.Drawing.Point(154, 101);
            this.tb_userPass_Create.Name = "tb_userPass_Create";
            this.tb_userPass_Create.Size = new System.Drawing.Size(207, 23);
            this.tb_userPass_Create.TabIndex = 5;
            this.tb_userPass_Create.UseSystemPasswordChar = true;
            // 
            // tb_col
            // 
            this.tb_col.Location = new System.Drawing.Point(177, 126);
            this.tb_col.Name = "tb_col";
            this.tb_col.Size = new System.Drawing.Size(207, 23);
            this.tb_col.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 657);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DBA Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_privi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role_privi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_check_pri)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_user_privi;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_roles;
        private System.Windows.Forms.DataGridView dgv_role_privi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_update;
        private System.Windows.Forms.CheckBox check_delete;
        private System.Windows.Forms.CheckBox check_select;
        private System.Windows.Forms.CheckBox check_with;
        private System.Windows.Forms.CheckBox check_insert;
        private System.Windows.Forms.ComboBox cb_name_table;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name_pri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_check_pri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_role_del;
        private System.Windows.Forms.Button bt_role_create;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_roleName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bt_user_delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_username_del;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bt_user_create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_userName_create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_userPass_Create;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_update_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_new_pass;
        private System.Windows.Forms.TextBox tb_col;
    }
}

