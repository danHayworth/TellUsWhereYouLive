using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Dan Hayworth
 * Display Cities of specific countries
 */

namespace Task2Cities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create strings to store values for all form fields
        public string country;
        public string city;
        public string nameRegister;
        //create the list for new user registration
        ArrayList register = new ArrayList();
        //create lists of cities based on a country
        string[] ausie = { "Perth", "Sydney", "Melbourne", "Darwin" };
        string[] newsie = { "Wellington", "Auckland", "Christchurch"};

        //on selected country append the combo box with cities specific to countries
        private void listCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = listCountries.SelectedItem.ToString();
            if(country == "New Zealand")
            {
                comboCity.Items.Clear();
                comboCity.Items.AddRange(newsie);
            }
            else if (country == "Australia")
            {
                comboCity.Items.Clear();
                comboCity.Items.AddRange(ausie);
            }
        }

        //on submit store the new user details in a list and then print out the 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            country = listCountries.SelectedItem.ToString();
            city = comboCity.SelectedItem.ToString();
            nameRegister += txtName.Text;
            register.Add(nameRegister + " lives in " + city + " " + country + ".");
            MessageBox.Show((string)register[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
