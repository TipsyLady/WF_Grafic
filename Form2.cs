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
    public partial class Form2 : Form
    {
        public int lenght;
        public int width;
        public int radius;

        public int _lenght
        {
        get { return (int)numericUpDown1.Value; }
        }

        public int _width
        {
            get
            {
                return (int)numericUpDown2.Value;
            }
        }
        public int _radius
        {
            get { return (int)numericUpDown3.Value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lenght = (int)numericUpDown1.Value;
            width = (int)numericUpDown2.Value;
            radius = (int)numericUpDown3.Value;
            Close();

        }
    }
}
