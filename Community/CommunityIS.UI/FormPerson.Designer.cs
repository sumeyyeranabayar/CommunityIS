namespace CommunityIS.UI
{
    partial class FormPerson
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
            cmbDeprt = new ComboBox();
            label1 = new Label();
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
            btnMainForm = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbDeprt);
            groupBox2.Controls.Add(label1);
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
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 351);
            groupBox2.TabIndex = 2;
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
            groupBox3.Location = new Point(679, 13);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(722, 449);
            groupBox3.TabIndex = 36;
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
            dataGridView1.Size = new Size(714, 423);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMainForm
            // 
            btnMainForm.Location = new Point(28, 395);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 45;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 550);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FormPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPerson";
            Load += FormPerson_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cmbDeprt;
        private Label label1;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnShowPerson;
        private Button btnUpdatePerson;
        private Button btnDeletePerson;
        private Label lblPersonName;
        private TextBox txtPrsnName;
        private Button btnAddPerson;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnMainForm;
    }
}