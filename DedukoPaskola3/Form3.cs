using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace DedukoPaskola3
{
    public partial class logInMenu : Form
    {
        public logInMenu()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passBox.Text;
            Match(username, password);
        }

        public void Match(string user, string pass)
        {
            string temp = "";

            if (File.Exists(user))
            {
                string[] lines = File.ReadAllLines(user);
                temp = lines[0];
            }

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please fill in the credentials", "Missing Information", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }
            else if (!File.Exists(user) || pass != temp)
            {
                MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Clear();
                passBox.Clear();
            }
            else if (File.Exists(user) && pass == temp)
            {
                MessageBox.Show("You Logged In!", "Congratulations!", MessageBoxButtons.OK);
                this.Hide();
                mainProgram loanProgram = new mainProgram();
                loanProgram.pusername = user;
                loanProgram.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInMenu logInMenu = new logInMenu();
            logInMenu.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
