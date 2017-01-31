using System;
using System.Drawing;
using System.Windows.Forms;

namespace FleeingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            var width = rnd.Next(ClientSize.Width - button1.Size.Width);
            var height = rnd.Next(30, (ClientSize.Height) - button1.Size.Height);
            button1.Location = new Point(width, height);
        }
    }
}
