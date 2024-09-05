namespace CommunityIS.UI
{
    partial class EventForm
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
            cmboxCom = new ComboBox();
            lblComName = new Label();
            btnShowEvnt = new Button();
            btnUpdateEvnt = new Button();
            btnDeleteEvnt = new Button();
            lblEventName = new Label();
            txtEventName = new TextBox();
            btnAddEvnt = new Button();
            lblDescrpt = new Label();
            txtDescrpt = new TextBox();
            lblDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnMainForm = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmboxCom
            // 
            cmboxCom.FormattingEnabled = true;
            cmboxCom.Location = new Point(152, 103);
            cmboxCom.Name = "cmboxCom";
            cmboxCom.Size = new Size(204, 26);
            cmboxCom.TabIndex = 29;
            // 
            // lblComName
            // 
            lblComName.AutoSize = true;
            lblComName.Location = new Point(12, 106);
            lblComName.Name = "lblComName";
            lblComName.Size = new Size(134, 18);
            lblComName.TabIndex = 28;
            lblComName.Text = "Community Name:";
            // 
            // btnShowEvnt
            // 
            btnShowEvnt.Location = new Point(388, 242);
            btnShowEvnt.Margin = new Padding(4);
            btnShowEvnt.Name = "btnShowEvnt";
            btnShowEvnt.Size = new Size(159, 40);
            btnShowEvnt.TabIndex = 27;
            btnShowEvnt.Text = "Show Events";
            btnShowEvnt.UseVisualStyleBackColor = true;
            btnShowEvnt.Click += btnShowEvnt_Click;
            // 
            // btnUpdateEvnt
            // 
            btnUpdateEvnt.Location = new Point(388, 173);
            btnUpdateEvnt.Margin = new Padding(4);
            btnUpdateEvnt.Name = "btnUpdateEvnt";
            btnUpdateEvnt.Size = new Size(159, 40);
            btnUpdateEvnt.TabIndex = 26;
            btnUpdateEvnt.Text = "Update Event";
            btnUpdateEvnt.UseVisualStyleBackColor = true;
            btnUpdateEvnt.Click += btnUpdateEvnt_Click;
            // 
            // btnDeleteEvnt
            // 
            btnDeleteEvnt.Location = new Point(388, 106);
            btnDeleteEvnt.Margin = new Padding(4);
            btnDeleteEvnt.Name = "btnDeleteEvnt";
            btnDeleteEvnt.Size = new Size(159, 40);
            btnDeleteEvnt.TabIndex = 25;
            btnDeleteEvnt.Text = "Delete Event";
            btnDeleteEvnt.UseVisualStyleBackColor = true;
            btnDeleteEvnt.Click += btnDeleteEvnt_Click;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Location = new Point(12, 32);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(98, 18);
            lblEventName.TabIndex = 24;
            lblEventName.Text = "Event Name:";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(180, 29);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(169, 25);
            txtEventName.TabIndex = 23;
            // 
            // btnAddEvnt
            // 
            btnAddEvnt.Location = new Point(388, 21);
            btnAddEvnt.Margin = new Padding(4);
            btnAddEvnt.Name = "btnAddEvnt";
            btnAddEvnt.Size = new Size(159, 40);
            btnAddEvnt.TabIndex = 22;
            btnAddEvnt.Text = "Add Event";
            btnAddEvnt.UseVisualStyleBackColor = true;
            btnAddEvnt.Click += btnAddEvnt_Click;
            // 
            // lblDescrpt
            // 
            lblDescrpt.AutoSize = true;
            lblDescrpt.Location = new Point(12, 184);
            lblDescrpt.Name = "lblDescrpt";
            lblDescrpt.Size = new Size(140, 18);
            lblDescrpt.TabIndex = 31;
            lblDescrpt.Text = "Event Description:";
            // 
            // txtDescrpt
            // 
            txtDescrpt.Location = new Point(180, 181);
            txtDescrpt.Name = "txtDescrpt";
            txtDescrpt.Size = new Size(169, 25);
            txtDescrpt.TabIndex = 30;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 253);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(91, 18);
            lblDate.TabIndex = 32;
            lblDate.Text = "Event Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 25);
            dateTimePicker1.TabIndex = 33;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(625, 21);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(693, 548);
            groupBox3.TabIndex = 34;
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
            btnMainForm.Location = new Point(-2, 342);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(316, 37);
            btnMainForm.TabIndex = 46;
            btnMainForm.Text = "Click for Main Page";
            btnMainForm.TextAlign = ContentAlignment.TopCenter;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += btnPersonRoleForm_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 695);
            Controls.Add(btnMainForm);
            Controls.Add(groupBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDate);
            Controls.Add(lblDescrpt);
            Controls.Add(txtDescrpt);
            Controls.Add(cmboxCom);
            Controls.Add(lblComName);
            Controls.Add(btnShowEvnt);
            Controls.Add(btnUpdateEvnt);
            Controls.Add(btnDeleteEvnt);
            Controls.Add(lblEventName);
            Controls.Add(txtEventName);
            Controls.Add(btnAddEvnt);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event";
            Load += Event_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmboxCom;
        private Label lblComName;
        private Button btnShowEvnt;
        private Button btnUpdateEvnt;
        private Button btnDeleteEvnt;
        private Label lblEventName;
        private TextBox txtEventName;
        private Button btnAddEvnt;
        private Label lblDescrpt;
        private TextBox txtDescrpt;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnMainForm;
    }
}