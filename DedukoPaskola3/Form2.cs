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
using System.Runtime.InteropServices;

namespace DedukoPaskola3
{
    public partial class signMenu : Form
    {

        
        public signMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        protected void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void placeHolder(object sender, EventArgs e)
        {
        }

        public void pass1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void pass2_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void usernameLabel_Click(object sender, EventArgs e)
        //{

        //}

        public void Match(string user, string pass1, string pass2)
        {

            if (!File.Exists(user))
            {
                if (user == "" || pass1 == "" || pass2 == "")
                {
                    MessageBox.Show("Please fill in the credentials", "Missing Information", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                }
                else if (pass1 == pass2)
                {
                    File.AppendAllText(user, pass1);
                    MessageBox.Show("All Signed up!");
                    this.Hide();
                    logInMenu logInMenu = new logInMenu();
                    logInMenu.ShowDialog();
                }
                else
                {
                    
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameBox.Clear();
                    passBox1.Clear();
                    passBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("This user already has an account", "Wrong Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string temp1 = passBox1.Text;
            string temp2 = passBox2.Text; 

            Match(username, temp1, temp2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
