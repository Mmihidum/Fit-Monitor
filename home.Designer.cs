namespace fitness
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butlogin = new System.Windows.Forms.Button();
            this.butregister = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butlogin
            // 
            this.butlogin.BackColor = System.Drawing.Color.DimGray;
            this.butlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butlogin.Location = new System.Drawing.Point(373, 295);
            this.butlogin.Margin = new System.Windows.Forms.Padding(4);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(307, 50);
            this.butlogin.TabIndex = 1;
            this.butlogin.Text = "Create Account";
            this.butlogin.UseVisualStyleBackColor = false;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butregister
            // 
            this.butregister.BackColor = System.Drawing.Color.DimGray;
            this.butregister.Location = new System.Drawing.Point(373, 353);
            this.butregister.Margin = new System.Windows.Forms.Padding(4);
            this.butregister.Name = "butregister";
            this.butregister.Size = new System.Drawing.Size(307, 71);
            this.butregister.TabIndex = 2;
            this.butregister.Text = "Dashboard";
            this.butregister.UseVisualStyleBackColor = false;
            this.butregister.Click += new System.EventHandler(this.butregister_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(293, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(477, 104);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fit Monitor";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::fitness.Properties.Resources.wp79895491;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butregister);
            this.Controls.Add(this.butlogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butregister;
        private System.Windows.Forms.Label label8;
    }
}

