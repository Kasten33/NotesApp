using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable()
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 235; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();

        }

        private void BttnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void GoForm2_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Title = txtTitle.Text;
            secondForm.Message = txtMessage.Text;
            secondForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
