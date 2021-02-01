using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace bcsf17a554.Models
{
    public class methods
    {
        public string constring;//connectionstring
        public methods()
        {
            constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        //check the login user is admin or not
        public bool asadmin(User user)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "select* from User where name='"+user.name+"' and password='"+user.password+"' and admin='"+true+"')";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader r = cmnd.ExecuteReader();
            int temp1 = 0;
            while (r.Read())
            {
                temp1 = temp1 + 1;
            }
            if (temp1 >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }

        //check the login user is user or not
        public bool asuser(User user)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "select* from User where name='" + user.name + "' and password='" + user.password + "' and admin='" + false + "')";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader r = cmnd.ExecuteReader();
            int temp1 = 0;
            while (r.Read())
            {
                temp1 = temp1 + 1;
            }
            if (temp1 >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //add new user in database
        public bool adduser(User user)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "insert into User (name,mail,password,image,admin) values ('"+user.name+"','"+user.mail+"','"+user.password+"','"+user.image+"','"+user.admin+"'))";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmnd.ExecuteNonQuery();
            if (i >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //update changes in user
        public bool updateprofile(User user)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "update User set name='"+user.name+"' , mail='"+user.mail+"' , password='"+user.password+"' , image='"+user.image+"' where id='"+user.id+"'";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmnd.ExecuteNonQuery();
            if (i >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //updtae changes in post
        public bool updatepost(Post post)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "update Post set title='" + post.title + "' , content='" + post.content + "' where id='" + post.id + "'";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmnd.ExecuteNonQuery();
            if (i >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //add post in database
        public bool createpost(Post post)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "insert into Post (title,content) values ('" + post.title + "','" +post.content + "'))";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmnd.ExecuteNonQuery();
            if (i >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //delete post from database
        public bool deletepost(Post post)
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "delete Post where id='"+post.id+"'";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmnd.ExecuteNonQuery();
            if (i >= 1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        //list of all posts
        public List<Post> listofpost()
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "select* from User";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader r = cmnd.ExecuteReader();
            List<Post> temp = new List<Post>();
            while (r.Read())
            {
                Post post = new Post();
                post.id=System.Convert.ToInt32(r["id"]);
                post.title=r["title"].ToString();
                post.content = r["content"].ToString();
                temp.Add(post);
            }
            return temp;
        }
        //list of all user
        public List<User> listofusers()
        {
            SqlConnection conn = new SqlConnection(constring);
            string query = "select* from User";
            SqlCommand cmnd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader r = cmnd.ExecuteReader();
            List<User> temp = new List<User>();
            while (r.Read())
            {
                User user = new User();
                user.id = System.Convert.ToInt32(r["id"]);
                user.name = r["name"].ToString();
                user.mail = r["mail"].ToString();
                user.image = r["image"].ToString();
                temp.Add(user);
            }
            return temp;
        }
    }
}
