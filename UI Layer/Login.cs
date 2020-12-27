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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
          Application.Exit();
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(usernameTextBox.Text, passwordTextBox.Text);
                if (result)
                {
                    EventManagement eventManagement = new EventManagement();
                    eventManagement.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}

