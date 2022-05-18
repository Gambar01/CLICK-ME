using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "CLICK MEEEE";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random r = new Random();
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CLICKED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Left = r.Next(0, 350);
            button2.Top = r.Next(0, 350);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Left = r.Next(0, 350);
            button2.Top = r.Next(0, 350);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Left = r.Next(0, 350);
            button2.Top = r.Next(0, 350);
        }

    }
}
