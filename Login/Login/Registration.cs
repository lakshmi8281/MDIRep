using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Component;

namespace Login
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Registr obj = new Registr();
            bool re = false ;
            obj.UserName = txtusername.Text;
            obj.Password = txtpassword.Text;
            obj.email = txtemail.Text;
            obj.mobile = Convert.ToInt32(txtmobile.Text);
            re = obj.GetConnection();
           
            if (re)
            {
                MessageBox.Show("Registration Successfull,Lakshmi-Junior-CEO");
                ClearAll();


            }
            else
            {
                MessageBox.Show("reg failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        protected void ClearAll()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtmobile.Text = "";

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace System.Configuration
{
    class ConfigurationManager
    {
        public static string ConnectionString { get; internal set; }
    }
}