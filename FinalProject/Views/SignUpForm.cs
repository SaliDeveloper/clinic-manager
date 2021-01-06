using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Main_Classes;

namespace FinalProject.Views
{
    public partial class SignUpForm : Form
    {
        private readonly List<Patient> _patients;
        public SignUpForm(List<Patient> patients)
        {
            InitializeComponent();
            _patients = patients;
            btn_cancel.Select();
        }

        public SignUpForm(List<Patient> patients, Patient patient) : this(patients)
        {
            ctxt_name.Text = patient.Profile.FirstName;
            ctxt_last_name.Text = patient.Profile.LastName;
            ctxt_national_code.Text = patient.Profile.NationalCode;
            ctxt_username.Text = patient.Account.UserName;
            ctxt_pre_password.Enabled = true;
            ctxt_pre_password.Text = "";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ctxt_name.Text))
                {
                    throw new Exception("Please enter your first name.");
                }

                var firstName = ctxt_name.Text;

                if (string.IsNullOrEmpty(ctxt_last_name.Text))
                {
                    throw new Exception("Please enter your last name.");
                }

                var lastName = ctxt_last_name.Text;

                if (string.IsNullOrEmpty(ctxt_national_code.Text) ||
                    long.TryParse(ctxt_national_code.Text, out _))
                {
                    throw new Exception("Please enter a valid national code");
                }

                var nationalCode = ctxt_national_code.Text;
                var userName = string.IsNullOrEmpty(ctxt_username.Text) ? lastName : ctxt_username.Text;

                if (_patients.Exists(a => a.Profile.NationalCode == nationalCode || a.Account.UserName == userName))
                {
                    throw new Exception("this account already exists.");
                }

                if (string.IsNullOrEmpty(ctxt_password.Text) ||
                    string.IsNullOrEmpty(ctxt_confirm_password.Text))
                {
                    throw new Exception("Please enter the password.");
                }
                if (ctxt_password.Text.Equals(ctxt_confirm_password.Text))
                {
                    throw new Exception("confirm password doesn't match.");
                }
                var password = ctxt_password.Text;
                var patient = new Patient(new Profile(firstName, lastName, nationalCode,
                    (radioBtn_Woman.Checked) ? Gender.Woman : Gender.Man));
                _patients.Add(patient);
                //todo
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }
    }
}
