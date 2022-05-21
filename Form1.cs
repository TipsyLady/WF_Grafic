using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Grafic
{
    public partial class Form1 : Form
    {
        SolidBrush brush;
        Graphics g;
        bool isDrawing = false;
        int lenght;
        int width;
        int radius;
        PointF point1 = new Point();
        PointF point2 = new Point();
        PointF[] points = {};

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(panel_Colour.BackColor);
            g = panel_Paint.CreateGraphics();
            brush.Color = Color.Black;
            
        }

        private void panel_Colour_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel_Colour.BackColor = colorDialog1.Color;
                brush.Color = colorDialog1.Color;
            }
        }

        private void panel_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            
            isDrawing = true;
            if (checkBox1.Checked == true)
            {
                if (checkBox5.Checked==true)
                {
                    g.FillRectangle(brush, e.X, e.Y, lenght, width);
                }
                g.DrawRectangle(new Pen(brush.Color), e.X,e.Y, lenght, width);
            }
            if (checkBox3.Checked == true)
            {
                if (checkBox5.Checked == true)
                {
                    g.FillEllipse(brush, e.X, e.Y, radius, radius);
                }
                g.DrawEllipse(new Pen(brush.Color), e.X, e.Y, radius, radius);
            }
            if (checkBox4.Checked == true)
                point1 = new Point(e.X, e.Y);

        }

        private void panel_Paint_MouseUp(object sender, MouseEventArgs e)
        {
            if(checkBox4.Checked==true)
            {
                points = new PointF[] { point1, point2 };
                g.DrawPolygon(new Pen(brush.Color),points);
            }
            isDrawing = false;
        }

        private void panel_Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true && checkBox1.Checked==false&&checkBox3.Checked==false&&checkBox4.Checked==false)
            {
                g.FillEllipse(brush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
            if (checkBox4.Checked == true)
            {
                point2 = new Point(e.X, e.Y);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            brush.Color = Color.White;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            brush.Color = ((Button)sender).BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_Paint.Invalidate();
            panel_Paint.Update();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Form2 form = new Form2();
            form.ShowDialog();
            lenght = form._lenght;
            width = form._width;
            radius = form._radius;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                Form2 form = new Form2();
                form.ShowDialog();
                lenght = form._lenght;
                width = form._width;
                radius = form._radius;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
        }
    }
}
