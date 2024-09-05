using CommunityIS.Service.Core;
using CommunityIS.Service.Model;
using System.Windows.Forms;

namespace CommunityIS.UI
{
    public partial class FacultyForm : Form
    {
        FacultyService _facultyService;
        DepartmentService _departmentService;
        int selectedFacultyId;
        int selectedDepartmentId;
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _facultyService = new FacultyService(db);
            _departmentService = new DepartmentService(db);
            FillFacultyComboBox();
        }

        void ClearData()
        {
            txtDepartmentName.Text = "";
            txtFacultyName.Text = "";
            cmboxFaculty.Text = "";
        }

        private void FillFacultyGrid()
        {
            var faculties = _facultyService.GetAllFaculties();
            var facultyData = faculties.Select(f => new
            {
                f.FacultyId,
                f.FacultyName
            }).ToList();

            dataGridView1.Columns.Clear(); // Clear existing columns
            dataGridView1.DataSource = facultyData;

            if (dataGridView1.Columns["FacultyId"] != null)
            {
                dataGridView1.Columns["FacultyId"].Visible = false;
            }
        }

        private void FillDepartmentGrid()
        {
            var departments = _departmentService.GetAllDepartments();
            var faculties = _facultyService.GetAllFaculties();

            var departmentFaculties = from dept in departments
                                      join fac in faculties
                                      on dept.FacultyId equals fac.FacultyId
                                      select new
                                      {
                                          DepartmentId = dept.DepartmentId,
                                          DepartmentName = dept.DepartmentName,
                                          FacultyName = fac.FacultyName
                                      };

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = departmentFaculties.ToList();

            if (dataGridView1.Columns["DepartmentId"] != null)
            {
                dataGridView1.Columns["DepartmentId"].Visible = false;
            }
            FillFacultyComboBox();
        }

        private void FillFacultyComboBox()
        {
            var faculties = _facultyService.GetAllFaculties();
            cmboxFaculty.DataSource = faculties;
            cmboxFaculty.DisplayMember = "FacultyName";
            cmboxFaculty.ValueMember = "FacultyId";
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            var faculty = new Faculty
            {
                FacultyName = txtFacultyName.Text
            };
            _facultyService.AddFaculty(faculty);
            FillFacultyGrid();
            FillFacultyComboBox();
            ClearData();
        }

        private void btnDeleteFaculty_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells["FacultyId"].Value;
            _facultyService.DeleteFaculty(id);
            FillFacultyGrid();
            FillFacultyComboBox();
            ClearData();
        }

        private void btnUpdateFaculty_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Columns.Contains("FacultyId"))
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["FacultyId"].Value;
                var faculty = _facultyService.GetFacultyById(id);
                faculty.FacultyName = txtFacultyName.Text;
                _facultyService.UpdateFaculty(faculty);
                FillFacultyComboBox();
                FillFacultyGrid();
            }
            else
            {
                MessageBox.Show("Please select the row you want to update.");
            }
            ClearData();
        }

        private void btnDhowFaculty_Click(object sender, EventArgs e)
        {
            FillFacultyGrid();
        }

        private void btnAddDeprt_Click(object sender, EventArgs e)
        {
            var department = new Department
            {
                DepartmentName = txtDepartmentName.Text,
                FacultyId = (int)cmboxFaculty.SelectedValue
            };
            _departmentService.AddDepartment(department);
            FillDepartmentGrid();
            ClearData();
        }

        private void btnDeleteDeprt_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells["DepartmentId"].Value;
            _departmentService.DeleteDepartment(id);
            FillDepartmentGrid();
            ClearData();
        }

        private void btnUpdateDeprt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Columns.Contains("DepartmentId"))
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["DepartmentId"].Value;
                var department = _departmentService.GetDepartmentById(id);
                department.DepartmentName = txtDepartmentName.Text;
                department.FacultyId = (int)cmboxFaculty.SelectedValue;

                // Check if the selected FacultyId is valid
                var selectedFaculty = _facultyService.GetFacultyById(department.FacultyId);
                if (selectedFaculty != null)
                {
                    _departmentService.UpdateDepartment(department);
                    FillDepartmentGrid();
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

        private void btnShowDeprt_Click(object sender, EventArgs e)
        {
            FillDepartmentGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns.Contains("DepartmentId"))
                {
                    // Department selection
                    try
                    {
                        selectedDepartmentId = (int)selectedRow.Cells["DepartmentId"].Value;
                        txtDepartmentName.Text = selectedRow.Cells["DepartmentName"].Value.ToString();

                        // Retrieve faculty based on department
                        int facultyId = _departmentService.GetDepartmentById(selectedDepartmentId).FacultyId;   //Getirilen departman nesnesinin FacultyId özelliði, facultyId deðiþkenine atanýr.
                        cmboxFaculty.SelectedValue = facultyId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving department details: {ex.Message}");
                    }
                }

                else if (dataGridView1.Columns.Contains("FacultyId"))
                {
                    // Faculty selection
                    try
                    {
                        selectedFacultyId = (int)selectedRow.Cells["FacultyId"].Value;
                        txtFacultyName.Text = selectedRow.Cells["FacultyName"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving faculty details: {ex.Message}");
                    }
                }
            }
        }

        private void btnPersonRoleForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
