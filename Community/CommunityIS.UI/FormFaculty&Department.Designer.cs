namespace CommunityIS.UI
{
    partial class FacultyForm
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
            groupBox1 = new GroupBox();
            btnShowFaculty = new Button();
            btnUpdateFaculty = new Button();
            btnDeleteFaculty = new Button();
            lblFacultyName = new Label();
            txtFacultyName = new TextBox();
            btnAddFaculty = new Button();
            groupBox2 = new GroupBox();
            cmboxFaculty = new ComboBox();
            lblFacName = new Label();
            btnShowDeprt = new Button();
            btnUpdateDeprt = new Button();
            btnDeleteDeprt = new Button();
            lblDepartmentName = new Label();
            txtDepartmentName = new TextBox();
            btnAddDeprt = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnMainForm = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowFaculty);
            groupBox1.Controls.Add(btnUpdateFaculty);
            groupBox1.Controls.Add(btnDeleteFaculty);
            groupBox1.Controls.Add(lblFacultyName);
            groupBox1.Controls.Add(txtFacultyName);
            groupBox1.Controls.Add(btnAddFaculty);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(612, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "FACULTY";
            // 
            // btnShowFaculty
            // 
            btnShowFaculty.Location = new Point(424, 285);
            btnShowFaculty.Margin = new Padding(4);
            btnShowFaculty.Name = "btnShowFaculty";
            btnShowFaculty.Size = new Size(130, 40);
            btnShowFaculty.TabIndex = 5;
            btnShowFaculty.Text = "Show Faculties";
            btnShowFaculty.UseVisualStyleBackColor = true;
            btnShowFaculty.Click += btnDhowFaculty_Click;
            // 
            // btnUpdateFaculty
            // 
            btnUpdateFaculty.Location = new Point(424, 216);
            btnUpdateFaculty.Margin = new Padding(4);
            btnUpdateFaculty.Name = "btnUpdateFaculty";
            btnUpdateFaculty.Size = new Size(130, 40);
            btnUpdateFaculty.TabIndex = 4;
            btnUpdateFaculty.Text = "Update Faculty";
            btnUpdateFaculty.UseVisualStyleBackColor = true;
            btnUpdateFaculty.Click += btnUpdateFaculty_Click;
            // 
            // btnDeleteFaculty
            // 
            btnDeleteFaculty.Location = new Point(424, 140);
            btnDeleteFaculty.Margin = new Padding(4);
            btnDeleteFaculty.Name = "btnDeleteFaculty";
            btnDeleteFaculty.Size = new Size(130, 40);
            btnDeleteFaculty.TabIndex = 3;
            btnDeleteFaculty.Text = "Delete Faculty";
            btnDeleteFaculty.UseVisualStyleBackColor = true;
            btnDeleteFaculty.Click += btnDeleteFaculty_Click;
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.Location = new Point(19, 75);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(106, 18);
            lblFacultyName.TabIndex = 2;
            lblFacultyName.Text = "Faculty Name:";
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(187, 72);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(169, 25);
            txtFacultyName.TabIndex = 1;
            // 
            // btnAddFaculty
            // 
            btnAddFaculty.Location = new Point(424, 64);
            btnAddFaculty.Margin = new Padding(4);
            btnAddFaculty.Name = "btnAddFaculty";
            btnAddFaculty.Size = new Size(130, 40);
            btnAddFaculty.TabIndex = 0;
            btnAddFaculty.Text = "Add Faculty";
            btnAddFaculty.UseVisualStyleBackColor = true;
            btnAddFaculty.Click += btnAddFaculty_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmboxFaculty);
            groupBox2.Controls.Add(lblFacName);
            groupBox2.Controls.Add(btnShowDeprt);
            groupBox2.Controls.Add(btnUpdateDeprt);
            groupBox2.Controls.Add(btnDeleteDeprt);
            groupBox2.Controls.Add(lblDepartmentName);
            groupBox2.Controls.Add(txtDepartmentName);
            groupBox2.Controls.Add(btnAddDeprt);
            groupBox2.Location = new Point(13, 396);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(614, 365);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DEPARTMENT";
            // 
            // cmboxFaculty
            // 
            cmboxFaculty.FormattingEnabled = true;
            cmboxFaculty.Location = new Point(173, 136);
            cmboxFaculty.Name = "cmboxFaculty";
            cmboxFaculty.Size = new Size(204, 26);
            cmboxFaculty.TabIndex = 13;
            // 
            // lblFacName
            // 
            lblFacName.AutoSize = true;
            lblFacName.Location = new Point(40, 137);
            lblFacName.Name = "lblFacName";
            lblFacName.Size = new Size(106, 18);
            lblFacName.TabIndex = 12;
            lblFacName.Text = "Faculty Name:";
            // 
            // btnShowDeprt
            // 
            btnShowDeprt.Location = new Point(416, 273);
            btnShowDeprt.Margin = new Padding(4);
            btnShowDeprt.Name = "btnShowDeprt";
            btnShowDeprt.Size = new Size(159, 40);
            btnShowDeprt.TabIndex = 11;
            btnShowDeprt.Text = "Show Departments";
            btnShowDeprt.UseVisualStyleBackColor = true;
            btnShowDeprt.Click += btnShowDeprt_Click;
            // 
            // btnUpdateDeprt
            // 
            btnUpdateDeprt.Location = new Point(416, 204);
            btnUpdateDeprt.Margin = new Padding(4);
            btnUpdateDeprt.Name = "btnUpdateDeprt";
            btnUpdateDeprt.Size = new Size(159, 40);
            btnUpdateDeprt.TabIndex = 10;
            btnUpdateDeprt.Text = "Update Department";
            btnUpdateDeprt.UseVisualStyleBackColor = true;
            btnUpdateDeprt.Click += btnUpdateDeprt_Click;
            // 
            // btnDeleteDeprt
            // 
            btnDeleteDeprt.Location = new Point(416, 137);
            btnDeleteDeprt.Margin = new Padding(4);
            btnDeleteDeprt.Name = "btnDeleteDeprt";
            btnDeleteDeprt.Size = new Size(159, 40);
            btnDeleteDeprt.TabIndex = 9;
            btnDeleteDeprt.Text = "Delete Department";
            btnDeleteDeprt.UseVisualStyleBackColor = true;
            btnDeleteDeprt.Click += btnDeleteDeprt_Click;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(40, 63);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(139, 18);
            lblDepartmentName.TabIndex = 8;
            lblDepartmentName.Text = "Department Name:";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(208, 60);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(169, 25);
            txtDepartmentName.TabIndex = 7;
            // 
            // btnAddDeprt
            // 
            btnAddDeprt.Location = new Point(416, 52);
            btnAddDeprt.Margin = new Padding(4);
            btnAddDeprt.Name = "btnAddDeprt";
            btnAddDeprt.Size = new Size(159, 40);
            btnAddDeprt.TabIndex = 6;
            btnAddDeprt.Text = "Add Department";
            btnAddDeprt.UseVisualStyleBackColor = true;
            btnAddDeprt.Click += btnAddDeprt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(672, 25);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(693, 736);
            groupBox3.TabIndex = 2;
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
            dataGridView1.Size = new Size(685, 710);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMainForm
            // 
            btnMainForm.Location = new Point(15, 790);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 46;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // FacultyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1378, 839);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculty&Department";
            Load += Faculty_Load;
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
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnAddFaculty;
        private DataGridView dataGridView1;
        private Label lblFacultyName;
        private TextBox txtFacultyName;
        private Button btnShowFaculty;
        private Button btnUpdateFaculty;
        private Button btnDeleteFaculty;
        private Button btnShowDeprt;
        private Button btnUpdateDeprt;
        private Button btnDeleteDeprt;
        private Label lblDepartmentName;
        private TextBox txtDepartmentName;
        private Button btnAddDeprt;
        private ComboBox cmboxFaculty;
        private Label lblFacName;
        private Button btnMainForm;
    }
}
