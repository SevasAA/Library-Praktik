﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm formRegistr = new loginForm();
            formRegistr.Show();
        }

       

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formRegistr = new FormAdmin();
            formRegistr.Show();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm formRegistr = new MainForm();
            formRegistr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPerson formRegistr = new FormPerson();
            formRegistr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElseLibrary formRegistr = new ElseLibrary();
            formRegistr.Show();
        }
    }
}