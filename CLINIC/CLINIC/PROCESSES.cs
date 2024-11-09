using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CLINIC
{
    internal class PROCESSES
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MSA24LI\SQLEXPRESS;Initial Catalog=CLINIC_DB;Integrated Security=True;");
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public SqlConnection getConnection()
        {
            return conn;
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
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
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public bool Signup_AddToDatabase(string fname, string lname, string mname, string position, string email, string pass, string pin) {
            try
            {
                conn.Open();
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
                int userid = -1;
                Login login = new Login(userid);
                login.Show();
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
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public int login_CheckAccount(string useremail, string user_password) {
            int id = -1;
            try
            {

                String querry = "SELECT * FROM UserInfo WHERE email = '" + useremail + "' AND pass = '" + user_password + "';";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                id = Convert.ToInt32(dtable.Rows[0]["userid"]);
                if (dtable.Rows.Count > 0)
                {
                    return id;
                }
                else
                {
                    return id;
                }
            }
            catch
            {
                MessageBox.Show("Error");
                return id;
            }
            finally { conn.Close(); }
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public string getPosition(string useremail, string user_password) {
            string role = "";
            try
            {

                String querry = "SELECT * FROM UserInfo WHERE email = '" + useremail + "' AND pass = '" + user_password + "';";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                role = dtable.Rows[0]["position"].ToString();
                if (dtable.Rows.Count > 0)
                {
                    return role;
                }
                else
                {
                    return role;
                }
            }
            catch
            {
                MessageBox.Show("Error");
                return role;
            }
            finally { conn.Close(); }
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public bool ForgotPassword_CheckAccount(string email, string pin) {
            try
            {
                String querryemail = "SELECT email FROM UserInfo WHERE email = '" + email + "';";

                SqlDataAdapter sdaemail = new SqlDataAdapter(querryemail, conn);


                DataTable dtableemail = new DataTable();

                sdaemail.Fill(dtableemail);

                string dbPin = dtableemail.Rows[0]["pin"].ToString();

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
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public bool ForgotPassword_SetPassword(string email, int pin, string pass)
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
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public void AddRecord_AddToDatabase(string petname, DateTime petbday, string breed, string petgender, string owner, string contactnum, string email, string mednote, string status, int userid)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Appointments (pname, breed, birthday, gender, oname, contactNo, email, mednote, appointmentDate, appointmentTime, status,userID) " +
                   "VALUES (@petname, @breed, @petbday, @petgender, @owner, @contactnum, @email, @mednote, GETDATE(), CONVERT(TIME, GETDATE()), @status,@userID)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@petname", petname);
                    command.Parameters.AddWithValue("@breed", breed);
                    command.Parameters.AddWithValue("@petbday", petbday);
                    command.Parameters.AddWithValue("@petgender", petgender);
                    command.Parameters.AddWithValue("@owner", owner);
                    command.Parameters.AddWithValue("@contactnum", contactnum);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@mednote", mednote);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@userID", userid);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Record Added successfully!");
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
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public int AddRecord_CheckDatabase(string petname, string owner, string email)
        {

            DateTime datechecker = DateTime.Now.Date;
            try
            {
                string queryEmail = "SELECT * FROM Appointments WHERE email = @email AND pname = @pname AND oname = @oname AND appointmentDate = @DATETODAY";
                DataTable dtableEmail = new DataTable();
                conn.Open();
                using (SqlCommand command = new SqlCommand(queryEmail, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pname", petname);
                    command.Parameters.AddWithValue("@oname", owner);
                    command.Parameters.AddWithValue("@DATETODAY", datechecker);
                    using (SqlDataAdapter sdaEmail = new SqlDataAdapter(command))
                    {
                        sdaEmail.Fill(dtableEmail);
                    }
                }

                if (dtableEmail.Rows.Count > 0)
                {
                    return dtableEmail.Rows.Count;
                }
                else
                {
                    return dtableEmail.Rows.Count;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return -1;
            }
            finally { conn.Close(); }
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public int getUserID(string name) {
            try
            {
                string query = "SELECT userID FROM UserInfo WHERE (fname + ' ' + mname + ' ' + lname) = @fullName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fullName", name.Trim());

                    SqlDataAdapter sdaemail = new SqlDataAdapter(cmd);
                    DataTable dtableemail = new DataTable();
                    sdaemail.Fill(dtableemail);

                    if (dtableemail.Rows.Count > 0)
                    {
                        int userid = Convert.ToInt32(dtableemail.Rows[0]["userID"]);
                        return userid;
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Veterinarian!!");
                        return -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public bool getNameSpace(string fname, string lname, string mname, string position, string email, string pass, string pin)
        {

            int fnamespace, mnamespace, lnamespace;


            fnamespace = fname.IndexOf(' ');

            if (fnamespace == -1)
            {
                fname = char.ToUpper(fname[0]) + fname.Substring(1).ToLower();
            }
            else
            {
                fname = char.ToUpper(fname[0]) + fname.Substring(1, fnamespace).ToLower() + char.ToUpper(fname[fnamespace + 1]) + fname.Substring(fnamespace + 2).ToLower();
            }
            ///
            ///
            mnamespace = mname.IndexOf(' ');

            if (mnamespace == -1)
            {
                mname = char.ToUpper(mname[0]) + mname.Substring(1).ToLower();
            }
            else
            {
                mname = char.ToUpper(mname[0]) + mname.Substring(1, mnamespace).ToLower() + char.ToUpper(mname[mnamespace + 1]) + mname.Substring(mnamespace + 2).ToLower();

            }
            ///
            ///
            lnamespace = lname.IndexOf(' ');

            if (lnamespace == -1)
            { lname = char.ToUpper(lname[0]) + lname.Substring(1).ToLower(); }
            else
            {
                lname = char.ToUpper(lname[0]) + lname.Substring(1, lnamespace).ToLower() + char.ToUpper(lname[lnamespace + 1]) + lname.Substring(lnamespace + 2).ToLower();
            }
            ///
            ///
            if (email != "")
            {
                email = char.ToUpper(email[0]) + email.Substring(1).ToLower();
            }
            bool processofsignup = Signup_AddToDatabase(fname, lname, mname, position, email, pass, pin);
            return processofsignup;
        }
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        ///////////////
        public string getUserEmail(int userid) {
            try
            {
                String querryemail = "SELECT * FROM UserInfo WHERE userid = '" + userid + "';";
                SqlDataAdapter sdaemail = new SqlDataAdapter(querryemail, conn);
                DataTable dtableemail = new DataTable();

                sdaemail.Fill(dtableemail);

                string fullname = dtableemail.Rows[0]["fname"].ToString() + " " + dtableemail.Rows[0]["mname"].ToString() + " " + dtableemail.Rows[0]["lname"].ToString();

                if (dtableemail.Rows.Count > 0)
                {
                    return fullname;
                }
                else { return ""; }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return "";
            }
            finally { conn.Close(); }
        }

        

        public bool validatePassword(int userid,string password) {
            try
            {
                String querryemail = "SELECT * FROM UserInfo WHERE userid = '" + userid + "';";
                SqlDataAdapter sdaemail = new SqlDataAdapter(querryemail, conn);
                DataTable dtableemail = new DataTable();

                sdaemail.Fill(dtableemail);

                string verifypassword = dtableemail.Rows[0]["pass"].ToString();

                if (dtableemail.Rows.Count > 0)
                {
                    if (verifypassword == password) {
                        MessageBox.Show("Verification Successful!!");
                        return true;
                    }
                }
                return false; 

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false; ;
            }
            finally { conn.Close(); }
        }
    }
}
