using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Interfaces;
using FinalProject.Main_Classes;
using FinalProject.Main_Classes.Controllers;

namespace FinalProject.Views
{
    public partial class LoginForm : Form
    {
        private int _mistakes = 3;
        private readonly DataManager<Patient> _patientsManager;
        private readonly DataManager<Appointment> _appointmentsManager;
        public LoginForm()
        {
            InitializeComponent();
            cmb_login_type.SelectedIndex = 0;
            cmb_login_type.Select();
            _appointmentsManager =
                new DataManager<Appointment>("appointments.txt", new JsonSaveLoadData<Appointment>());
            _patientsManager = new DataManager<Patient>("patients.txt", new JsonSaveLoadData<Patient>());
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_username.GetText()))
                {
                    throw new ArgumentException("Please enter your username.");
                }

                if (string.IsNullOrEmpty(txt_password.GetText()))
                {
                    throw new ArgumentException("Please enter your password.");
                }

                var patient = _patientsManager.Items.Find(a => a.UserAccount.UserName == txt_username.GetText());
                if (patient == null || patient.UserAccount.Password != txt_password.GetText())
                {
                    throw new AccessViolationException();
                }

                Form form = new PatientForm(_appointmentsManager, patient);
                form.ShowDialog();
                Hide();
                Close();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (AccessViolationException)
            {
                if ((--_mistakes) < 0) Close();
                MessageBox.Show("Please try again.", "Incorrect username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            Form form = new SignUpForm(_patientsManager);
            form.ShowDialog();
        }
    }
}
