﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;

namespace RentalApp
{
    public partial class Login : Form,ILogger
    {
        DataHelper dh;

        public Login()
        {
            InitializeComponent();
            dh = new DataHelper(this);
        }

        private void ValidateLogin()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text.StartsWith("loan") || textBox1.Text.StartsWith("admin"))
                {
                    if (dh.CheckCredentials(textBox1.Text, textBox2.Text) == 1)
                    {
                        // username should follow format: shop[shopNr] 
                        // the following code extracts the shopNr
                        string nr = Regex.Match(textBox1.Text, @"\d+").Value; // love and respect for regular expressions
                        this.Hide();
                        Form mf;
                        if (textBox1.Text.StartsWith("admin"))
                        {
                            mf = new RentalForm(null);
                        }
                        else
                        {
                            mf = new RentalForm(dh.GetShopByNr(nr));
                        }
                        mf.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
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

        public void LogMessage(string message)
        {
            lbxLoginMessage.Items.Add(message);
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxLoginMessage.Items.Clear();
        }
    }
}
