﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var execise1Form = new Form2();
            execise1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var execise2Form = new Form3();
            execise2Form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var execise3Form = new Form4();
            execise3Form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var execise4Form = new Form5();
            execise4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var execise5Form = new Form6();
            execise5Form.Show();
        }
    }
}