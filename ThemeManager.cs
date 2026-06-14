using System;
using System.Drawing;
using System.Windows.Forms;

namespace fitness
{
    public static class ThemeManager
    {
        // Dark theme palette
        private static readonly Color FormBackColor = Color.FromArgb(30, 30, 36);
        private static readonly Color TextColor = Color.WhiteSmoke;
        private static readonly Color InputBackColor = Color.FromArgb(43, 43, 50);

        public static void ApplyTheme(Form form)
        {
            // Optional: You can uncomment below if you want borderless forms
            // form.FormBorderStyle = FormBorderStyle.None; 
            
            try
            {
                string bgFileName = (form.Name.ToLower() == "home" || form.Name.ToLower() == "login" || form.Name.ToLower() == "userdetails") ? "fitness_bg.png" : "fitness_bg2.png";
                string bgPath = System.IO.Path.Combine(Application.StartupPath, bgFileName);
                if (System.IO.File.Exists(bgPath))
                {
                    using (var bmp = new Bitmap(bgPath))
                    {
                        form.BackgroundImage = new Bitmap(bmp);
                    }
                    form.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    form.BackColor = FormBackColor;
                    form.BackgroundImage = null;
                }
            }
            catch { form.BackColor = FormBackColor; form.BackgroundImage = null; }

            bool isMainForm = (form.Name.ToLower() == "home" || form.Name.ToLower() == "login" || form.Name.ToLower() == "userdetails");
            Color currentButtonColor = isMainForm ? Color.FromArgb(178, 34, 34) : Color.FromArgb(0, 150, 136); // Red for main, Teal for dashboard
            Color currentButtonHoverColor = isMainForm ? Color.FromArgb(205, 92, 92) : Color.FromArgb(38, 166, 154);

            form.ForeColor = TextColor;
            
            form.FormClosed += (s, e) => { Application.Exit(); };
            
            ApplyThemeToControls(form.Controls, currentButtonColor, currentButtonHoverColor);

            if (!isMainForm)
            {
                Control[] found = form.Controls.Find("showname", true);
                if (found.Length == 0)
                {
                    Label shownameLbl = new Label();
                    shownameLbl.Name = "showname";
                    shownameLbl.Text = "Hi! " + Program.LoggedInUser;
                    shownameLbl.BackColor = Color.Transparent;
                    shownameLbl.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
                    shownameLbl.ForeColor = Color.White;
                    shownameLbl.AutoSize = true;
                    shownameLbl.Location = new Point(20, 20);
                    form.Controls.Add(shownameLbl);
                    shownameLbl.BringToFront();
                }
            }
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls, Color btnColor, Color btnHoverColor)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = btnColor;
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);

                    // Add hover effects for buttons
                    btn.MouseEnter += (s, e) => { btn.BackColor = btnHoverColor; };
                    btn.MouseLeave += (s, e) => { btn.BackColor = btnColor; };
                }
                else if (control is CheckBox chk)
                {
                    chk.Cursor = Cursors.Hand;
                    chk.ForeColor = TextColor;
                    chk.BackColor = Color.FromArgb(150, 0, 0, 0); // Glassmorphism
                    chk.Font = new Font("Century Gothic", 12F, FontStyle.Regular);
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = InputBackColor;
                    txt.ForeColor = TextColor;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Cursor = Cursors.Hand;
                    txt.Font = new Font("Century Gothic", 12F, FontStyle.Regular);
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = TextColor;
                    lbl.BackColor = Color.FromArgb(150, 0, 0, 0); // Default to glassmorphism
                    lbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular);

                    string text = lbl.Text.ToLower();
                    if (text.Contains("fit monitor"))
                    {
                        lbl.BackColor = Color.Transparent;
                        lbl.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
                        lbl.ForeColor = btnColor;
                        lbl.AutoSize = false;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        if (lbl.Parent != null)
                        {
                            lbl.Width = lbl.Parent.ClientSize.Width;
                            lbl.Left = 0;
                        }
                    }
                    else if (text.Contains("back"))
                    {
                        lbl.BackColor = Color.Transparent;
                        lbl.Cursor = Cursors.Hand;
                        lbl.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
                        lbl.ForeColor = btnHoverColor;
                        lbl.MouseEnter += (s, e) => { lbl.ForeColor = btnColor; };
                        lbl.MouseLeave += (s, e) => { lbl.ForeColor = btnHoverColor; };
                    }
                    else if (lbl.Name == "showname")
                    {
                        lbl.BackColor = Color.Transparent;
                        lbl.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
                        lbl.ForeColor = Color.White;
                        // Assuming it's on a panel or form, move to top left
                        lbl.Location = new Point(20, 20);
                    }
                }
                else if (control is PictureBox pic)
                {
                    try
                    {
                        string logoPath = System.IO.Path.Combine(Application.StartupPath, "simple_logo.png");
                        if (System.IO.File.Exists(logoPath))
                        {
                            using (var bmp = new Bitmap(logoPath))
                            {
                                pic.BackgroundImage = new Bitmap(bmp);
                            }
                            pic.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                    catch { }
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = InputBackColor;
                    cmb.ForeColor = TextColor;
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.Cursor = Cursors.Hand;
                    cmb.Font = new Font("Century Gothic", 12F, FontStyle.Regular);
                }
                else if (control is Panel pnl)
                {
                    pnl.BackColor = Color.Transparent;
                }

                // Recursively apply theme to child controls (e.g. inside Panels or GroupBoxes)
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls, btnColor, btnHoverColor);
                }
            }
        }
    }
}
