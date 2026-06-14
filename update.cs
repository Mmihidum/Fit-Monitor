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
using System.Data.SqlClient;

namespace fitness
{
   
    public partial class update : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\fitness\fitness\fitness.mdf;Integrated Security=True");
        public update()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void back_Click(object sender, EventArgs e)
        {
            dashbord dash = new dashbord();
            dash.Show();
            this.Hide();
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string que = "UPDATE userdetails SET  age=@age , waight=@waight, height=@height , bloodgruop=@bloodgruop, password=@password WHERE name=@name";
                using (SqlCommand cmd = new SqlCommand(que, conn))
                {
                    cmd.Parameters.AddWithValue("@age", txtage.Text);
                    cmd.Parameters.AddWithValue("@waight", txtwaight.Text);
                    cmd.Parameters.AddWithValue("@height", txtheight.Text);
                    cmd.Parameters.AddWithValue("@bloodgruop", txtblood.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);

                    conn.Open();
                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records updated for the specified name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void update_Load(object sender, EventArgs e)
        {

        }
    }
}
