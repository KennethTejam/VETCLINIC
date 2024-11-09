using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Appointment1
{
    internal class PROCESSES
    {
        SqlConnection conn = new SqlConnection ("Data Source=LAPTOP-C2670BG2\\SQLEXPRESS;Initial Catalog=CLINIC_DB;Integrated Security=True;");

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
