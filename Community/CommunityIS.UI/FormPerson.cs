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
    public partial class FormPerson : Form
    {
        PersonService _personService;
        DepartmentService _departmentService;
        int selectedPersonId;

        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _personService = new PersonService(db);
            _departmentService = new DepartmentService(db);
            FillDepartmentComboBox();
            FillPersonGrid();
        }

        private void ClearData()
        {
            txtEmail.Text = "";
            txtPrsnName.Text = "";
            txtTel.Text = "";
            cmbDeprt.Text = "";
        }

        private void FillPersonGrid()   //join evnt
        {
            var people = _personService.GetAllPeople();
            var personData = people.Select(p => new
            {
                p.PersonId,
                p.NameSurname,
                p.Email,
                p.Tel,
                DepartmentName = p.Department.DepartmentName
            }).ToList();

            dataGridView1.DataSource = personData;

            if (dataGridView1.Columns["PersonId"] != null)
            {
                dataGridView1.Columns["PersonId"].Visible = false;
            }
        }

        private void FillDepartmentComboBox()
        {
            var departments = _departmentService.GetAllDepartments();
            cmbDeprt.DataSource = departments;
            cmbDeprt.DisplayMember = "DepartmentName";
            cmbDeprt.ValueMember = "DepartmentId";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrsnName.Text) && cmbDeprt.SelectedValue != null)
            {
                var person = new Person()
                {
                    NameSurname = txtPrsnName.Text,
                    Email = txtEmail.Text,
                    Tel = txtTel.Text,
                    DepartmentId = (int)cmbDeprt.SelectedValue
                };
                _personService.AddPerson(person);
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
                    try
                    {
                        selectedPersonId = (int)selectedRow.Cells["PersonId"].Value;
                        txtPrsnName.Text = selectedRow.Cells["NameSurname"].Value?.ToString();
                        txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                        txtTel.Text = selectedRow.Cells["Tel"].Value?.ToString();
                        cmbDeprt.Text = selectedRow.Cells["DepartmentName"].Value?.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving person details: {ex.Message}");
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
