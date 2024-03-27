using System;
using System.Windows.Forms;

namespace NavigationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm01_Click(object sender, EventArgs e)
        {
            Form02 form = new Form02();
            form.ShowDialog();
        }

        private void btnForm02_Click(object sender, EventArgs e)
        {
            Form03 form = new Form03();
            form.ShowDialog();
        }

        private void btnForm03_Click(object sender, EventArgs e)
        {
            Form04 form = new Form04();
            form.ShowDialog();
        }

        private void btnForm04_Click(object sender, EventArgs e)
        {
            Form05 form = new Form05();
            form.ShowDialog();
        }

        private void btnForm05_Click(object sender, EventArgs e)
        {
            Form06 form = new Form06();
            form.ShowDialog();
        }

        private void btnForm06_Click(object sender, EventArgs e)
        {
            Form07 form = new Form07();
            form.ShowDialog();
        }

        private void btnForm07_Click(object sender, EventArgs e)
        {
            Form08 form = new Form08();
            form.ShowDialog();
        }

        private void btnForm08_Click(object sender, EventArgs e)
        {
            Form09 form = new Form09();
            form.ShowDialog();
        }
    }
}
