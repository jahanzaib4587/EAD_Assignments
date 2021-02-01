using Assignment2_EAD.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Assignment2_EAD.Models
{
    class Products : BasicViewModel
    {
        ObservableCollection<Products> AllProductList;
        ObservableCollection<Products> SeletctedProductItems;


        private int ProductID;

        public int productID
        {
            get { return ProductID; }
            set { ProductID = value; onPropertyChange("ProductID"); }
        }
        private string ProductName;

        public string productName
        {
            get { return ProductName; }
            set { ProductName = value; onPropertyChange("ProductName"); }
        }
        private int Price;

        public int price
        {
            get { return Price; }
            set { Price = value; onPropertyChange("Price"); }
        }
        private int Quantity;

        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; onPropertyChange("Quantity"); }
        }
        public Products()
        {
            AllProductList = new ObservableCollection<Products>();
            SeletctedProductItems = new ObservableCollection<Products>();
            productID = 0;
            ProductName = "";
            Price = 0;
            Quantity = 0;
        }
        public ObservableCollection<Products> DisplayProducts()
        {
            Products p = new Products();
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString) ;
            connection.Open();
            string query = "Select * from Products";
            SqlCommand cmd = new SqlCommand(query);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                p.ProductID = dr.GetInt32(0);
                p.ProductName = dr.GetString(1);
                p.price= dr.GetInt32(2);
                p.quantity = dr.GetInt32(3);
                AllProductList.Add(p);
            }
            connection.Close();
            return AllProductList;
        }
        public void addProduct()
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            if (string.IsNullOrEmpty(productName) && price != 0 && quantity!=0 )
            {
                connection.Open();
                string query = $"insert into Products(ProductName,Price,Quantity) values(@PN,@Pr,@Q)";
                SqlParameter p1 = new SqlParameter("PN", productName);
                SqlParameter p2 = new SqlParameter("Pr", price);
                SqlParameter p3 = new SqlParameter("Q", quantity);

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                int insertedRows = cmd.ExecuteNonQuery();
                if(insertedRows>=1)
                {
                    MessageBox.Show("Values Added");
                }
                else
                {
                    MessageBox.Show("Not Succefull");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields with appropriate values");
            }
            connection.Close();
        }
        public void UpdateData()
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            string query = $"Update Products set ProductName=@PN,Price=@Pr,Quantity=@Q where Id=@ID'";
            SqlParameter p1 = new SqlParameter("PN", productName);
            SqlParameter p2 = new SqlParameter("Pr", price);
            SqlParameter p3 = new SqlParameter("Q", quantity);
            SqlParameter p4 = new SqlParameter("ID", productID);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            int insertedRows = cmd.ExecuteNonQuery();
            if (insertedRows >= 1)
            {
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Unsecessfull!");
            }
            connection.Close();
            
        }
        public void DeleteProduct()
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            string query = $"Delete from Products where Id=@ID";
            SqlParameter p1 = new SqlParameter("ID", productID);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);

            int insertedRows = cmd.ExecuteNonQuery();
            if (insertedRows >= 1)
            {
                MessageBox.Show("Product Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Unsecessfull!");
            }
            connection.Close();
           

        }

    }
}
