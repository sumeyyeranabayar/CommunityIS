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
    public partial class EventForm : Form
    {
        EventService _eventService;
        CommunityService _communityService;
        int selectedEventId;

        public EventForm()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            var db = new CommunityContext();
            _eventService = new EventService(db);
            _communityService = new CommunityService(db);
            FillCommunityComboBox();
            FillEventGrid();
        }

        void ClearData()
        {
            txtEventName.Text = "";
            txtDescrpt.Text = "";
            cmboxCom.Text = "";
        }

        private void FillEventGrid()
        {
            var events = _eventService.GetAllEvents();
            var eventCommunities = from evnt in events
                                   join com in _communityService.GetAllCommunities()
                                   on evnt.CommunityId equals com.CommunityId
                                   select new
                                   {
                                       evnt.EventId,
                                       evnt.EventName,
                                       evnt.EventDate,
                                       evnt.Description,
                                       evnt.CommunityId,
                                       com.CommunityName
                                   };
            dataGridView1.DataSource = eventCommunities.ToList();
            dataGridView1.Columns["CommunityId"].Visible = false;
        }

        private void FillCommunityComboBox()
        {
            var communities = _communityService.GetAllCommunities();
            cmboxCom.DataSource = communities;
            cmboxCom.DisplayMember = "CommunityName";
            cmboxCom.ValueMember = "CommunityId";
        }

        private void btnAddEvnt_Click(object sender, EventArgs e)
        {
            var @event = new CommunityIS.Service.Model.Event
            {
                EventName = txtEventName.Text,
                CommunityId = (int)cmboxCom.SelectedValue,
                Description = string.IsNullOrWhiteSpace(txtDescrpt.Text) ? null : txtDescrpt.Text,    //txtDescrpt text box'ının değerini kontrol eder ve eğer değer null, boş veya sadece boşluk karakterleri içeriyorsa değişkene null değerini atar. Aksi takdirde, txtDescrpt.Text değerini değişkene atar.
                EventDate = dateTimePicker1.Value
            };
            _eventService.AddEvent(@event);
            FillEventGrid();
            ClearData();
        }

        private void btnDeleteEvnt_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells["EventId"].Value;
            _eventService.DeleteEvent(id);
            FillEventGrid();
            ClearData();
        }

        private void btnUpdateEvnt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedEventId = (int)dataGridView1.SelectedRows[0].Cells["EventId"].Value;
                var evnt = _eventService.GetEventById(selectedEventId);
                evnt.EventName = txtEventName.Text;
                evnt.CommunityId = (int)cmboxCom.SelectedValue;
                evnt.Description = string.IsNullOrWhiteSpace(txtDescrpt.Text) ? null : txtDescrpt.Text;
                evnt.EventDate = dateTimePicker1.Value;
                _eventService.UpdateEvent(evnt);
                FillEventGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the row you want to update.");
            }
        }

        private void btnShowEvnt_Click(object sender, EventArgs e)
        {
            FillEventGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedEventId = (int)selectedRow.Cells["EventId"].Value;
                txtEventName.Text = selectedRow.Cells["EventName"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["EventDate"].Value);
                cmboxCom.SelectedValue = (int)selectedRow.Cells["CommunityId"].Value;

                var descriptionCell = selectedRow.Cells["Description"];

                if (descriptionCell != null && descriptionCell.Value != null && descriptionCell.Value != DBNull.Value)
                {
                    txtDescrpt.Text = descriptionCell.Value.ToString();
                }
                else
                {
                    txtDescrpt.Text = ""; // Boşsa TextBox'u temizle
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
