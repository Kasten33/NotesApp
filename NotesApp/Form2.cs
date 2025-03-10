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
    public partial class Form2 : Form
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public Form2()
        {
            InitializeComponent();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtTitle2.Text = Title;
            txtMessage2.Text = Message;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            txtMessage2.Clear();
            txtTitle2.Clear();
        }
    }
}
