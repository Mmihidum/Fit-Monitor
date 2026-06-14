using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class sugarlevel : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public sugarlevel()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void butrefresh_Click(object sender, EventArgs e)
        {
            double sugerlevel = Convert.ToDouble(txtsugar.Text);

            if(sugerlevel<115)
            {
                lblshowlevel.Text = $"Low Sugar Level!";
            }
            else if(sugerlevel>=115 && sugerlevel <= 160)
            {
                lblshowlevel.Text = $"Sugar Level is Good!";
            }
            else 
            {
                lblshowlevel.Text = $"High Sugar Level!";
            }

            connect.Open();
            string query1 = "SELECT name From userdetails";
            using (SqlCommand cmd1 = new SqlCommand(query1, connect))
            {
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string name = Convert.ToString(reader["name"]);

                    lblshow.Text = name;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dashbord dash = new dashbord();
            dash.Show();
            this.Hide();
        }
    }
}
