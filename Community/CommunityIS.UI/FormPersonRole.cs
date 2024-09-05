using CommunityIS.Service.Core;
using CommunityIS.Service.Model;
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
    public partial class FormPersonRole : Form
    {
        PersonRoleService _personRoleService;
        RoleService _roleService;
        PersonService _personService;
        CommunityService _communityService;
        int selectedPersonId;
        int selectedRoleId;
        int selectedCommunityId;

        public FormPersonRole()
        {
            InitializeComponent();
        }

        private void FormPersonRole_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _personRoleService = new PersonRoleService(db);
            _roleService = new RoleService(db);
            _personService = new PersonService(db);
            _communityService = new CommunityService(db);
            FillCommunityComboBox();
            FillRoleComboBox();
            FillNameCombobox();
            FillPersonRoleGrid();
        }

        private void ClearData()
        {
            cmboxCom.Text = "";
            cmboxName.Text = "";
            cmboxRole.Text = "";
            checkBoxActive.Checked = false;
        }

        private void FillNameCombobox()
        {
            var people = _personService.GetAllPeople();
            cmboxName.DataSource = people;
            cmboxName.DisplayMember = "NameSurname";
            cmboxName.ValueMember = "PersonId";
        }

        private void FillCommunityComboBox()
        {
            var communities = _communityService.GetAllCommunities();
            cmboxCom.DataSource = communities;
            cmboxCom.DisplayMember = "CommunityName";
            cmboxCom.ValueMember = "CommunityId";
        }

        private void FillRoleComboBox()
        {
            var roles = _roleService.GetAllRoles();
            cmboxRole.DataSource = roles;
            cmboxRole.DisplayMember = "RoleName";
            cmboxRole.ValueMember = "RoleId";
        }

        private void FillPersonRoleGrid()
        {
            var personRoles = _personRoleService.GetAllPersonRoles();
            var personRoleData = personRoles
                .Select(pr => new
                {
                    pr.Person.PersonId,
                    pr.Person.NameSurname,
                    pr.IsActive,
                    pr.Community.CommunityName,
                    pr.Role.RoleName,
                    pr.RoleId,
                    pr.CommunityId
                }).ToList();

            dataGridView1.DataSource = personRoleData;

            if (dataGridView1.Columns["PersonId"] != null)
                dataGridView1.Columns["PersonId"].Visible = false;
            if (dataGridView1.Columns["RoleId"] != null)
                dataGridView1.Columns["RoleId"].Visible = false;
            if (dataGridView1.Columns["CommunityId"] != null)
                dataGridView1.Columns["CommunityId"].Visible = false;
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (cmboxName.SelectedValue != null && cmboxRole.SelectedValue != null && cmboxCom.SelectedValue != null)
            {
                var personRole = new PersonRole
                {
                    PersonId = (int)cmboxName.SelectedValue,
                    RoleId = (int)cmboxRole.SelectedValue,
                    CommunityId = (int)cmboxCom.SelectedValue,
                    IsActive = checkBoxActive.Checked
                };

                _personRoleService.AddPersonRole(personRole);
                ClearData();
                FillPersonRoleGrid();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int personId = (int)selectedRow.Cells["PersonId"].Value;
                int roleId = (int)selectedRow.Cells["RoleId"].Value;

                _personRoleService.DeletePersonRole(personId, roleId);
                FillPersonRoleGrid();
            }
            else
            {
                MessageBox.Show("Please select a person role to delete.");
            }
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int personId = (int)selectedRow.Cells["PersonId"].Value;
                int roleId = (int)selectedRow.Cells["RoleId"].Value;

                var updatedPersonRole = new PersonRole
                {
                    PersonId = personId,
                    RoleId = roleId,
                    CommunityId = (int)cmboxCom.SelectedValue,
                    IsActive = checkBoxActive.Checked
                };

                _personRoleService.UpdatePersonRole(personId, roleId, updatedPersonRole.CommunityId, updatedPersonRole.IsActive);
                FillPersonRoleGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a person role to update.");
            }
        }

        private void btnShowPerson_Click(object sender, EventArgs e)
        {
            FillPersonRoleGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedPersonId = (int)selectedRow.Cells["PersonId"].Value;
                selectedRoleId = (int)selectedRow.Cells["RoleId"].Value;
                selectedCommunityId = (int)selectedRow.Cells["CommunityId"].Value;

                cmboxName.SelectedValue = selectedPersonId;
                cmboxRole.SelectedValue = selectedRoleId;
                cmboxCom.SelectedValue = selectedCommunityId;


                //checkBoxActive.Checked = (bool)selectedRow.Cells["IsActive"].Value;
                bool isActive = _personRoleService.GetPersonRolesByPersonId(selectedPersonId)
                                                          .Any(pr => pr.IsActive);
                checkBoxActive.Checked = isActive;
            }
        }

        private void cmboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPersonRoleGrid();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnPersonRoleForm_Click(object sender, EventArgs e)
        {
            MainForm  mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
