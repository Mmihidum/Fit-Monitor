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

namespace fitness
{
    public partial class BMI : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public BMI()
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
            connect.Open();
            string query = "SELECT height, waight FROM userdetails ";

            using(SqlCommand cmd = new SqlCommand(query,connect))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    double height = Convert.ToDouble(reader["height"]);
                    double waight = Convert.ToDouble(reader["waight"]);

                    double heightmiter = height / 100;
                    double bmi = waight / (heightmiter * heightmiter);

                    showbmi.Text = $"{bmi}";
                   
                }
                reader.Close();
            }
            
            string query1 = "SELECT name From userdetails";
            using(SqlCommand cmd1 = new SqlCommand(query1, connect))
            {
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string name = Convert.ToString(reader["name"]);

                    showname.Text= name;
                }
            }
        }
    }
}
