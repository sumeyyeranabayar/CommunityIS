using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityIS.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonComOprt_Click(object sender, EventArgs e)
        {
            CommunityForm communityForm = new CommunityForm();
            communityForm.Show();
            this.Hide();
        }

        private void buttonEventOprt_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Show();
            this.Hide();
        }

        private void buttonFacOprt_Click(object sender, EventArgs e)
        {
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.Show();
            this.Hide();
        }

        private void buttonPersonOprt_Click(object sender, EventArgs e)
        {
            FormPerson personForm = new FormPerson();
            personForm.Show();
            this.Hide();
        }

        private void btnRoleForm_Click(object sender, EventArgs e)
        {
            FormRole formRoleForm = new FormRole();
            formRoleForm.Show();
            this.Hide();
        }

        private void btnPersonRoleForm_Click(object sender, EventArgs e)
        {
            PersonRoleForm personRoleForm = new PersonRoleForm();
            personRoleForm.Show();
            this.Hide();
        }
    }
}
