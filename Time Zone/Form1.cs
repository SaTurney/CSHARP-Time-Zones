//Sabrina Turney
//C# I
//Chapter 4 Tutorial - Time Zone Program
//Last Edited: August 31, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //create a city variable that is used later:
            string city;
            
            if (cityListBox.SelectedIndex != -1) //when a city is selected:
            {
                //convert the list box item name into a string for the variable
                city = cityListBox.SelectedItem.ToString();

                //since we're using a timezone system, we need to assign them to each text box value.
                switch(city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                }
            }
           else //no city has been selected: we want to ask the user to click a textbox option.
            {
                MessageBox.Show("Select a city.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Exits the program.
            this.Close();
        }
    }
}
