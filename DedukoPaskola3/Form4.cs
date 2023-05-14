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

namespace DedukoPaskola3
{
    public partial class mainProgram : Form
    {

        //public string pusername = "";
        public string pusername { get; set; }
        public mainProgram()
        {
            InitializeComponent();
        }

        DataTable loan = new DataTable("tbl");
        int indexRow;
        private void mainProgram_Load(object sender, EventArgs e)
        {

            loan.Columns.Add("Id", typeof(int));
            loan.Columns.Add("First Name", typeof(string));
            loan.Columns.Add("Last Name", typeof(string));
            loan.Columns.Add("Amount Loaned (Eur)", typeof(float));
            loan.Columns.Add("Amount with Interest", typeof(float));

            loan.ReadXml("storage.xml");
            dataGridView1.DataSource = loan;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                float amount = float.Parse(tableAmountBox.Text);
                amount = (float)Math.Round(amount + (amount * 0.03));
                loan.Rows.Add(tableIDBox.Text, tableFirstBox.Text, tableLastBox.Text, tableAmountBox.Text, amount);
                dataGridView1.DataSource = loan;

                tableIDBox.Clear();
                tableFirstBox.Clear();
                tableLastBox.Clear();
                tableAmountBox.Clear();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please input correct data!", "Error", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input correct data!", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            loan.WriteXml("storage.xml", XmlWriteMode.WriteSchema);
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            tableIDBox.Text = row.Cells[0].Value.ToString();
            tableFirstBox.Text = row.Cells[1].Value.ToString();
            tableLastBox.Text = row.Cells[2].Value.ToString();
            tableAmountBox.Text = row.Cells[3].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];

            try
            {
                newDataRow.Cells[0].Value = tableIDBox.Text;
                newDataRow.Cells[1].Value = tableFirstBox.Text;
                newDataRow.Cells[2].Value = tableLastBox.Text;
                newDataRow.Cells[3].Value = tableAmountBox.Text;
                float amount = float.Parse(tableAmountBox.Text);
                amount = (float)Math.Round(amount + (amount * 0.03));
                newDataRow.Cells[4].Value = amount;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please input correct data!", "Error", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input correct data!", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indexRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(indexRow);
        }

        private void mainProgram_Deactivate(object sender, EventArgs e)
        {
        //    string temp = pusername;
        //    //File.OpenWrite(temp);
        //    loan.WriteXml("storage.xml", XmlWriteMode.WriteSchema);
        //    MessageBox.Show("Data exported");
        }
    }
}
