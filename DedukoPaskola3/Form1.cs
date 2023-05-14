using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedukoPaskola3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainSign_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            signMenu signMenu = new signMenu();
            signMenu.ShowDialog();

        }

        private void mainLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInMenu logInMenu = new logInMenu();
            logInMenu.ShowDialog();

        }

        //private void noBorder(object sender, EventArgs e)
        //{
        //    //this.FormBorderStyle = FormBorderStyle.None;
        //}

        private void mouseHover(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.White;
        }

        private void Hide(object sender, EventArgs e)
        {
            this.Hide(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainProgram kontaktai = new mainProgram();
            kontaktai.ShowDialog();
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }




        //private void mainSign_MouseEnter(object sender, EventArgs e)
        //{

        //}
    }
}
