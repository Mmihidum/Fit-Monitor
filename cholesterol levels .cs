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
using System.Data.SqlClient;
namespace fitness
{
    public partial class cholesterol_levels : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public cholesterol_levels()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dashbord dash = new dashbord();
            dash.Show();
            this.Hide();
        }

        private void butrefresh_Click(object sender, EventArgs e)
        {
            double cholestrollevel = Convert.ToDouble(txtcholestrol.Text);

            if (cholestrollevel < 100)
            {
                lblshowcho.Text = $"Optimum Cholestrol Level!";
            }
            else if (cholestrollevel >= 100 && cholestrollevel <= 139)
            {
                lblshowcho.Text = $"Near Optimum Cholestroll Level!";
            }
            else if (cholestrollevel >= 139 && cholestrollevel <= 160)
            {
                lblshowcho.Text = $"Boderline high Cholestrol Level!";
            }
            else if (cholestrollevel >= 160 && cholestrollevel <= 189)
            {
                lblshowcho.Text = $"High Cholestrol Level!";
            }
            else
            {
                lblshowcho.Text = $"Very High Cholestrol Level!";
            }

            connect.Open();
            string query2 = "SELECT name From userdetails";
            using (SqlCommand cmd2 = new SqlCommand(query2, connect))
            {
                SqlDataReader reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    string name = Convert.ToString(reader["name"]);

                    show.Text = name;
                }
            }
        }

        private void cholesterol_levels_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
