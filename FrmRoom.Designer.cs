namespace CleanCode
{
    partial class FrmRoom
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.pnl_centre = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_1_on = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.pnl_centre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.label.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_top.Controls.Add(this.help);
            this.pnl_top.Controls.Add(this.btn_setting);
            this.pnl_top.Controls.Add(this.dashboard);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 100);
            this.pnl_top.TabIndex = 0;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.help.Location = new System.Drawing.Point(585, 12);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(167, 64);
            this.help.TabIndex = 2;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_setting.Location = new System.Drawing.Point(297, 12);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(187, 62);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dashboard.Location = new System.Drawing.Point(59, 12);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(150, 61);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_centre
            // 
            this.pnl_centre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_centre.Controls.Add(this.label19);
            this.pnl_centre.Controls.Add(this.label18);
            this.pnl_centre.Controls.Add(this.label17);
            this.pnl_centre.Controls.Add(this.label16);
            this.pnl_centre.Controls.Add(this.panel2);
            this.pnl_centre.Controls.Add(this.panel1);
            this.pnl_centre.Controls.Add(this.label);
            this.pnl_centre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centre.Location = new System.Drawing.Point(0, 100);
            this.pnl_centre.Name = "pnl_centre";
            this.pnl_centre.Size = new System.Drawing.Size(800, 350);
            this.pnl_centre.TabIndex = 1;
            this.pnl_centre.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(651, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Green light";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Yellow light";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Red light";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "label16";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(565, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 135);
            this.panel2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(152, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "OFF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "ON";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Button";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(297, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 135);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "ON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Button";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Controls.Add(this.label2);
            this.label.Controls.Add(this.lbl_1_on);
            this.label.Controls.Add(this.label1);
            this.label.Location = new System.Drawing.Point(31, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(200, 135);
            this.label.TabIndex = 0;
            this.label.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "OFF";
            // 
            // lbl_1_on
            // 
            this.lbl_1_on.AutoSize = true;
            this.lbl_1_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_1_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1_on.Location = new System.Drawing.Point(114, 28);
            this.lbl_1_on.Name = "lbl_1_on";
            this.lbl_1_on.Size = new System.Drawing.Size(32, 20);
            this.lbl_1_on.TabIndex = 2;
            this.lbl_1_on.Text = "ON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Button";
            this.label1.Click += new System.EventHandler(this.label9_Click);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_centre);
            this.Controls.Add(this.pnl_top);
            this.Name = "FrmRoom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_centre.ResumeLayout(false);
            this.pnl_centre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_centre;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel label;
        private System.Windows.Forms.Label lbl_1_on;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}

