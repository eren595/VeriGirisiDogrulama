﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriGirişiDoğrulama
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Kullanıcı adını giriniz.", "Uyarı");
            }
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Şifreyi giriniz.", "Uyarı");
            }
            else {
                if (string.IsNullOrEmpty(txtAd.Text))
                {
                    MessageBox.Show("Kullanıcı adını giriniz.", "Uyarı");
                }
                if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Şifreyi giriniz.", "Uyarı");
                }

                {
                    Form2 Form2 = new Form2();
                    Form2.ShowDialog();
                }
            }
        }
    }
}
