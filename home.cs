using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            // Make sure 'Login' exactly matches your class name
            login log = new login();

            log.FormClosed += (s, args) => Application.Exit();

            log.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void butregister_Click(object sender, EventArgs e)
        {
            userdetails reg = new userdetails();  
            reg.Show();
            this.Hide();
        }


       
    }
}
