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
    public partial class FormRole : Form
    {
        RoleService _roleService;
        int selectedRoleId;

        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _roleService = new RoleService(db);
            FillRoleGrid();
        }

        private void ClearData()
        {
            txtRoleName.Text = "";
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

        private void btnShowRoless_Click(object sender, EventArgs e)
        {
            FillRoleGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns.Contains("RoleId"))
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

        private void btnPersonRoleForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();           
        }
    }
}
