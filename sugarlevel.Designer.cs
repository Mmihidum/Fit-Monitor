namespace fitness
{
    partial class sugarlevel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblshow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showbmi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butrefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblshowlevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblshow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.showname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 112);
            this.panel1.TabIndex = 10;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblshow.Location = new System.Drawing.Point(103, 32);
            this.lblshow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(0, 39);
            this.lblshow.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::fitness.Properties.Resources.user_icon_png_22;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(956, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 94);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // showname
            // 
            this.showname.AutoSize = true;
            this.showname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showname.Location = new System.Drawing.Point(103, 32);
            this.showname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showname.Name = "showname";
            this.showname.Size = new System.Drawing.Size(0, 39);
            this.showname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi,";
            // 
            // showbmi
            // 
            this.showbmi.AutoSize = true;
            this.showbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbmi.Location = new System.Drawing.Point(308, 276);
            this.showbmi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showbmi.Name = "showbmi";
            this.showbmi.Size = new System.Drawing.Size(0, 39);
            this.showbmi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "You\'r Sugar Level Is";
            // 
            // butrefresh
            // 
            this.butrefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butrefresh.Location = new System.Drawing.Point(944, 513);
            this.butrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.butrefresh.Name = "butrefresh";
            this.butrefresh.Size = new System.Drawing.Size(133, 44);
            this.butrefresh.TabIndex = 11;
            this.butrefresh.Text = "Refresh";
            this.butrefresh.UseVisualStyleBackColor = false;
            this.butrefresh.Click += new System.EventHandler(this.butrefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "BacktoDashboard";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsugar
            // 
            this.txtsugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsugar.Location = new System.Drawing.Point(39, 219);
            this.txtsugar.Margin = new System.Windows.Forms.Padding(4);
            this.txtsugar.Name = "txtsugar";
            this.txtsugar.Size = new System.Drawing.Size(132, 30);
            this.txtsugar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Insert Sugar Level:";
            // 
            // lblshowlevel
            // 
            this.lblshowlevel.AutoSize = true;
            this.lblshowlevel.BackColor = System.Drawing.Color.Transparent;
            this.lblshowlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowlevel.Location = new System.Drawing.Point(308, 370);
            this.lblshowlevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshowlevel.Name = "lblshowlevel";
            this.lblshowlevel.Size = new System.Drawing.Size(0, 39);
            this.lblshowlevel.TabIndex = 17;
            // 
            // sugarlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fitness.Properties.Resources._1551242624965;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.lblshowlevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsugar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showbmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butrefresh);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sugarlevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sugarlevel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label showname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showbmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butrefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblshowlevel;
        private System.Windows.Forms.Label lblshow;
    }
}