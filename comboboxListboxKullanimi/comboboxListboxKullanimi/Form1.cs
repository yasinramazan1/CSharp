﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxListboxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text + textBox4.Text + textBox5.Text +" "+ textBox6.Text); // "" ifadesi veriler arasında boşluk bırakmak için kullanılır!
            listBox2.Items.Add(textBox7.Text); // Bu bilgiyi listBox'ta alt satıra geçirerek yazar!
        }
    }
}
