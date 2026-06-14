using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class dashbord : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public dashbord()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            showname.Text = "Hi! " + Program.LoggedInUser;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();    
            bmi.Show();
            this.Hide();
        }

        private void burefresh_Click(object sender, EventArgs e)
        {
            connect.Open();
            string query1 = "SELECT name From userdetails";
            using (SqlCommand cmd1 = new SqlCommand(query1, connect))
            {
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string name = Convert.ToString(reader["name"]);

                    showname.Text = "Hi! " + name;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sugarlevel sug = new sugarlevel();
            sug.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bloodpurser blood = new bloodpurser();
            blood.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cholesterol_levels cholesterol = new cholesterol_levels();
            cholesterol.Show();
            this.Hide();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            hpvsymptoms hpv = new hpvsymptoms();
            hpv.Show();
            this.Hide();    
        }
    }
}
