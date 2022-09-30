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
            this.pnl_centre = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Panel();
            this.lbl_light = new System.Windows.Forms.Label();
            this.lbl_computer = new System.Windows.Forms.Label();
            this.lbl_1_on = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.pnl_centre.SuspendLayout();
            this.label.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label.Controls.Add(this.label3);
            this.label.Controls.Add(this.label2);
            this.label.Controls.Add(this.label1);
            this.label.Controls.Add(this.lbl_1_on);
            this.label.Controls.Add(this.lbl_computer);
            this.label.Controls.Add(this.lbl_light);
            this.label.Location = new System.Drawing.Point(31, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(200, 135);
            this.label.TabIndex = 0;
            this.label.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lbl_light
            // 
            this.lbl_light.AutoSize = true;
            this.lbl_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_light.Location = new System.Drawing.Point(37, 28);
            this.lbl_light.Name = "lbl_light";
            this.lbl_light.Size = new System.Drawing.Size(38, 20);
            this.lbl_light.TabIndex = 0;
            this.lbl_light.Text = "light";
            // 
            // lbl_computer
            // 
            this.lbl_computer.AutoSize = true;
            this.lbl_computer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computer.Location = new System.Drawing.Point(37, 77);
            this.lbl_computer.Name = "lbl_computer";
            this.lbl_computer.Size = new System.Drawing.Size(76, 20);
            this.lbl_computer.TabIndex = 1;
            this.lbl_computer.Text = "computer";
            this.lbl_computer.Click += new System.EventHandler(this.lbl_computer_Click);
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ON";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "OFF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(297, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 135);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "OFF";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "ON";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "computer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "light";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(565, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 135);
            this.panel2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "OFF";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "ON";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "computer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "light";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Room101";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Room102";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(651, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Room103";
            this.label19.Click += new System.EventHandler(this.label19_Click);
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
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_centre;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel label;
        private System.Windows.Forms.Label lbl_computer;
        private System.Windows.Forms.Label lbl_light;
        private System.Windows.Forms.Label lbl_1_on;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

