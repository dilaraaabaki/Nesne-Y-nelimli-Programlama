using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            int x = Convert.ToInt32(textBox1.Text);
            int sayac = 0;
            for (int i = 2; i <= x; i++)
            {
                int check = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check++;
                        break;
                    }
                }
                if(check == 0)
                {
                    sayac++;
                }
                label2.Text = "1 -" + x + " arasında "+ sayac +" tane asal sayı vardır";

            }
            }
    }
    }

