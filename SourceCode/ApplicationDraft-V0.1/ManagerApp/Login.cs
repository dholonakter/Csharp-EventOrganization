﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class Login : Form
    {
        DataHelper dh;
        SoundPlayer sound = new SoundPlayer("../../../error.wav");

        public Login()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ValidateLogin()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text.StartsWith("admin"))
                {
                    if (dh.CheckCredentials(textBox1.Text, textBox2.Text) == 1)
                    {
                        this.Hide();
                        Form mf = new HomeForm();
                        mf.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
                    sound.Play();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter pressed
            {
                ValidateLogin();
            }
        }
    }
}