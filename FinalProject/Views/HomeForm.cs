using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Interfaces;
using FinalProject.Main_Classes;
using FinalProject.Main_Classes.Controllers;

namespace FinalProject.Views
{
    public partial class PatientForm : Form
    {
        private readonly Patient _patient;
        private readonly DataManager<Appointment> _appointmentsManager;
        private readonly DataManager<IDoctor> _doctorsManager;
        private List<Appointment> _appointments;

        public PatientForm(DataManager<Appointment> appointmentsManager, Patient patient)
        {
            InitializeComponent();
            _appointmentsManager = appointmentsManager;
            _patient = patient;
            FillProfileTable();
            _appointments = appointmentsManager.Items.FindAll(a => a.PatientId == patient.Id);

            _doctorsManager = new DataManager<IDoctor>("doctors.txt", new JsonSaveLoadDentists());
            FillAppointmentsTable(_appointments);
        }

        private void FillProfileTable()
        {
            lbl_1_2.Text = _patient.Profile.FirstName + " " + _patient.Profile.LastName;
            lbl_2_2.Text = _patient.Profile.NationalCode;
            lbl_3_2.Text = _patient.Profile.Gender.ToString();
            lbl_4_2.Text = (_patient.Insurance != null) ?
                _patient.Insurance.ExpirationDate.ToString("d") : "No insurance";
        }

        public void FillAppointmentsTable(List<Appointment> appointments)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in appointments)
            {
                var doctor = _doctorsManager.Items.Find(a => a.Id == item.DoctorId);
                dataGridView1.Rows.Add(item.StartTime.ToString("M"),
                    item.StartTime.ToString("t"),
                    doctor.VisitDuration,
                    doctor.Type,
                    doctor.ToString(),
                    "Delete");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void btn_add_appointment_Click(object sender, EventArgs e)
        {
            Form form = new AppointmentForm(_appointmentsManager, _patient,_doctorsManager);
            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) return;
            _appointments = _appointmentsManager.Items;
            FillAppointmentsTable(_appointments);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5) return;
            var result = MessageBox.Show("Are you sure?", "Delete Appointment"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _appointmentsManager.RemoveItem(_appointments[e.RowIndex]);
                _appointments.RemoveAt(e.RowIndex);
                FillAppointmentsTable(_appointments);
            }
        }

        private void btn_edit_profile_Click(object sender, EventArgs e)
        {
            Form form = new SignUpForm(_patient);
            form.ShowDialog();
        }
    }
}
