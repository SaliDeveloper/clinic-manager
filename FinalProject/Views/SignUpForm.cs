using FinalProject.Interfaces;
using FinalProject.Main_Classes;
using FinalProject.Main_Classes.Controllers;
using System;
using System.Windows.Forms;

namespace FinalProject.Views
{
    public partial class SignUpForm : Form
    {
        private readonly DataManager<Patient> _patientsManager;
        private readonly Patient _patient;
        public SignUpForm(DataManager<Patient> patientsManager)
        {
            InitializeComponent();
            _patientsManager = patientsManager;
            btn_cancel.Select();
        }

        public SignUpForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            btn_cancel.Select();
            ctxt_name.SetText(patient.Profile.FirstName);
            ctxt_last_name.SetText(patient.Profile.LastName);
            ctxt_national_code.SetText(patient.Profile.NationalCode);
            ctxt_username.SetText(patient.UserAccount.UserName);
            ctxt_pre_password.Enabled = true;
            radioBtn_Man.Checked = patient.Profile.Gender == Gender.Man;
            radioBtn_Woman.Checked = patient.Profile.Gender == Gender.Woman;
            ctxt_national_code.Enabled = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = (string.IsNullOrEmpty(ctxt_name.GetText())) ? "" : ctxt_name.GetText();

                if (string.IsNullOrEmpty(ctxt_last_name.GetText()))
                    throw new Exception("Please enter your last name.");

                var lastName = ctxt_last_name.GetText();

                if (string.IsNullOrEmpty(ctxt_national_code.GetText()) || !long.TryParse(ctxt_national_code.GetText(), out _))
                    throw new Exception("Please enter a valid national code");

                var nationalCode = ctxt_national_code.GetText();
                var userName = string.IsNullOrEmpty(ctxt_username.GetText()) ? lastName : ctxt_username.GetText();

                if (ctxt_national_code.Enabled)
                {
                    checkForAddNewItem(nationalCode, userName);
                    checkForPassword();
                    var password = ctxt_password.GetText();
                    var gender = (radioBtn_Woman.Checked) ? Gender.Woman :
                        (radioBtn_Man.Checked) ? Gender.Man : Gender.None;
                    var patient = new Patient(
                        new Profile(firstName, lastName, nationalCode, gender),
                        new UserAccount() { Password = password, UserName = userName }
                    );
                    _patientsManager.AddItem(patient);
                }
                else
                {
                    _patient.Profile.FirstName = firstName;
                    _patient.Profile.LastName = lastName;
                    if (ctxt_password.GetText().Length>0)
                    {
                        if (ctxt_pre_password.GetText() != _patient.UserAccount.Password)
                        {
                            throw new Exception("Enter your current password correctly.");
                        }
                        checkForPassword();
                        _patient.UserAccount.Password = ctxt_password.GetText();
                    }
                    _patient.UserAccount.UserName = userName;
                }
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Fill out the form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void checkForAddNewItem(string nationalCode, string userName)
        {
            if (_patientsManager.Items.Exists(a =>
                a.Profile.NationalCode == nationalCode || a.UserAccount.UserName == userName))
            {
                throw new Exception("this account already exists.");
            }
        }
        void checkForPassword()
        {
            if (string.IsNullOrEmpty(ctxt_password.GetText()) ||
                string.IsNullOrEmpty(ctxt_confirm_password.GetText()))
            {
                throw new Exception("Please enter the password.");
            }
            if (ctxt_password.GetText() != ctxt_confirm_password.GetText())
            {
                throw new Exception("confirm password doesn't match.");
            }
        }

    }
}
