using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string admin = textBox1.Text;
        }

         private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "password")
            {
                MessageBox.Show("Giriş Yapıldı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış tekrar deneyiniz");
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
