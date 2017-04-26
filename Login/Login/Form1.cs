using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Login.Component;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration robj = new Registration();
            robj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool ress;
            Registr obj1 = new Registr();

            obj1.UserName = textBox1.Text;
            obj1.Password = textBox2.Text;
            ress = obj1.loginn();




            if (ress)
            {
        
                Page3 p = new Page3();
                p.Show();
                //MessageBox.Show("login sucessfull");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
