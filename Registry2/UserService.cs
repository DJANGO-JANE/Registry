using Registry2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry2.Services
{
    public class UserService
    {
        public static string rpConn = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;

        public UserService(User user)
        {

        }


        public void AddUser(User user)
        {

            using (SqlConnection Conn = new SqlConnection(rpConn))
            {
                string query = "INSERT INTO UserStash (firstname,lastname,email,gender,dob) values(@firstname,@lastname,@email,@gender,@dateofbirth)";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = (user.Firstname);
                    cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = (user.Lastname);
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = (user.Email);
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = (user.Gender);
                    cmd.Parameters.Add("@dateofbirth", SqlDbType.VarChar).Value = (user.DateOfBirth);

                    try
                    {
                        Conn.Open();
                        var temp = cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }
                }

            }

        }
        public static void GetStudentsByYear(int entry)
        {
            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                SqlCommand cmd = new SqlCommand("select id as 'Student ID', firstname as 'First Name' , LastName as 'Last Name', country as 'Country', yearofentry as 'Year' FROM students where yearofentry=@yearofentry");
                cmd.Parameters.AddWithValue("@yearofentry", entry);
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter listquery = new SqlDataAdapter(cmd);

                DataTable listview = new DataTable();
                listquery.Fill(listview);
                //dataGridView.DataSource = listview;
                //Form2.cs
            }
        }

        public static void PopulateDGV(DataGridView dgv)
        {
            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                SqlCommand cmd = new SqlCommand("Select id as 'User ID', Firstname as 'First Name', Lastname as 'Last Name', gender as 'Gender',Email as 'Email', DOB as 'Date Of Birth' from UserStash", cnn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter al = new SqlDataAdapter(cmd);
                DataTable alist = new DataTable();
                al.Fill(alist);
                dgv.DataSource = alist;

            }
        }
        public void UpdateUser(User user)
        {
            using (SqlConnection Conn = new SqlConnection(rpConn))
            {
                string query = "UPDATE UserStash SET firstname=@firstname,lastname=@lastname,email=@email,gender=@gender,dob=@dateofbirth where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (user.Id);
                    cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = (user.Firstname);
                    cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = (user.Lastname);
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = (user.Email);
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = (user.Gender);
                    cmd.Parameters.Add("@dateofbirth", SqlDbType.VarChar).Value = (user.DateOfBirth);

                    try
                    {
                        Conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }

        public void FindUser(User user, DataGridView dgv)
        {
            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                SqlCommand cmd = new SqlCommand("select id as 'ID', firstname as 'First Name' , LastName as 'Last Name', gender as 'Gender', email as 'Email', dob as 'Date of Birth' FROM UserStash where firstname like @firstname or lastname like @lastname");
                cmd.Parameters.AddWithValue("@firstname", "%" + user.Firstname + "%");
                cmd.Parameters.AddWithValue("@lastname", "%" + user.Lastname + "%");
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter al = new SqlDataAdapter(cmd);
                DataTable alist = new DataTable();
                al.Fill(alist);
                dgv.DataSource = alist;


            }
        }

        public static void QueryByYearOrAge(DataGridView dgv,string type,int value1, int value2)
        {
            string QUERY;

            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                string _from;
                string _to;

                if (type=="dob")
                {
                    var nother = DateTime.Today;
                    DateTime fromAge = nother.AddYears(value1);
                    DateTime toAge = nother.AddYears(value2);
                    fromAge = fromAge.AddYears(-DateTime.Today.Year);
                    toAge = toAge.AddYears(-DateTime.Today.Year);
                    _from = fromAge.Date.ToShortDateString();
                    _to = toAge.Date.ToShortDateString();
                    
                    MessageBox.Show($"From : {fromAge.Date:MM/dd/yyyy} to : {toAge.Date:MM/dd/yyyy}");

                    QUERY = "select id as 'ID', firstname as 'First Name' ," +
                    " LastName as 'Last Name'," +
                    " gender as 'Gender', email as 'Email', dob as 'Date of Birth' " +
                    "FROM UserStash where dob between @dob1 and @dob2";
                }
                else
                {
                    var nother = DateTime.Today;
                    var fromAge = nother.AddYears(-value1).ToShortDateString();
                    var toAge = nother.AddYears(-value2).ToShortDateString();
                    //fromAge = (int)fromAge - DateTime.Today.Year;
                    _from = fromAge;
                    _to = toAge;
                    QUERY = "select id as 'ID', firstname as 'First Name' ," +
                    " LastName as 'Last Name'," +
                    " gender as 'Gender', email as 'Email', dob as 'Date of Birth' " +
                    "FROM UserStash where dob between @dob1 and @dob2";
                }



                SqlCommand cmd = new SqlCommand(QUERY);
                cmd.Parameters.AddWithValue("@dob1", _from);
                cmd.Parameters.AddWithValue("@dob2", _to);
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter al = new SqlDataAdapter(cmd);
                DataTable alist = new DataTable();
                al.Fill(alist);
                dgv.DataSource = alist;


            }
        }
        public static void AgesOfEntries(ComboBox cmbYearA, ComboBox cmbYearB, ComboBox cmbAge0, ComboBox cmbAge1)
        {
            cmbYearA.Items.Clear();
            cmbYearB.Items.Clear();
            cmbAge0.Items.Clear();
            cmbAge1.Items.Clear();

            int[] ages;
            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                SqlCommand cmd = new SqlCommand("Select distinct dob from UserStash", cnn);
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;

                cnn.Open();
                SqlDataReader li = cmd.ExecuteReader();

                    while (li.Read())
                    {
                        //MessageBox.Show($"{li.GetString(li.GetOrdinal("dob"))}");
                        DateTime year = li.GetDateTime(li.GetOrdinal("dob"));

                        cmbYearA.Items.Add(year.Year);
                        cmbYearB.Items.Add(year.Year);

                        DateTime date1 = li.GetDateTime(li.GetOrdinal("dob"));

                        cmbAge0.Items.Add((DateTime.Today.Year - date1.Year));
                        cmbAge0.Sorted = true;
                        cmbAge1.Items.Add((DateTime.Today.Year - date1.Year));

                        //cmbYearB.Items.Add(li.GetDateTime(li.GetOrdinal("dob")));
                    }



            }
        }
        public User FindByID(int id)
        {
            User user = new User();
   
            using (SqlConnection cnn = new SqlConnection(rpConn))
            {
                SqlCommand cmd = new SqlCommand("select * FROM UserStash where Id=@Id");
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;

                try
                {
                    cnn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            user.Firstname = dr.GetString(dr.GetOrdinal("Firstname"));
                            user.Lastname = dr.GetString(dr.GetOrdinal("Lastname"));
                            user.DateOfBirth = dr.GetDateTime(dr.GetOrdinal("DOB"));
                            user.Email = dr.GetString(dr.GetOrdinal("Email"));
                            user.Gender = dr.GetString(dr.GetOrdinal("Gender"));
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }


            }
            return user;
        }
        public void DeleteUser(User user)
        {
            using (SqlConnection Conn = new SqlConnection(rpConn))
            {
                string query = "DELETE FROM UserStash where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (user.Id);
  

                    try
                    {
                        Conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }
    }
}
