using FinalProject.Interfaces;
using FinalProject.Main_Classes;
using FinalProject.Main_Classes.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject.Views
{
    public partial class AppointmentForm : Form
    {
        private readonly DataManager<Appointment> _appointmentsManager;
        private readonly DataManager<IDoctor> _doctorsManager;
        private readonly Patient _patient;
        private List<IDoctor> _doctors = new List<IDoctor>();

        private AppointmentForm(DataManager<Appointment> appointmentsManager, Patient patient)
        {
            InitializeComponent();
            _appointmentsManager = appointmentsManager;
            _patient = patient;
            datePicker.MinDate = DateTime.Now;
            cmb_specialties.DataSource = Dentist.Specialties;
            cmb_specialties.SelectedIndex = 0;
        }

        public AppointmentForm(DataManager<Appointment> appointmentsManager, Patient patient,
            DataManager<IDoctor> doctorsManager) : this(appointmentsManager, patient)
        {
            _doctorsManager = doctorsManager;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_specialties.SelectedIndex == -1)
                    throw new Exception("Please choose the specialty.");
                if (cmb_doctors.SelectedIndex == -1)
                    throw new Exception("Please choose the doctor.");

                var appointment = new Appointment(_patient.Id, _doctors[cmb_doctors.SelectedIndex].Id,
                    DateTime.Now /*  todo  */);
                _appointmentsManager.AddItem(appointment);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_specialties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_doctorsManager == null) return;
            _doctors = _doctorsManager.Items
                .FindAll(a => a.GetType().Name == cmb_specialties.Text);

            cmb_doctors.DataSource = _doctors.Select(a => a.ToString()).ToList();
        }
    }
}
