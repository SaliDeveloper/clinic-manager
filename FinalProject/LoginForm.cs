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
using FinalProject.Main_Classes.Controllers;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cmb_login_type.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IProfile profile = new Profile("Mahdi", "Salmani", "4420860278");
            var manageAppointments = new AppointmentsManager("appointments.txt",new JsonSaveLoadAppointments());
            var patient = new Patient(profile,manageAppointments);

            Form form = new PatientForm(manageAppointments,patient);
            form.ShowDialog();
            this.Close();
        }
    }
}
