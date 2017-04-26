using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;



namespace Login.Component
{
    class Registr
    {
        string str = "Data Source=LAKSHMI-LAPTOP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";
       

        public string UserName
        {
            get;
            set;
        }
        
        public string Password
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public int mobile
        {
            get;
            set;
        }

      
        public object textBox1 { get; private set; }
        public object textBox2 { get; private set; }

        //public object TextBox1 { get => TextBox1; set => TextBox1 = value; }
        //public object TextBox2 { get => textBox2; set => textBox2 = value; }


        public  bool GetConnection()
        {
            SqlConnection conn = new SqlConnection(str);
            int res = 0;
            bool status = false;
            //myconn.ConnectionString = "Data Source = LAKSHMI - LAPTOP\\SQLEXPRESS; Initial Catalog = Login; Integrated Security = True";
            
            try
            {
                //myconn =RegDB.GetDbConnection();
                conn.Open();
                string insertQuerry = "insert into Reg(UserName,Password,email,mobile)values(@username,@password,@email,@mobile)";
                SqlCommand cmdInsert = new SqlCommand(insertQuerry, conn);
                
                cmdInsert.Parameters.AddWithValue("@username", this.UserName);
                cmdInsert.Parameters.AddWithValue("@password", this.Password);
                cmdInsert.Parameters.AddWithValue("@email", this.email);
                cmdInsert.Parameters.AddWithValue("@mobile", this.mobile);



                res = cmdInsert.ExecuteNonQuery();

                if (res > 0)
                {
                    status = true;
                    
                    
                }
                else
                {
                    status = false;

                }

            }

            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
        }




        public bool loginn()
        {

            SqlConnection myconn = new SqlConnection(str);
            bool status = false;
            int res = 0;
            try
            {
                myconn.Open();
                string SelectQuery = "select * FROM Reg WHERE UserName=@UserName and Password=@Password";


                //string SelectQuery = "select * from Reg";
               SqlCommand cmdSelect = new SqlCommand(SelectQuery, myconn);
                cmdSelect.Parameters.AddWithValue("@username", this.UserName);
                cmdSelect.Parameters.AddWithValue("@password", this.Password);
                SqlDataReader reader = cmdSelect.ExecuteReader();


                // res = cmdSelect.ExecuteReader();

                if (reader.HasRows)
                {
                    status = true;
                }
                else
                {
                    status = false;

                }

                                               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myconn.Close();
            }
            return status;
        }

    }
}
