using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class bloodpurser : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public bloodpurser()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void bloodpurser_Load(object sender, EventArgs e)
        {

        }

        private void butrefresh_Click(object sender, EventArgs e)
        {
            double bloodpressure = Convert.ToDouble(txtsugar.Text);

            if (bloodpressure < 90)
            {
                lblshowlevel.Text = $"Low Bloodpressure Level!";
            }
            else if (bloodpressure >= 90 && bloodpressure <= 120)
            {
                lblshowlevel.Text = $"Bloodpressure Level is Normal!";
            }
            else if (bloodpressure >= 120 && bloodpressure <= 140)
            {
                lblshowlevel.Text = $"Bloodpressure Level is Prehypretension!";
            }
            else if (bloodpressure >= 140 && bloodpressure <= 160)
            {
                lblshowlevel.Text = $"Bloodpressure Level is High Prehypretension(stage1)!";
            }
            else
            {
                lblshowlevel.Text = $"Bloodpressure Level is Prehypretension(stage2) !";
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
