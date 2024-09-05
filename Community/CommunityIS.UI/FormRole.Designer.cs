namespace CommunityIS.UI
{
    partial class FormRole
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
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnMainForm = new Button();
            groupBox1.SuspendLayout();
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
            groupBox1.TabIndex = 1;
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
            btnShowRoless.Click += btnShowRoless_Click;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(647, 13);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(536, 353);
            groupBox3.TabIndex = 35;
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
            dataGridView1.Size = new Size(528, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMainForm
            // 
            btnMainForm.Location = new Point(12, 386);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 46;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // FormRole
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 446);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FormRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRole";
            Load += FormRole_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnMainForm;
    }
}