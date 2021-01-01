using FinalProject.Main_Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinalProject.Main_Classes.Dental_Specialties;

namespace FinalProject
{
    public partial class HomeForm : Form
    {
        private List<Appointment> appointments = new List<Appointment>();
        public HomeForm()
        {
            InitializeComponent();
            appointments.Add(new Appointment(
                new Patient(new Profile("mahdi", "salmani", "4420860278")),
                new Endodontics(new Profile("Ali", "Alavi", "1234567890"), new BankAccount("1234567890"), 20, new List<DayOfWeek>()),
                DateTime.Now)
                );
            appointments.Add(new Appointment(
                new Patient(new Profile("mammad", "salami", "4420860278")),
                new PediatricDentistry(new Profile("amir", "Hamidi", "1234567890"), new BankAccount("1234567890"), 20, new List<DayOfWeek>()),
                DateTime.Now)
            );
            appointments.Add(new Appointment(
                new Patient(new Profile("mammad", "salami", "4420860278")),
                new Orthodontics(new Profile("amir", "Dehghani zade", "1234567890"), new BankAccount("1234567890"), 20, new List<DayOfWeek>()),
                DateTime.Now)
            );
            foreach (Appointment item in appointments)
            {
                dataGridView1.Rows.Add(
                    item.StartTime.ToString("t"),
                    item.Duration,
                    item.Specialty,
                    item.Dentist,
                    "Edit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
