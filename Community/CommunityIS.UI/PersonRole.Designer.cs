namespace CommunityIS.UI
{
    partial class PersonRoleForm
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
            groupBox1 = new GroupBox();
            btnShowRoless = new Button();
            btnUpdateRole = new Button();
            btnDeleteRole = new Button();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnAddRole = new Button();
            groupBox2 = new GroupBox();
            cmbDeprt = new ComboBox();
            label1 = new Label();
            checkBoxActive = new CheckBox();
            cmboxRole = new ComboBox();
            lblRole = new Label();
            cmboxCom = new ComboBox();
            lblComName = new Label();
            lblTel = new Label();
            txtTel = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnShowPerson = new Button();
            btnUpdatePerson = new Button();
            btnDeletePerson = new Button();
            lblPersonName = new Label();
            txtPrsnName = new TextBox();
            btnAddPerson = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowRoless);
            groupBox1.Controls.Add(btnUpdateRole);
            groupBox1.Controls.Add(btnDeleteRole);
            groupBox1.Controls.Add(lblRoleName);
            groupBox1.Controls.Add(txtRoleName);
            groupBox1.Controls.Add(btnAddRole);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Role";
            // 
            // btnShowRoless
            // 
            btnShowRoless.Location = new Point(421, 256);
            btnShowRoless.Margin = new Padding(4);
            btnShowRoless.Name = "btnShowRoless";
            btnShowRoless.Size = new Size(130, 40);
            btnShowRoless.TabIndex = 11;
            btnShowRoless.Text = "Show Roles";
            btnShowRoless.UseVisualStyleBackColor = true;
            btnShowRoless.Click += btnDhowFaculty_Click;
            // 
            // btnUpdateRole
            // 
            btnUpdateRole.Location = new Point(421, 187);
            btnUpdateRole.Margin = new Padding(4);
            btnUpdateRole.Name = "btnUpdateRole";
            btnUpdateRole.Size = new Size(130, 40);
            btnUpdateRole.TabIndex = 10;
            btnUpdateRole.Text = "Update Role";
            btnUpdateRole.UseVisualStyleBackColor = true;
            btnUpdateRole.Click += btnUpdateRole_Click;
            // 
            // btnDeleteRole
            // 
            btnDeleteRole.Location = new Point(421, 111);
            btnDeleteRole.Margin = new Padding(4);
            btnDeleteRole.Name = "btnDeleteRole";
            btnDeleteRole.Size = new Size(130, 40);
            btnDeleteRole.TabIndex = 9;
            btnDeleteRole.Text = "Delete Role";
            btnDeleteRole.UseVisualStyleBackColor = true;
            btnDeleteRole.Click += btnDeleteRole_Click;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(16, 46);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(89, 18);
            lblRoleName.TabIndex = 8;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(184, 43);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(169, 25);
            txtRoleName.TabIndex = 7;
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(421, 35);
            btnAddRole.Margin = new Padding(4);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(130, 40);
            btnAddRole.TabIndex = 6;
            btnAddRole.Text = "Add Role";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbDeprt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(checkBoxActive);
            groupBox2.Controls.Add(cmboxRole);
            groupBox2.Controls.Add(lblRole);
            groupBox2.Controls.Add(cmboxCom);
            groupBox2.Controls.Add(lblComName);
            groupBox2.Controls.Add(lblTel);
            groupBox2.Controls.Add(txtTel);
            groupBox2.Controls.Add(lblEmail);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(btnShowPerson);
            groupBox2.Controls.Add(btnUpdatePerson);
            groupBox2.Controls.Add(btnDeletePerson);
            groupBox2.Controls.Add(lblPersonName);
            groupBox2.Controls.Add(txtPrsnName);
            groupBox2.Controls.Add(btnAddPerson);
            groupBox2.Location = new Point(12, 374);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person";
            // 
            // cmbDeprt
            // 
            cmbDeprt.FormattingEnabled = true;
            cmbDeprt.Location = new Point(184, 206);
            cmbDeprt.Name = "cmbDeprt";
            cmbDeprt.Size = new Size(204, 26);
            cmbDeprt.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 209);
            label1.Name = "label1";
            label1.Size = new Size(139, 18);
            label1.TabIndex = 36;
            label1.Text = "Department Name:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(16, 370);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(71, 22);
            checkBoxActive.TabIndex = 35;
            checkBoxActive.Text = "Active";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // cmboxRole
            // 
            cmboxRole.FormattingEnabled = true;
            cmboxRole.Location = new Point(184, 322);
            cmboxRole.Name = "cmboxRole";
            cmboxRole.Size = new Size(204, 26);
            cmboxRole.TabIndex = 33;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 325);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(89, 18);
            lblRole.TabIndex = 32;
            lblRole.Text = "Role Name:";
            // 
            // cmboxCom
            // 
            cmboxCom.FormattingEnabled = true;
            cmboxCom.Location = new Point(184, 264);
            cmboxCom.Name = "cmboxCom";
            cmboxCom.Size = new Size(204, 26);
            cmboxCom.TabIndex = 31;
            // 
            // lblComName
            // 
            lblComName.AutoSize = true;
            lblComName.Location = new Point(16, 267);
            lblComName.Name = "lblComName";
            lblComName.Size = new Size(134, 18);
            lblComName.TabIndex = 30;
            lblComName.Text = "Community Name:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(16, 156);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(34, 18);
            lblTel.TabIndex = 15;
            lblTel.Text = "Tel:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(184, 156);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(169, 25);
            txtTel.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 18);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 25);
            txtEmail.TabIndex = 12;
            // 
            // btnShowPerson
            // 
            btnShowPerson.Location = new Point(421, 256);
            btnShowPerson.Margin = new Padding(4);
            btnShowPerson.Name = "btnShowPerson";
            btnShowPerson.Size = new Size(130, 40);
            btnShowPerson.TabIndex = 11;
            btnShowPerson.Text = "Show People";
            btnShowPerson.UseVisualStyleBackColor = true;
            btnShowPerson.Click += btnShowPerson_Click;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Location = new Point(421, 187);
            btnUpdatePerson.Margin = new Padding(4);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(130, 40);
            btnUpdatePerson.TabIndex = 10;
            btnUpdatePerson.Text = "Update Person";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Location = new Point(421, 111);
            btnDeletePerson.Margin = new Padding(4);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(130, 40);
            btnDeletePerson.TabIndex = 9;
            btnDeletePerson.Text = "Delete Person";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Location = new Point(16, 46);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(82, 18);
            lblPersonName.TabIndex = 8;
            lblPersonName.Text = "Full Name:";
            // 
            // txtPrsnName
            // 
            txtPrsnName.Location = new Point(184, 43);
            txtPrsnName.Name = "txtPrsnName";
            txtPrsnName.Size = new Size(169, 25);
            txtPrsnName.TabIndex = 7;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(421, 35);
            btnAddPerson.Margin = new Padding(4);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(130, 40);
            btnAddPerson.TabIndex = 6;
            btnAddPerson.Text = "Add Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(667, 19);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(693, 805);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 22);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(685, 779);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // PersonRoleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 902);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "PersonRoleForm";
            Text = "PersonRole";
            Load += PersonRole_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnShowRoless;
        private Button btnUpdateRole;
        private Button btnDeleteRole;
        private Label lblRoleName;
        private TextBox txtRoleName;
        private Button btnAddRole;
        private GroupBox groupBox2;
        private Button btnShowPerson;
        private Button btnUpdatePerson;
        private Button btnDeletePerson;
        private Label lblPersonName;
        private TextBox txtPrsnName;
        private Button btnAddPerson;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblEmail;
        private TextBox txtEmail;
        private ComboBox cmboxCom;
        private Label lblComName;
        private ComboBox cmboxRole;
        private Label lblRole;
        private CheckBox checkBoxActive;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private ComboBox cmbDeprt;
        private Label label1;
    }
}