namespace CommunityIS.UI
{
    partial class CommunityForm
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
            cmboxFaculty = new ComboBox();
            lblFacName = new Label();
            btnShowCom = new Button();
            btnUpdateCom = new Button();
            btnDeleteCom = new Button();
            lblCommunityName = new Label();
            txtComName = new TextBox();
            btnAddCom = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnMainForm = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmboxFaculty
            // 
            cmboxFaculty.FormattingEnabled = true;
            cmboxFaculty.Location = new Point(145, 114);
            cmboxFaculty.Name = "cmboxFaculty";
            cmboxFaculty.Size = new Size(204, 26);
            cmboxFaculty.TabIndex = 21;
            // 
            // lblFacName
            // 
            lblFacName.AutoSize = true;
            lblFacName.Location = new Point(12, 115);
            lblFacName.Name = "lblFacName";
            lblFacName.Size = new Size(106, 18);
            lblFacName.TabIndex = 20;
            lblFacName.Text = "Faculty Name:";
            // 
            // btnShowCom
            // 
            btnShowCom.Location = new Point(388, 251);
            btnShowCom.Margin = new Padding(4);
            btnShowCom.Name = "btnShowCom";
            btnShowCom.Size = new Size(159, 40);
            btnShowCom.TabIndex = 19;
            btnShowCom.Text = "Show Communities";
            btnShowCom.UseVisualStyleBackColor = true;
            btnShowCom.Click += btnShowCom_Click;
            // 
            // btnUpdateCom
            // 
            btnUpdateCom.Location = new Point(388, 182);
            btnUpdateCom.Margin = new Padding(4);
            btnUpdateCom.Name = "btnUpdateCom";
            btnUpdateCom.Size = new Size(159, 40);
            btnUpdateCom.TabIndex = 18;
            btnUpdateCom.Text = "Update Community";
            btnUpdateCom.UseVisualStyleBackColor = true;
            btnUpdateCom.Click += btnUpdateCom_Click;
            // 
            // btnDeleteCom
            // 
            btnDeleteCom.Location = new Point(388, 115);
            btnDeleteCom.Margin = new Padding(4);
            btnDeleteCom.Name = "btnDeleteCom";
            btnDeleteCom.Size = new Size(159, 40);
            btnDeleteCom.TabIndex = 17;
            btnDeleteCom.Text = "Delete Community";
            btnDeleteCom.UseVisualStyleBackColor = true;
            btnDeleteCom.Click += btnDeleteCom_Click;
            // 
            // lblCommunityName
            // 
            lblCommunityName.AutoSize = true;
            lblCommunityName.Location = new Point(12, 41);
            lblCommunityName.Name = "lblCommunityName";
            lblCommunityName.Size = new Size(134, 18);
            lblCommunityName.TabIndex = 16;
            lblCommunityName.Text = "Community Name:";
            // 
            // txtComName
            // 
            txtComName.Location = new Point(180, 38);
            txtComName.Name = "txtComName";
            txtComName.Size = new Size(169, 25);
            txtComName.TabIndex = 15;
            // 
            // btnAddCom
            // 
            btnAddCom.Location = new Point(388, 30);
            btnAddCom.Margin = new Padding(4);
            btnAddCom.Name = "btnAddCom";
            btnAddCom.Size = new Size(159, 40);
            btnAddCom.TabIndex = 14;
            btnAddCom.Text = "Add Community";
            btnAddCom.UseVisualStyleBackColor = true;
            btnAddCom.Click += btnAddCom_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(616, 13);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(693, 548);
            groupBox3.TabIndex = 22;
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
            dataGridView1.Size = new Size(685, 522);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMainForm
            // 
            btnMainForm.Location = new Point(297, 327);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 46;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // CommunityForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 592);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(cmboxFaculty);
            Controls.Add(lblFacName);
            Controls.Add(btnShowCom);
            Controls.Add(btnUpdateCom);
            Controls.Add(btnDeleteCom);
            Controls.Add(lblCommunityName);
            Controls.Add(txtComName);
            Controls.Add(btnAddCom);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "CommunityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Community";
            Load += Community_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmboxFaculty;
        private Label lblFacName;
        private Button btnShowCom;
        private Button btnUpdateCom;
        private Button btnDeleteCom;
        private Label lblCommunityName;
        private TextBox txtComName;
        private Button btnAddCom;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnMainForm;
    }
}