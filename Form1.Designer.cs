
namespace WF_Grafic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Paint = new System.Windows.Forms.Panel();
            this.groupBox_Instr = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_lightblue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_blue = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.panel_Colour = new System.Windows.Forms.Panel();
            this.button_green = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_white = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox_Instr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Paint
            // 
            this.panel_Paint.BackColor = System.Drawing.Color.White;
            this.panel_Paint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Paint.Location = new System.Drawing.Point(12, 12);
            this.panel_Paint.Name = "panel_Paint";
            this.panel_Paint.Size = new System.Drawing.Size(729, 457);
            this.panel_Paint.TabIndex = 0;
            this.panel_Paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Paint_MouseDown);
            this.panel_Paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Paint_MouseMove);
            this.panel_Paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Paint_MouseUp);
            // 
            // groupBox_Instr
            // 
            this.groupBox_Instr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox_Instr.Controls.Add(this.checkBox5);
            this.groupBox_Instr.Controls.Add(this.checkBox4);
            this.groupBox_Instr.Controls.Add(this.checkBox3);
            this.groupBox_Instr.Controls.Add(this.checkBox2);
            this.groupBox_Instr.Controls.Add(this.checkBox1);
            this.groupBox_Instr.Controls.Add(this.button2);
            this.groupBox_Instr.Controls.Add(this.panel1);
            this.groupBox_Instr.Controls.Add(this.panel2);
            this.groupBox_Instr.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Instr.Location = new System.Drawing.Point(12, 475);
            this.groupBox_Instr.Name = "groupBox_Instr";
            this.groupBox_Instr.Size = new System.Drawing.Size(729, 131);
            this.groupBox_Instr.TabIndex = 1;
            this.groupBox_Instr.TabStop = false;
            this.groupBox_Instr.Text = "Панель инструментов";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(647, 26);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 50);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(577, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 50);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(437, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 50);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(507, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 50);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(377, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_lightblue);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_blue);
            this.panel1.Controls.Add(this.button_yellow);
            this.panel1.Controls.Add(this.panel_Colour);
            this.panel1.Controls.Add(this.button_green);
            this.panel1.Controls.Add(this.button_red);
            this.panel1.Controls.Add(this.button_white);
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 109);
            this.panel1.TabIndex = 3;
            // 
            // button_lightblue
            // 
            this.button_lightblue.BackColor = System.Drawing.Color.Aqua;
            this.button_lightblue.Location = new System.Drawing.Point(85, 53);
            this.button_lightblue.Name = "button_lightblue";
            this.button_lightblue.Size = new System.Drawing.Size(35, 34);
            this.button_lightblue.TabIndex = 5;
            this.button_lightblue.UseVisualStyleBackColor = false;
            this.button_lightblue.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(136, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 46);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_blue
            // 
            this.button_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_blue.Location = new System.Drawing.Point(44, 54);
            this.button_blue.Name = "button_blue";
            this.button_blue.Size = new System.Drawing.Size(35, 34);
            this.button_blue.TabIndex = 4;
            this.button_blue.UseVisualStyleBackColor = false;
            this.button_blue.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.Location = new System.Drawing.Point(3, 53);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(35, 34);
            this.button_yellow.TabIndex = 3;
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_change_Click);
            // 
            // panel_Colour
            // 
            this.panel_Colour.BackColor = System.Drawing.Color.White;
            this.panel_Colour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Colour.Location = new System.Drawing.Point(136, 53);
            this.panel_Colour.Name = "panel_Colour";
            this.panel_Colour.Size = new System.Drawing.Size(45, 34);
            this.panel_Colour.TabIndex = 0;
            this.panel_Colour.DoubleClick += new System.EventHandler(this.panel_Colour_DoubleClick);
            // 
            // button_green
            // 
            this.button_green.BackColor = System.Drawing.Color.Lime;
            this.button_green.Location = new System.Drawing.Point(85, 7);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(35, 34);
            this.button_green.TabIndex = 2;
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_red
            // 
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.Location = new System.Drawing.Point(44, 8);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(35, 34);
            this.button_red.TabIndex = 1;
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_white
            // 
            this.button_white.BackColor = System.Drawing.Color.Black;
            this.button_white.Location = new System.Drawing.Point(3, 8);
            this.button_white.Name = "button_white";
            this.button_white.Size = new System.Drawing.Size(35, 34);
            this.button_white.TabIndex = 0;
            this.button_white.UseVisualStyleBackColor = false;
            this.button_white.Click += new System.EventHandler(this.button_change_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(200, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 109);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер кисти";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 45);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(148, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 5;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.Location = new System.Drawing.Point(377, 78);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 50);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 618);
            this.Controls.Add(this.groupBox_Instr);
            this.Controls.Add(this.panel_Paint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Instr.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Paint;
        private System.Windows.Forms.GroupBox groupBox_Instr;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel_Colour;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_lightblue;
        private System.Windows.Forms.Button button_blue;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_white;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

