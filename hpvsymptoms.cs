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
    public partial class hpvsymptoms : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public hpvsymptoms()
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
            double hpv = Convert.ToDouble(txthpv.Text);

            if (hpv==6 
                ||hpv==11
                ||hpv==42
                ||hpv==43
                ||hpv==44)
            {
                lblshowhpv.Text = $"Genital Warts Or Begin Lesions,Not Cervical Canser!";
            }
            else if (hpv==16
                ||hpv==18
                ||hpv==31
                ||hpv==33
                || hpv == 35
                || hpv == 39
                || hpv == 45
                || hpv == 51
                || hpv == 51
                || hpv == 52
                || hpv == 56
                || hpv == 58
                || hpv == 59
                || hpv == 68)
            {
                lblshowhpv.Text = $"Cervical Canser!";
            }
            connect.Open();
            string query3 = "SELECT name From userdetails";
            using (SqlCommand cmd3 = new SqlCommand(query3, connect))
            {
                SqlDataReader reader = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    string name = Convert.ToString(reader["name"]);

                    showla.Text = name;
                }
            }
        }
    }
}
