using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CLINIC
{
    internal class PROCESSES
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MSA24LI\SQLEXPRESS;Initial Catalog=CLINIC_DB;Integrated Security=True;");
        /////   
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public SqlConnection getConnection()
        {   
            return conn;
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public int Signup_AccChecker(string email) 
        {
            String querry;
            SqlDataAdapter sda;
            DataTable dtable;
            try
            {
                 querry = "SELECT * FROM UserInfo WHERE email = '" + email + "';";
                 sda = new SqlDataAdapter(querry, conn);

                 dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                  return dtable.Rows.Count;
                }
                return 0;
            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public void Signup_AddToDatabase(string fname, string lname, string mname, string position, string email, string pass, string conpass, string pin) {
            try
            {
                string query = "INSERT INTO UserInfo (fname, mname, lname, email, position, pass,pin,datecreated) VALUES (@fname, @mname, @lname, @Email, @position, @Pass,@Pin,GETDATE())";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@mname", mname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@Pass", pass);
                    command.Parameters.AddWithValue("@Pin", pin);


                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!");
                string Username = "";
                Login login = new Login(Username);
                login.Show();

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public bool login_CheckAccount(string username, string user_password) {
            string Username;
            try
            {
                String querry = "SELECT * FROM UserInfo WHERE email = '" + username + "' AND pass = '" + user_password + "';";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    return true;
                    //GO TO NEXT PAGE
                }
                else
                {
                    return false;
                }
            }
            catch
            {   
                MessageBox.Show("Error");
                return false;
            }
            finally { conn.Close(); }
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public bool ForgotPassword_CheckAccount(string email, string pin) {
            try
            {
                String querryemail = "SELECT email FROM UserInfo WHERE email = '" + email + "';";
                String querrypin = "SELECT pin FROM UserInfo WHERE email = '" + email + "';";
                SqlDataAdapter sdaemail = new SqlDataAdapter(querryemail, conn);
                SqlDataAdapter sdapin = new SqlDataAdapter(querrypin, conn);

                DataTable dtableemail = new DataTable();
                DataTable dtablepin = new DataTable();
                sdaemail.Fill(dtableemail);
                sdapin.Fill(dtablepin);
                string dbPin = dtablepin.Rows[0]["pin"].ToString();

                if (dtableemail.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong Email!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (dtableemail.Rows.Count > 0 && dbPin != pin)
                {
                    MessageBox.Show("Wrong Pin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            finally { conn.Close(); }
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public bool ForgotPassword_SetPassword(string email, int pin,string pass)
        {
            try
            {
                conn.Open();
                string query = "Update UserInfo set pass = @password WHERE email = @email AND pin = @pin";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@password", pass);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pin", pin);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Password change successful!");
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }
            
        }
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        /////
        public void Homepage_Calendar() 
        { 
        
        
        }
    }
}
