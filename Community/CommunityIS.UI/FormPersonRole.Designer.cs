namespace CommunityIS.UI
{
    partial class FormPersonRole
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
            groupBox2 = new GroupBox();
            btnClearData = new Button();
            cmboxName = new ComboBox();
            checkBoxActive = new CheckBox();
            cmboxRole = new ComboBox();
            lblRole = new Label();
            cmboxCom = new ComboBox();
            lblComName = new Label();
            btnShowPersonRole = new Button();
            btnUpdatePersonRole = new Button();
            btnDeletePersonRole = new Button();
            lblPersonName = new Label();
            btnAddPersonRole = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnMainForm = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearData);
            groupBox2.Controls.Add(cmboxName);
            groupBox2.Controls.Add(checkBoxActive);
            groupBox2.Controls.Add(cmboxRole);
            groupBox2.Controls.Add(lblRole);
            groupBox2.Controls.Add(cmboxCom);
            groupBox2.Controls.Add(lblComName);
            groupBox2.Controls.Add(btnShowPersonRole);
            groupBox2.Controls.Add(btnUpdatePersonRole);
            groupBox2.Controls.Add(btnDeletePersonRole);
            groupBox2.Controls.Add(lblPersonName);
            groupBox2.Controls.Add(btnAddPersonRole);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 387);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "PersonRole";
            // 
            // btnClearData
            // 
            btnClearData.Location = new Point(421, 315);
            btnClearData.Margin = new Padding(4);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(161, 40);
            btnClearData.TabIndex = 39;
            btnClearData.Text = "Clear Data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // cmboxName
            // 
            cmboxName.FormattingEnabled = true;
            cmboxName.Location = new Point(184, 43);
            cmboxName.Name = "cmboxName";
            cmboxName.Size = new Size(204, 26);
            cmboxName.TabIndex = 38;
            cmboxName.SelectedIndexChanged += cmboxName_SelectedIndexChanged;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(16, 232);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(71, 22);
            checkBoxActive.TabIndex = 35;
            checkBoxActive.Text = "Active";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // cmboxRole
            // 
            cmboxRole.FormattingEnabled = true;
            cmboxRole.Location = new Point(184, 96);
            cmboxRole.Name = "cmboxRole";
            cmboxRole.Size = new Size(204, 26);
            cmboxRole.TabIndex = 33;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 96);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(89, 18);
            lblRole.TabIndex = 32;
            lblRole.Text = "Role Name:";
            // 
            // cmboxCom
            // 
            cmboxCom.FormattingEnabled = true;
            cmboxCom.Location = new Point(184, 148);
            cmboxCom.Name = "cmboxCom";
            cmboxCom.Size = new Size(204, 26);
            cmboxCom.TabIndex = 31;
            // 
            // lblComName
            // 
            lblComName.AutoSize = true;
            lblComName.Location = new Point(16, 151);
            lblComName.Name = "lblComName";
            lblComName.Size = new Size(134, 18);
            lblComName.TabIndex = 30;
            lblComName.Text = "Community Name:";
            // 
            // btnShowPersonRole
            // 
            btnShowPersonRole.Location = new Point(421, 256);
            btnShowPersonRole.Margin = new Padding(4);
            btnShowPersonRole.Name = "btnShowPersonRole";
            btnShowPersonRole.Size = new Size(161, 40);
            btnShowPersonRole.TabIndex = 11;
            btnShowPersonRole.Text = "Show PersonRole";
            btnShowPersonRole.UseVisualStyleBackColor = true;
            btnShowPersonRole.Click += btnShowPerson_Click;
            // 
            // btnUpdatePersonRole
            // 
            btnUpdatePersonRole.Location = new Point(421, 187);
            btnUpdatePersonRole.Margin = new Padding(4);
            btnUpdatePersonRole.Name = "btnUpdatePersonRole";
            btnUpdatePersonRole.Size = new Size(161, 40);
            btnUpdatePersonRole.TabIndex = 10;
            btnUpdatePersonRole.Text = "Update Person";
            btnUpdatePersonRole.UseVisualStyleBackColor = true;
            btnUpdatePersonRole.Click += btnUpdatePerson_Click;
            // 
            // btnDeletePersonRole
            // 
            btnDeletePersonRole.Location = new Point(421, 111);
            btnDeletePersonRole.Margin = new Padding(4);
            btnDeletePersonRole.Name = "btnDeletePersonRole";
            btnDeletePersonRole.Size = new Size(161, 40);
            btnDeletePersonRole.TabIndex = 9;
            btnDeletePersonRole.Text = "Delete PersonRole";
            btnDeletePersonRole.UseVisualStyleBackColor = true;
            btnDeletePersonRole.Click += btnDeletePerson_Click;
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Location = new Point(16, 46);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(107, 18);
            lblPersonName.TabIndex = 8;
            lblPersonName.Text = "Person Name:";
            // 
            // btnAddPersonRole
            // 
            btnAddPersonRole.Location = new Point(421, 35);
            btnAddPersonRole.Margin = new Padding(4);
            btnAddPersonRole.Name = "btnAddPersonRole";
            btnAddPersonRole.Size = new Size(161, 40);
            btnAddPersonRole.TabIndex = 6;
            btnAddPersonRole.Text = "Add PersonRole";
            btnAddPersonRole.UseVisualStyleBackColor = true;
            btnAddPersonRole.Click += btnAddPerson_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(642, 13);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(668, 449);
            groupBox3.TabIndex = 37;
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
            dataGridView1.Size = new Size(660, 423);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMainForm
            // 
            btnMainForm.Location = new Point(12, 434);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 46;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // FormPersonRole
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 529);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FormPersonRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPersonRole";
            Load += FormPersonRole_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox checkBoxActive;
        private ComboBox cmboxRole;
        private Label lblRole;
        private ComboBox cmboxCom;
        private Label lblComName;
        private Button btnShowPersonRole;
        private Button btnUpdatePersonRole;
        private Button btnDeletePersonRole;
        private Label lblPersonName;
        private Button btnAddPersonRole;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private ComboBox cmboxName;
        private Button btnClearData;
        private Button btnMainForm;
    }
}