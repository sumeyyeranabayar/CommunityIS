namespace CommunityIS.UI
{
    partial class MainForm
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
            buttonFacOprt = new Button();
            buttonEventOprt = new Button();
            buttonComOprt = new Button();
            btnPersonRoleForm = new Button();
            btnRoleForm = new Button();
            buttonPersonOprt = new Button();
            SuspendLayout();
            // 
            // buttonFacOprt
            // 
            buttonFacOprt.Location = new Point(56, 219);
            buttonFacOprt.Name = "buttonFacOprt";
            buttonFacOprt.Size = new Size(316, 37);
            buttonFacOprt.TabIndex = 31;
            buttonFacOprt.Text = "Click for Faculty Operations";
            buttonFacOprt.TextAlign = ContentAlignment.TopCenter;
            buttonFacOprt.UseVisualStyleBackColor = true;
            buttonFacOprt.Click += buttonFacOprt_Click;
            // 
            // buttonEventOprt
            // 
            buttonEventOprt.Location = new Point(56, 160);
            buttonEventOprt.Name = "buttonEventOprt";
            buttonEventOprt.Size = new Size(316, 37);
            buttonEventOprt.TabIndex = 30;
            buttonEventOprt.Text = "Click for Event Operations";
            buttonEventOprt.TextAlign = ContentAlignment.TopCenter;
            buttonEventOprt.UseVisualStyleBackColor = true;
            buttonEventOprt.Click += buttonEventOprt_Click;
            // 
            // buttonComOprt
            // 
            buttonComOprt.Location = new Point(56, 103);
            buttonComOprt.Name = "buttonComOprt";
            buttonComOprt.Size = new Size(316, 39);
            buttonComOprt.TabIndex = 29;
            buttonComOprt.Text = "Click for Community Operations";
            buttonComOprt.TextAlign = ContentAlignment.TopCenter;
            buttonComOprt.UseVisualStyleBackColor = true;
            buttonComOprt.Click += buttonComOprt_Click;
            // 
            // btnPersonRoleForm
            // 
            btnPersonRoleForm.Location = new Point(450, 229);
            btnPersonRoleForm.Name = "btnPersonRoleForm";
            btnPersonRoleForm.Size = new Size(316, 37);
            btnPersonRoleForm.TabIndex = 44;
            btnPersonRoleForm.Text = "Click for PersonRole Operations";
            btnPersonRoleForm.TextAlign = ContentAlignment.TopCenter;
            btnPersonRoleForm.UseVisualStyleBackColor = true;
            btnPersonRoleForm.Click += btnPersonRoleForm_Click;
            // 
            // btnRoleForm
            // 
            btnRoleForm.Location = new Point(450, 160);
            btnRoleForm.Name = "btnRoleForm";
            btnRoleForm.Size = new Size(316, 37);
            btnRoleForm.TabIndex = 43;
            btnRoleForm.Text = "Click for Role Operations";
            btnRoleForm.TextAlign = ContentAlignment.TopCenter;
            btnRoleForm.UseVisualStyleBackColor = true;
            btnRoleForm.Click += btnRoleForm_Click;
            // 
            // buttonPersonOprt
            // 
            buttonPersonOprt.Location = new Point(450, 103);
            buttonPersonOprt.Name = "buttonPersonOprt";
            buttonPersonOprt.Size = new Size(316, 39);
            buttonPersonOprt.TabIndex = 40;
            buttonPersonOprt.Text = "Click for Person Operations";
            buttonPersonOprt.TextAlign = ContentAlignment.TopCenter;
            buttonPersonOprt.UseVisualStyleBackColor = true;
            buttonPersonOprt.Click += buttonPersonOprt_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 403);
            Controls.Add(btnPersonRoleForm);
            Controls.Add(btnRoleForm);
            Controls.Add(buttonPersonOprt);
            Controls.Add(buttonFacOprt);
            Controls.Add(buttonEventOprt);
            Controls.Add(buttonComOprt);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFacOprt;
        private Button buttonEventOprt;
        private Button buttonComOprt;
        private Button btnPersonRoleForm;
        private Button btnRoleForm;
        private Button buttonPersonOprt;
    }
}