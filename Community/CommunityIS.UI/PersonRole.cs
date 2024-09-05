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
    public partial class PersonRoleForm : Form
    {
        PersonRoleService _personRoleService;
        RoleService _roleService;
        PersonService _personService;
        CommunityService _communityService;
        DepartmentService _departmentService;
        int selectedPersonId;
        int selectedRoleId;

        private bool isShowPersonMode = false;

        public PersonRoleForm()
        {
            InitializeComponent();
        }

        private void PersonRole_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _personRoleService = new PersonRoleService(db);
            _roleService = new RoleService(db);
            _personService = new PersonService(db);
            _communityService = new CommunityService(db); // _communityService burada başlatılıyor
            _departmentService = new DepartmentService(db); 
            FillCommunityComboBox();
            FillRoleComboBox();
            FillDepartmentComboBox();
        }

        void ClearData()
        {
            txtPrsnName.Text = "";
            txtRoleName.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            cmboxCom.Text = "";
            cmboxRole.Text = "";
            checkBoxActive.Checked = false;
        }

        private void FillRoleGrid()
        {
            var roles = _roleService.GetAllRoles();
            var roleData = roles.Select(r => new
            {
                r.RoleId,
                r.RoleName
            }).ToList();

            dataGridView1.DataSource = roleData;

            if (dataGridView1.Columns["RoleId"] != null)
            {
                dataGridView1.Columns["RoleId"].Visible = false;
            }
        }

        private void FillPersonGrid()
        {
            var people = _personService.GetAllPeople();
            var personData = people.Select(p => new
            {
                p.PersonId,
                p.NameSurname,
                p.Email,
                p.Tel,
                Department = p.Department?.DepartmentName,
                IsActive = p.PersonRoles.Any(pr => pr.IsActive),
                Communities = string.Join(", ", p.PersonRoles.Select(pr => pr.Community.CommunityName)),
                RoleName = _personRoleService.GetPersonRolesByPersonId(p.PersonId).FirstOrDefault()?.Role.RoleName,
                RoleId = _personRoleService.GetPersonRolesByPersonId(p.PersonId).FirstOrDefault()?.RoleId,
                CommunityId = _personRoleService.GetPersonRolesByPersonId(p.PersonId).FirstOrDefault()?.CommunityId
            }).ToList();

            dataGridView1.DataSource = personData;

            // Sütunları gizleme ve başlıkları ayarlama
            if (dataGridView1.Columns["PersonId"] != null)
            {
                dataGridView1.Columns["PersonId"].Visible = false;
            }
            if (dataGridView1.Columns["Department"] != null)
            {
                dataGridView1.Columns["Department"].HeaderText = "Department";
                dataGridView1.Columns["Department"].Visible = true;
            }
            if (dataGridView1.Columns["IsActive"] != null)
            {
                dataGridView1.Columns["IsActive"].HeaderText = "Active";
                dataGridView1.Columns["IsActive"].Visible = true;
            }
            if (dataGridView1.Columns["RoleId"] != null)
            {
                dataGridView1.Columns["RoleId"].Visible = false;
            }
            if (dataGridView1.Columns["CommunityId"] != null)
            {
                dataGridView1.Columns["CommunityId"].Visible = false;
            }
            if (dataGridView1.Columns["RoleName"] != null)
            {
                dataGridView1.Columns["RoleName"].HeaderText = "Role";
                dataGridView1.Columns["RoleName"].Visible = true;
            }
            // "Roles" sütununu kaldırma
            if (dataGridView1.Columns["Roles"] != null)
            {
                dataGridView1.Columns.Remove("Roles");
            }

        }

        private void FillRoleComboBox()
        {
            var roles = _roleService.GetAllRoles();
            cmboxRole.DataSource = roles;
            cmboxRole.DisplayMember = "RoleName";
            cmboxRole.ValueMember = "RoleId";
        }

        private void FillDepartmentComboBox()
        {
            var departments = _departmentService.GetAllDepartments();
            cmbDeprt.DataSource = departments;
            cmbDeprt.DisplayMember = "DepartmentName";
            cmbDeprt.ValueMember = "DepartmentId";
        }

        private void FillCommunityComboBox()
        {
            var communities = _communityService.GetAllCommunities();
            if (communities != null && communities.Any())
            {
                cmboxCom.DataSource = communities;
                cmboxCom.DisplayMember = "CommunityName";
                cmboxCom.ValueMember = "CommunityId";
            }
            else
            {
                cmboxCom.DataSource = null;
                cmboxCom.Items.Clear();
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoleName.Text))
            {
                var role = new Role()
                {
                    RoleName = txtRoleName.Text,
                };
                _roleService.AddRole(role);
                FillRoleGrid();
                FillRoleComboBox();
                ClearData();
            }
            else
            {
                MessageBox.Show("Role name cannot be empty.");
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["RoleId"].Value;
                _roleService.DeleteRole(id);
                FillRoleGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a role to delete.");
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["RoleId"].Value;
                var role = _roleService.GetRoleById(id);
                if (role != null)
                {
                    role.RoleName = txtRoleName.Text;
                    _roleService.UpdateRole(role);
                    FillRoleGrid();
                }
                else
                {
                    MessageBox.Show("Role not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a role to update.");
            }
            ClearData();
        }

        private void btnDhowFaculty_Click(object sender, EventArgs e)
        {
            FillRoleGrid();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrsnName.Text) && cmbDeprt.SelectedValue != null && cmboxRole.SelectedValue != null && cmboxCom.SelectedValue != null)
            {
                var person = new Person()
                {
                    NameSurname = txtPrsnName.Text,
                    Email = txtEmail.Text,
                    Tel = txtTel.Text,
                    DepartmentId = (int)cmbDeprt.SelectedValue
                };

                _personService.AddPerson(person);

                var personRole = new PersonRole()
                {
                    PersonId = person.PersonId,
                    RoleId = (int)cmboxRole.SelectedValue,
                    CommunityId = (int)cmboxCom.SelectedValue,
                    IsActive = checkBoxActive.Checked
                };

                _personRoleService.AddPersonRole(personRole);

                FillPersonGrid();
                ClearData();
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
                var id = (int)dataGridView1.SelectedRows[0].Cells["PersonId"].Value;
                _personService.DeletePerson(id);
                FillPersonGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a person to delete.");
            }
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["PersonId"].Value;
                var person = _personService.GetPersonById(id);
                if (person != null)
                {
                    person.NameSurname = txtPrsnName.Text;
                    person.Email = txtEmail.Text;
                    person.Tel = txtTel.Text;
                    person.DepartmentId = (int)cmbDeprt.SelectedValue;

                    var existingPersonRole = _personRoleService.GetPersonRolesByPersonId(id).FirstOrDefault();
                    if (existingPersonRole != null)
                    {
                        _personRoleService.DeletePersonRole(existingPersonRole.PersonId, existingPersonRole.RoleId);

                        var newPersonRole = new PersonRole
                        {
                            PersonId = id,
                            RoleId = (int)cmboxRole.SelectedValue,
                            CommunityId = (int)cmboxCom.SelectedValue,
                            IsActive = checkBoxActive.Checked
                        };
                        _personRoleService.AddPersonRole(newPersonRole);
                    }

                    _personService.UpdatePerson(person);
                    FillPersonGrid();
                }
                else
                {
                    MessageBox.Show("Person not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a person to update.");
            }
            ClearData();
        }

        private void btnShowPerson_Click(object sender, EventArgs e)
        {
            FillPersonGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns.Contains("PersonId"))
                {
                    // Person selection
                    try
                    {
                        selectedPersonId = (int)selectedRow.Cells["PersonId"].Value;
                        txtPrsnName.Text = selectedRow.Cells["NameSurname"].Value?.ToString();
                        txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                        txtTel.Text = selectedRow.Cells["Tel"].Value?.ToString();

                        // Retrieve department and community based on person
                        int departmentId = _personService.GetPersonById(selectedPersonId)?.DepartmentId ?? 0;
                        cmbDeprt.SelectedValue = departmentId;

                        int communityId = _personRoleService.GetPersonRolesByPersonId(selectedPersonId)
                                                            .FirstOrDefault()?.CommunityId ?? 0;
                        cmboxCom.SelectedValue = communityId;

                        // Retrieve role and active status
                        int roleId = _personRoleService.GetPersonRolesByPersonId(selectedPersonId)
                                                        .FirstOrDefault()?.RoleId ?? 0;
                        cmboxRole.SelectedValue = roleId;

                        bool isActive = _personRoleService.GetPersonRolesByPersonId(selectedPersonId)
                                                          .Any(pr => pr.IsActive);
                        checkBoxActive.Checked = isActive;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving person details: {ex.Message}");
                    }
                }
                else if (dataGridView1.Columns.Contains("RoleId"))
                {
                    // Role selection
                    try
                    {
                        selectedRoleId = (int)selectedRow.Cells["RoleId"].Value;
                        txtRoleName.Text = selectedRow.Cells["RoleName"].Value?.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving role details: {ex.Message}");
                    }
                }
            }
        }

    }
}
