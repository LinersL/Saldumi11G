﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LL_Saldumi11
{
    public partial class Form1 : Form
    {
        double cena = 0.00;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 20.3;
                Aprekins();

            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 16.1;
                Aprekins();

            }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 14.08;
                Aprekins();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 10.42;
                Aprekins();

            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 4.20;
                Aprekins();
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                cena = 9.88;
                Aprekins();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 6.22;
                Aprekins();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Nav neviens saldumu veids atlasits");
            }

        }
        private void Aprekins()
        {

            double sk1 = Convert.ToDouble(Summa.Text);
            double dati = sk1 / cena;
            double rezultats = Math.Round(dati, 2);
            Dati_TB.Text = rezultats.ToString();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dati_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter ceks = new StreamWriter(Application.StartupPath + "\\personasD\\" + textBox1 + dateTimePicker1 + " .txt");
            ceks.WriteLine()

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}