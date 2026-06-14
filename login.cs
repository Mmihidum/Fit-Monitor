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
    public partial class login : Form
    {
        SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            home hme = new home();
            hme.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text==""
                || txtusername.Text == "")
            {
                  MessageBox.Show("Fill Blanks","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        {
                            string selectdataquery = "SELECT *FROM userdetails where name=@username AND password=@password";

                            using (SqlCommand cmd = new SqlCommand(selectdataquery, conn))
                            {
                                cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                ad.Fill(dt);

                                if(dt.Rows.Count > 0)
                                {
                                    Program.LoggedInUser = txtusername.Text.Trim();
                                    dashbord db = new dashbord();
                                    db.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalied Login Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
