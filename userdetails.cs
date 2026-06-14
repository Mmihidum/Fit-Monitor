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
    public partial class userdetails : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public userdetails()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            home hme = new home();
            hme.Show();
            this.Hide();
        }

        private void userdetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == ""
                || txtpassword.Text == ""
                || txtage.Text == "")
            {
                MessageBox.Show("Fill Blanks!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        {
                            string insertdataquery = "INSERT INTO userdetails Values(@name,@age,@waight,@height,@bloodgruop ,@password)";
                            using (SqlCommand cmd = new SqlCommand(insertdataquery, connect))
                            {
                                cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                                cmd.Parameters.AddWithValue("@age", txtage.Text.Trim());
                                cmd.Parameters.AddWithValue("@waight", txtwaight.Text.Trim());
                                cmd.Parameters.AddWithValue("@height", txtheight.Text.Trim());
                                cmd.Parameters.AddWithValue("@bloodgruop", txtblood.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Successfuly", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Username already exists. Please choose a different name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
