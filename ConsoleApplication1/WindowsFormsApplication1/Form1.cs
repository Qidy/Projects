using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.Visible = false;
            }
            else
            {
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = DateTime.Now.ToString();
            label1.Text = "hahah";
            button1.Visible = false;
            button2.Visible = false;
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
