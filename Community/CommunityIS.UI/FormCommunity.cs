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
    public partial class CommunityForm : Form
    {
        CommunityService _communityService;
        FacultyService _facultyService;
        int selectedCommunityId;
        public CommunityForm()
        {
            InitializeComponent();
        }

        private void Community_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _communityService = new CommunityService(db);
            _facultyService = new FacultyService(db);

            FillCommunityGrid();
            FillFacultyComboBox();
        }

        void ClearData()
        {
            txtComName.Text = "";
            cmboxFaculty.Text = "";
        }

        private void FillFacultyComboBox()
        {
            var faculties = _facultyService.GetAllFaculties();
            cmboxFaculty.DataSource = faculties;
            cmboxFaculty.DisplayMember = "FacultyName";
            cmboxFaculty.ValueMember = "FacultyId";
        }

        private void FillCommunityGrid()
        {
            var communities = _communityService.GetAllCommunities();
            var faculties = _facultyService.GetAllFaculties();

            var communityFaculties = from com in communities
                                     join fac in faculties
                                     on com.FacultyId equals fac.FacultyId
                                     select new
                                     {
                                         CommunityId = com.CommunityId,
                                         CommunityName = com.CommunityName,
                                         FacultyName = fac.FacultyName
                                     };

            dataGridView1.Columns.Clear(); // Existing columns temizle
            dataGridView1.DataSource = communityFaculties.ToList();

            if (dataGridView1.Columns["CommunityId"] != null)
            {
                dataGridView1.Columns["CommunityId"].Visible = false;
            }
        }

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            var community = new CommunityIS.Service.Model.Community
            {
                CommunityName = txtComName.Text,
                FacultyId = (int)cmboxFaculty.SelectedValue
            };
            _communityService.AddCommunity(community);
            FillCommunityGrid();
            ClearData();
        }

        private void btnDeleteCom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Columns.Contains("CommunityId"))
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["CommunityId"].Value;
                _communityService.DeleteCommunity(id);
                FillCommunityGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the row you want to delete.");
            }
        }

        private void btnUpdateCom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Columns.Contains("CommunityId"))
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["CommunityId"].Value;
                var community = _communityService.GetCommunityById(id);
                community.CommunityName = txtComName.Text;
                community.FacultyId = (int)cmboxFaculty.SelectedValue;

                // Check if the selected FacultyId is valid
                var selectedFaculty = _facultyService.GetFacultyById(community.FacultyId);
                if (selectedFaculty != null)
                {
                    _communityService.UpdateCommunity(community);
                    FillCommunityGrid();
                }
                else
                {
                    MessageBox.Show("Selected FacultyId is not valid.");
                }
            }
            else
            {
                MessageBox.Show("Please select the row you want to update.");
            }
            ClearData();
        }

        private void btnShowCom_Click(object sender, EventArgs e)
        {
            FillCommunityGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns.Contains("CommunityId"))
                {
                    try
                    {
                        selectedCommunityId = (int)selectedRow.Cells["CommunityId"].Value;
                        txtComName.Text = selectedRow.Cells["CommunityName"].Value.ToString();

                        // Retrieve faculty based on community
                        int facultyId = _communityService.GetCommunityById(selectedCommunityId).FacultyId;
                        cmboxFaculty.SelectedValue = facultyId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving community details: {ex.Message}");
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
