using Microsoft.Data.SqlClient;
using Assignment2_EAD.ViewModels;
using System.Windows;
using Assignment2_EAD.Views;

namespace Assignment2_EAD.Models
{
    class Admin:BasicViewModel
    {
        private string UserName;

        public string userName
        {
            get { return UserName; }
            set { UserName = value; onPropertyChange("UserName"); }
        }
        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; onPropertyChange("Password"); }
        }
        public void viewAllProducts()
        {
            AllProducts a = new AllProducts();
            a.Show();
        }
        public void LogOut()
        {
            Application.Current.Shutdown();
        }
        public void LogIn()
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                connection.Open();
                string query = "Select * from Admin where Name=@N and Password=@Pswd";
                SqlParameter p1 = new SqlParameter("N", userName);
                SqlParameter p2 = new SqlParameter("Pswd", password);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                SqlDataReader dr = cmd.ExecuteReader();
                bool verify = false;
                while (dr.Read())
                {
                    verify = true;
                }
                if (verify == true)
                {
                    MessageBox.Show("You have sucessfully Signed In");
                    AdminView v = new AdminView();
                    v.Show();
                }
                else
                {
                    MessageBox.Show("LogIn failed, Please enter correct UserID and Password");
                }
            }
            else
            {
                MessageBox.Show("Please Enter all the necessery values");
            }
            connection.Close();
        }
       


    }
    
}
