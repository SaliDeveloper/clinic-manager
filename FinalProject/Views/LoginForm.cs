using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Main_Classes;
using FinalProject.Main_Classes.Controllers;

namespace FinalProject.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cmb_login_type.SelectedIndex = 0;
            cmb_login_type.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IProfile profile = new Profile("Mahdi", "Salmani", "4420860278");
            var manageAppointments = new DataManager("appointments.txt",new JsonSaveLoadData());
            var patient = new Patient(profile);

            Form form = new PatientForm(manageAppointments,patient);
            form.ShowDialog();
            this.Close();
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            //todo
            Form form = new SignUpForm(new List<Patient>());
            form.ShowDialog();
        }
    }
}
