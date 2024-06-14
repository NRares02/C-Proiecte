using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbore_de_decizie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            MessageBox.Show("High risk!", "Medical self-evaluation", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            MessageBox.Show("Low risk", "Medical self-evaluation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("High risk!", "Medical self-evaluation", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Low risk", "Medical self-evaluation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = SystemColors.Control;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rau.ro/?lang=en");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
