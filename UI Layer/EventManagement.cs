using DigitalDairy1.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDairy1
{
    public partial class EventManagement : Form
    {
        public EventManagement()
        {
            InitializeComponent();
        }
        private void EventManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventManagement_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            EventServices eventService = new EventServices();
            int result = eventService.AddNewEvent(eventNametextBox3.Text, ImportancetextBox4.Text, DatetextBox1.Text, DetailstextBox2.Text);
            if (result > 0)
            {
                MessageBox.Show("New Event added successfully");

            }
            else
            {
                MessageBox.Show("Error in adding new event");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            EventServices eventService = new EventServices();
            int result = eventService.DeleteNewEvent(eventNametextBox3.Text, ImportancetextBox4.Text, DatetextBox1.Text, DetailstextBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("New Event deleted successfully");

            }
            else
            {
                MessageBox.Show("Error in adding new event");
            }
        }
    }
}
