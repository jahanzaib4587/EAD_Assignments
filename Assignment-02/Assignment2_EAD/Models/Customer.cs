using Assignment2_EAD.Views;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Windows;

namespace Assignment2_EAD.Models
{
   public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
        private string UserName;

        public string userName
        {
            get { return UserName; }
            set { UserName = value; OnPropertyChanged("UserName"); }
        }
        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; OnPropertyChanged("Password"); }
        }
        private string PhoneNumber;

        public string phoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }
        public void LogIn(Customer obj)
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            if(!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                connection.Open();
                string query = "Select * from Customers where UserName=@UN and Password=@Pswd";
                SqlParameter p1 = new SqlParameter("UN", obj.userName);
                SqlParameter p2 = new SqlParameter("Pswd", obj.password);
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
                    Cart c = new Cart();
                    c.Show();
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
        public void SignUp(Customer obj)
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(PhoneNumber))
            {
                connection.Open();
                string query = $"insert into Customers(UserName,Password,Phone) values(@PN,@Pr,@Q)";
                SqlParameter p1 = new SqlParameter("PN", obj.UserName);
                SqlParameter p2 = new SqlParameter("Pr", obj.password);
                SqlParameter p3 = new SqlParameter("Q", obj.phoneNumber);

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                int insertedRows = cmd.ExecuteNonQuery();
                if (insertedRows >= 1)
                {
                    MessageBox.Show("You are successfully \"Signed Up\"");
                 
                }
                else
                {
                    MessageBox.Show("SignUp failed, Please enter correct UserID ,Password and Phone");

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
